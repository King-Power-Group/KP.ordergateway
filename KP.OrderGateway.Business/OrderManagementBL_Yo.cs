using KP.Common.Helper;
using KP.Common.Message;
using KP.Common.OrderGateway;
using KP.Common.Return;
using KP.OrderGateway.DBModel.NewKpiEntity;
using KP.OrderGateway.IService;
using KP.OrderGateway.ServiceModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static KP.OrderGateway.ServiceModel.OrderManagementModel;

namespace KP.OrderGateway.Business
{
    public partial class OrderManagementBL
    {
        public async Task<ReturnObject<ResultOrderModel>> DuplicateReceiveOrder(ReceiveOrderInfoModel requestOrder, bool isCancelOrder = false)
        {
            StringBuilder sbSqlQuery = new StringBuilder(10000);

            var ret = new ReturnObject<ResultOrderModel>() { Data = new ResultOrderModel() { branchNo = "", shoppingCard = "", orderNo = 0 } };
            try
            {

                ret.isCompleted = false;

                requestOrder.posIpAddress = StringBL.Strim(requestOrder.posIpAddress);


                //reqModel.orderType = StringBL.Strim(reqModel.orderType);
                //if (reqModel.orderType.Length == 0)
                //{
                //    reqModel.orderType = "P";
                //}

                //20-08-07 cancel order (Normal,Void,Refund)
                CancelOrderMode cancelOrderMode = CancelOrderMode.Normal;
                requestOrder.cancelOrderMode = StringBL.Strim(requestOrder.cancelOrderMode);
                if (isCancelOrder)
                {
                    cancelOrderMode = CancelOrderMode.Void;
                    if (requestOrder.cancelOrderMode == "refund")
                    {
                        cancelOrderMode = CancelOrderMode.Refund;
                    }
                }


                DateTime dOrderDate = DateTime.Now.Date;//.ToString("yyyy-MM-dd");
                var rsBr = _context.DfBranch.Where(w => w.BranchNo == requestOrder.branchNo).FirstOrDefault();
                if (rsBr != null)
                {
                    dOrderDate = rsBr.CurrentOrderDate;//.ToString("yyyy-MM-dd");


                    if (rsBr.StopSale)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#DupOrder/DfBranch",
                            MessageDesc = string.Format("Stop sale now! Can't continue sales process,Branch :{0} ,Order date : {1}", requestOrder.branchNo, dOrderDate.ToString("yyyy-MM-dd")),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        });
                        ret.isCompleted = false;
                        return ret;
                    }
                }

                int nLastOrderNo = _context.DfSohdr.Where(t => t.BranchNo == requestOrder.branchNo && t.ShoppingCard == requestOrder.shoppingCard).Max(o => o.OrderNo);
                nLastOrderNo++;

                string sErrorCheckLastOrder = "";

                var rsLastDfSohrd = _context.DfSohdr.Where(t => t.BranchNo == requestOrder.branchNo && t.ShoppingCard == requestOrder.shoppingCard
                        && t.OrderDate == dOrderDate.Date).OrderByDescending(o => o.OrderNo).Take(1).FirstOrDefault();//.Max(o => o.OrderNo);

                if (rsLastDfSohrd != null)
                {
                    string sLastOrderStatus = StringBL.Strim(rsLastDfSohrd.OrderStatus).Trim();
                    rsLastDfSohrd.LockAddress = StringBL.Strim(rsLastDfSohrd.LockAddress);

                    if (sLastOrderStatus == "a")
                    {
                        if (rsLastDfSohrd.LockAddress.IndexOf(requestOrder.posIpAddress) < 0)
                        {
                            sErrorCheckLastOrder = string.Format("This shopping card has been used by {0},last order status '{1}' ,please try again later!", rsLastDfSohrd.LockAddress, sLastOrderStatus);
                        }
                    }
                    else if ("e v".IndexOf(sLastOrderStatus) > -1)
                    {
                        sErrorCheckLastOrder = string.Format("This shopping card has been used by {0},last order status '{1}' ,please try again later!", rsLastDfSohrd.LockAddress, sLastOrderStatus);
                    }
                }

                if (sErrorCheckLastOrder.Length > 0)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#DupOrder/CheckLastOrder",
                        MessageDesc = sErrorCheckLastOrder,
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    });
                    ret.isCompleted = false;
                    return ret;
                }


                OrderManagementModel.OrderTypeModel reqChk = new OrderTypeModel
                {
                    actType = actType.SALE,
                    branchNo = requestOrder.branchNo,
                    orderNo = requestOrder.orderNo,
                    shoppingCard = requestOrder.shoppingCard
                };

                var chkOrderType = await GetOrderType(reqChk);


                string sValidOrderType = String.Format("{0} {1} {2} {3} {4} {5}", OrderType.PreOrder, OrderType.Receive, OrderType.DutyPaidDelivery, OrderType.Shipping, OrderType.ReceivePreOrder, OrderType.ShippingDutyPaidDelivery);

                chkOrderType.Data = StringBL.Strim(chkOrderType.Data);

                if (sValidOrderType.IndexOf(chkOrderType.Data) == -1)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#DupOrder/ValidCheckOrderType",
                        MessageDesc = string.Format("Invalid order type {0} --> {1}", chkOrderType.Data, sValidOrderType),
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    });
                    ret.isCompleted = false;
                    return ret;
                }


                PreOrderChangeFlight preOrder = null;
                if (chkOrderType.Data == OrderType.PreOrder || chkOrderType.Data == OrderType.Receive)
                {

                    if (chkOrderType.Data == OrderType.PreOrder)
                    {
                        preOrder = _context.PreOrderChangeFlight.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard
                              && m.OrderNo == requestOrder.orderNo).FirstOrDefault();
                    }
                    else
                    {
                        preOrder = _context.PreOrderChangeFlight.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard
                            && m.ReceiveOrderNo == requestOrder.orderNo).FirstOrDefault();
                    }
                    if (preOrder != null)
                    {
                        if (chkOrderType.Data != preOrder.OrderStatus)
                        {
                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#DupOrder/OrderChangeFlight/CancelOrder",
                                MessageDesc = string.Format("Not macth order type DfSohdr {0} and PreOrderChangeFlight {1}", chkOrderType.Data, preOrder.OrderStatus),
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            });
                            ret.isCompleted = false;
                            return ret;
                        }
                    }
                    else if (preOrder == null)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#DupOrder/OrderChangeFlight",
                            MessageDesc = "Not found flight with customer confirmation.",
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        });
                        ret.isCompleted = false;
                        return ret;
                    }


                    //Check box
                    if (isCancelOrder)
                    {
                        //var qCheckBox = _context.PkBoxHeader.Where(b => b.PkBoxDetail.Where(w => w.DfSubsohdr.BranchNo == requestOrder.branchNo && w.DfSubsohdr.ShoppingCard == requestOrder.shoppingCard
                        //    && w.DfSubsohdr.OrderNo == requestOrder.orderNo && w.CanceledDt.HasValue == false).FirstOrDefault() != null && b.CanceledDt.HasValue == false);

                        var rsCheckBox = _context.PkBoxHeader.Where(b => b.PkBoxDetail.Where(w => w.DfSubsohdr.BranchNo == requestOrder.branchNo && w.DfSubsohdr.ShoppingCard == requestOrder.shoppingCard
                                        && w.DfSubsohdr.OrderNo == requestOrder.orderNo && w.CanceledDt.HasValue == false).FirstOrDefault() != null && b.CanceledDt.HasValue == false).FirstOrDefault();
                        if (rsCheckBox != null)
                        {

                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#DupOrder/CheckBox",
                                MessageDesc = String.Format("Not allow cancel this order, found order on box {0}", rsCheckBox.BoxNo),
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            });
                            ret.isCompleted = false;
                            return ret;
                        }
                    }
                }

                //Check current order not use by other order
                var rsCheckUseOrderBy = _context.DfSohdrExt.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard && m.OrderNo == requestOrder.orderNo && m.Code == OrderConstants.RECEIVE_ORDER_NO).FirstOrDefault();
                if (rsCheckUseOrderBy != null)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#DupOrder/RECEIVE_ORDER_NO",
                        MessageDesc = string.Format("This order no {0} recieved by order no {1}", requestOrder.orderNo, rsCheckUseOrderBy.Value),
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    });
                    ret.isCompleted = false;
                    return ret;
                }


                DfSohdr sohdr = null;
                //if (chkOrderType.Data == OrderType.DutyPaidDelivery || chkOrderType.Data == OrderType.PreOrder)

                sohdr = _context.DfSohdr.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard && m.OrderNo == requestOrder.orderNo && m.OrderStatus == "E" && m.CancelToOrder == 0).FirstOrDefault();

                if (sohdr == null)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#DupOrder/DfSohdr",
                        MessageDesc = string.Format("Not found order status 'E', shopping card :{0} , order no : {1}.", requestOrder.shoppingCard, requestOrder.orderNo),
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    });
                    ret.isCompleted = false;
                    return ret;
                }
                else
                {
                    var chkPre = _context.PreOrderChangeFlight.Where(a => a.BranchNo == requestOrder.branchNo && a.ShoppingCard == requestOrder.shoppingCard && a.OrderNo == requestOrder.orderNo).FirstOrDefault();
                    if(chkPre!=null)
                    {
                        if (StringBL.StringNullToEmpty(chkPre.AirlineCode) == "MJE")
                        {
                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#MJET/DfSohdr",
                                MessageDesc = string.Format("MJE = MJets Private"),
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            });
                            ret.isCompleted = false;
                            return ret;
                        }
                    }
                    else
                    {
                        if (StringBL.StringNullToEmpty(sohdr.AirlineCode) == "MJE")
                        {
                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#MJET/DfSohdr",
                                MessageDesc = string.Format("MJE = MJets Private"),
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            });
                            ret.isCompleted = false;
                            return ret;
                        }
                    }

                }

                var rsMachine = _context.DfMachine.Where(w => w.BranchNo == requestOrder.branchNo && w.MachineIp == requestOrder.posIpAddress).FirstOrDefault();
                if (rsMachine == null)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#DupOrder/DfMachine",
                        MessageDesc = "Not found machine with IP :" + requestOrder.posIpAddress,
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    });
                    ret.isCompleted = false;
                    return ret;
                }
                else
                {
                    if (rsMachine.ECommerceFlag)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#DupOrder/DfMachine",
                            MessageDesc = "Not allow machine use WHITE TAG (eCommerce) machine :" + StringBL.Strim(rsMachine.MachineNo),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        });
                        ret.isCompleted = false;
                        return ret;
                    }
                }

                int multiply = 1;

                string sAuthorization = "";
                string sCallerID = "";
                string sHangingUrl = "";

                bool isNewHanging2020 = false;

                var rsNewHangConfig = _context.ConfigPos.Where(w => w.ConfigCode == "Pack_StartNewHanging").FirstOrDefault();
                if (rsNewHangConfig != null)
                {
                    if (rsNewHangConfig.ConfigData == "Y")
                    {
                        isNewHanging2020 = true;
                    }
                }

                if (isNewHanging2020 == false)
                {
                    var lsConfig = _context.ConfigPos.Where(w => w.ConfigCode.StartsWith("Hanging-")).ToList();
                    var rsFirst = lsConfig.Where(w => w.ConfigCode == "Hanging-Authorization").FirstOrDefault();
                    if (rsFirst != null)
                    {
                        sAuthorization = StringBL.Strim(rsFirst.ConfigData);
                    }
                    rsFirst = lsConfig.Where(w => w.ConfigCode == "Hanging-CallerID").FirstOrDefault();
                    if (rsFirst != null)
                    {
                        sCallerID = StringBL.Strim(rsFirst.ConfigData);
                    }
                    rsFirst = lsConfig.Where(w => w.ConfigCode == "Hanging-ApiUrl").FirstOrDefault();
                    if (rsFirst != null)
                    {
                        sHangingUrl = StringBL.Strim(rsFirst.ConfigData);
                    }

                    if (sAuthorization.Length == 0 || sCallerID.Length == 0 || sHangingUrl.Length == 0)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#DupOrder/ConfigPos",
                            MessageDesc = "Not found ConfigPos Hanging-CallerID/Hanging-Authorization",
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        });
                        ret.isCompleted = false;
                        return ret;
                    }
                }
                //------if (isNewHanging2020 == false)--------------


                if (isCancelOrder == true)
                {
                    //On cancel order
                    //Check refund order must old machine
                    if (sohdr.CashierMac != rsMachine.MachineNo)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#CancelOrder/Machine",
                            MessageDesc = string.Format("Not allow cancel order not macth old machine {0} and {1}", sohdr.CashierMac, rsMachine.MachineNo),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        });
                        ret.isCompleted = false;
                        return ret;
                    }

                    multiply = -1;//Reverse order
                }



                string sMachineNo = "";
                string sMachineTax = "";
                sMachineNo = StringBL.Strim(rsMachine.MachineNo);
                sMachineTax = StringBL.Strim(rsMachine.MachineTax);

                //Start Duplicate ---> DfSohrd...

                StringBuilder sbSqlCommand = new StringBuilder(1000);
                List<string> lsSqlBatch = new List<string>();
               


                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohdr] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no],[order_date],[tour_code],[cust_type_code] ");
                        sbSqlCommand.AppendLine(",[airline_code],[flight_code],[flight_date],[flight_time],[country_code],[order_status] ");
                        sbSqlCommand.AppendLine(",[posid],[cashier_mac],[cashier_code],[update_date_sale],[add_datetime],[update_datetime] ");
                        sbSqlCommand.AppendLine(",[user_add],[user_update],[lock_address],[cancel_to_order],[hotel_code],[hotel_source] ");
                        sbSqlCommand.AppendLine(",[shop_ref],[machine_tax],[ref_doc],[CardTypeCode],[EmBossID],[CardTypeID] ");
                        sbSqlCommand.AppendLine(",[LVHeaderKey],[AlipaySession],[paid_guid]) ");
                        sbSqlCommand.AppendLine("SELECT  ");
                        sbSqlCommand.AppendFormat(" '{0}' ,'{1}' ,{2} ,'{3}',[tour_code],[cust_type_code] ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo, dOrderDate.ToString("yyyy-MM-dd"));
                        if (preOrder != null)
                        {
                            sbSqlCommand.AppendFormat(",'{0}' ,'{1}' ,'{2}' ,'{3}' ,[country_code],'{4}' [order_status] ", preOrder.AirlineCode, preOrder.FlightCode, preOrder.FlightDt.ToString("yyyy-MM-dd"), preOrder.FlightDt.ToString("HH:mm"), (isCancelOrder ? "V" : "E"));
                        }
                        else
                        {
                            sbSqlCommand.AppendFormat(",'{0}' ,'{1}' ,'{2}' ,'{3}' ,[country_code],'{4}' [order_status] ", sohdr.AirlineCode, sohdr.FlightCode, sohdr.FlightDate.Value.ToString("yyyy-MM-dd"), sohdr.FlightTime, (isCancelOrder ? "V" : "E"));
                        }
                        sbSqlCommand.AppendFormat(",'{0}' ,'{1}' ,'{2}' ,[update_date_sale],GETDATE() [add_datetime],GETDATE() [update_datetime] ", sMachineNo, sMachineNo, requestOrder.cashierCode);
                        sbSqlCommand.AppendFormat(",'{0}' ,'{1}' ,'' [lock_address], {2} [cancel_to_order],[hotel_code],[hotel_source] ", requestOrder.changeBy, requestOrder.changeBy, (isCancelOrder ? sohdr.OrderNo * multiply : 0));
                        sbSqlCommand.AppendFormat(",[shop_ref],'{0}' [machine_tax],[ref_doc],[CardTypeCode],[EmBossID],[CardTypeID] ", sMachineTax);
                        sbSqlCommand.AppendLine(",[LVHeaderKey],[AlipaySession],[paid_guid] ");
                        sbSqlCommand.AppendLine(" FROM [dbo].[df_sohdr] ");
                        sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", sohdr.BranchNo);
                        sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", sohdr.ShoppingCard);
                        sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ;", sohdr.OrderNo);
                        lsSqlBatch.Add(sbSqlCommand.ToString());



                        //2021-10-05 cost delivery
                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohdr_extend] ");
                        sbSqlCommand.AppendLine("( [branch_no],[shopping_card],[order_no] ");
                        sbSqlCommand.AppendLine(",[eCommerceOrderNo],[IsDelivery],[PickupTypeCode] ");
                        sbSqlCommand.AppendLine(",[PlatformID],[DeliveryCost],[Plant] ");
                        sbSqlCommand.AppendLine(",[add_datetime],[user_add] )");

                        sbSqlCommand.AppendLine("SELECT  ");
                        sbSqlCommand.AppendFormat(" '{0}' ,'{1}' ,{2} ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo);
                        sbSqlCommand.AppendLine(",[eCommerceOrderNo],[IsDelivery],[PickupTypeCode] ");
                        sbSqlCommand.AppendFormat(",[PlatformID],( [DeliveryCost] * {0} ),[Plant] ", multiply);
                        sbSqlCommand.AppendFormat(",GETDATE() [add_datetime],'{0}' ", requestOrder.cashierCode);

                        sbSqlCommand.AppendLine(" FROM [dbo].[df_sohdr_extend] ");
                        sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", sohdr.BranchNo);
                        sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", sohdr.ShoppingCard);
                        sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ;", sohdr.OrderNo);
                        lsSqlBatch.Add(sbSqlCommand.ToString());



                        foreach (var iSo in sohdr.DfSohdrExt)
                        {
                            if (iSo.Code != KP.Common.OrderGateway.OrderConstants.REF_ORDER_NO)
                            {
                                sbSqlCommand.Length = 0;
                                sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohdr_ext] ");
                                sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no] ");
                                sbSqlCommand.Append(",[Code],[Value]  ");
                                sbSqlCommand.Append(") ");
                                sbSqlCommand.AppendLine("SELECT  ");
                                sbSqlCommand.AppendFormat("[branch_no],[shopping_card], {0} ", nLastOrderNo);
                                sbSqlCommand.Append(",[Code] ");
                                if (iSo.Code == KP.Common.OrderGateway.OrderConstants.ORDER_TYPE)
                                {
                                    if (iSo.Value == OrderType.PreOrder)
                                        sbSqlCommand.AppendFormat(",'{0}' ", OrderType.Receive);
                                    else if (iSo.Value == OrderType.DutyPaidDelivery)
                                        sbSqlCommand.AppendFormat(",'{0}' ", OrderType.Shipping);
                                    else if (iSo.Value == OrderType.Receive)
                                        sbSqlCommand.AppendFormat(",'{0}' ", OrderType.ReceivePreOrder);
                                    else if (iSo.Value == OrderType.Shipping)
                                        sbSqlCommand.AppendFormat(",'{0}' ", OrderType.ShippingDutyPaidDelivery);
                                    else
                                        sbSqlCommand.Append(",[Value]  ");
                                    //iSo.Value = OrderType.Receive;
                                }
                                else
                                {
                                    sbSqlCommand.Append(",[Value]  ");
                                }
                                sbSqlCommand.AppendLine(" FROM [dbo].[df_sohdr_ext] ");
                                sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", iSo.BranchNo);
                                sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", iSo.ShoppingCard);
                                sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ", iSo.OrderNo);
                                sbSqlCommand.AppendFormat(" AND   [Code] = '{0}' ", iSo.Code);

                                lsSqlBatch.Add(sbSqlCommand.ToString());
                            }
                        }

                        //Receive order no
                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohdr_ext] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no] ");
                        sbSqlCommand.Append(",[Code],[Value]  ");
                        sbSqlCommand.Append(") ");
                        sbSqlCommand.AppendLine("VALUES ( ");
                        sbSqlCommand.AppendFormat("'{0}','{1}','{2}','{3}','{4}')",
                            sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo, KP.Common.OrderGateway.OrderConstants.REF_ORDER_NO, sohdr.OrderNo);

                        lsSqlBatch.Add(sbSqlCommand.ToString());

                        //Pre order no
                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohdr_ext] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no] ,[Code],[Value]  ");
                        sbSqlCommand.Append(") ");
                        sbSqlCommand.AppendLine("VALUES ( ");
                        sbSqlCommand.AppendFormat("'{0}','{1}','{2}','{3}','{4}')",
                            sohdr.BranchNo, sohdr.ShoppingCard, sohdr.OrderNo, KP.Common.OrderGateway.OrderConstants.RECEIVE_ORDER_NO, nLastOrderNo);

                        lsSqlBatch.Add(sbSqlCommand.ToString());


                        //If cancel order clear RefOrderNo first order
                        if (isCancelOrder)
                        {
                            //If refund --> not clear original ReceiveOrderNo
                            if (cancelOrderMode == CancelOrderMode.Void)
                            {
                                var rsOriginalOrderNo = sohdr.DfSohdrExt.Where(w => w.Code == OrderConstants.REF_ORDER_NO).FirstOrDefault();
                                if (rsOriginalOrderNo != null)
                                {
                                    //Clear ReceiveOrderNo
                                    sbSqlCommand.Length = 0;
                                    sbSqlCommand.AppendLine("DELETE FROM [dbo].[df_sohdr_ext] ");
                                    sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' AND [shopping_card] ='{1}' AND [order_no] = {2} AND [Code] ='{3}'",
                                        sohdr.BranchNo, sohdr.ShoppingCard, rsOriginalOrderNo.Value, OrderConstants.RECEIVE_ORDER_NO);

                                    lsSqlBatch.Add(sbSqlCommand.ToString());

                                }
                            }
                        }

                        string sTaxabbNo = "00001";
                        string sClaimcheckNo = "00001";

                        //-------------df_subsohdr-------------
                        var lsSubsohdr = _context.DfSubsohdr.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard && m.OrderNo == requestOrder.orderNo).ToList();
                        foreach (var iSub in lsSubsohdr)
                        {                         
                            var rsRunnoMachine = _context.RunnoMachine.Where(w => w.BranchNo == requestOrder.branchNo && w.MachineNo == sMachineNo).FirstOrDefault();
                            if (rsRunnoMachine != null)
                            {
                                rsRunnoMachine.Taxabb++;
                                rsRunnoMachine.Reciept++;
                                sTaxabbNo = rsRunnoMachine.Taxabb.ToString("00000");
                                sClaimcheckNo = rsRunnoMachine.Reciept.ToString("00000");
                            }
                            else
                            {
                                var newRunnoMachine = new DBModel.NewKpiEntity.RunnoMachine() { BranchNo = requestOrder.branchNo, MachineNo = sMachineNo, Reciept = 1, Taxabb = 1 };
                                _context.RunnoMachine.Add(newRunnoMachine);
                            }
                            _context.SaveChanges();


                            var pickupParam = new InputPickupFromFlight()
                            {
                                airlineCode = StringBL.StringNullToEmpty(sohdr.AirlineCode),
                                branchNo = StringBL.StringNullToEmpty(sohdr.BranchNo),
                                flightCode = StringBL.StringNullToEmpty(sohdr.FlightCode),
                                isIncludeName = false
                            };


                            var checkPreOrderChangeFlight = _context.PreOrderChangeFlight.Where(a => a.BranchNo == sohdr.BranchNo && a.ShoppingCard == sohdr.ShoppingCard && a.OrderNo == sohdr.OrderNo).FirstOrDefault();
                            if(checkPreOrderChangeFlight!=null)
                            {
                                pickupParam.airlineCode = StringBL.StringNullToEmpty(checkPreOrderChangeFlight.AirlineCode);
                                pickupParam.branchNo = StringBL.StringNullToEmpty(checkPreOrderChangeFlight.BranchNo);
                                pickupParam.flightCode = StringBL.StringNullToEmpty(checkPreOrderChangeFlight.FlightCode); 
                            }


                            sbSqlCommand.Length = 0;
                            sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_subsohdr] ");
                            sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no],[suborder_type],[order_date] ");
                            sbSqlCommand.AppendLine(",[taxabb_no],[claimcheck_no],[opaq_no],[box_no],[truck_no] ");
                            sbSqlCommand.AppendLine(",[trip_no],[truck_datetime],[pickup_code],[hanging_no],[move_hanging_datetime] ");
                            sbSqlCommand.AppendLine(",[old_hanging],[pickup_staff_code],[pickup_datetime],[issued_status],[issued_datetime] ");
                            sbSqlCommand.AppendLine(",[issued_by],[cashier_mac],[cancel_status],[add_datetime],[update_datetime] ");
                            sbSqlCommand.AppendLine(",[user_update],[user_add],[pack_staff_code],[opaq_by],[box_by] ");
                            sbSqlCommand.AppendLine(",[truck_by],[issued_type],[trans_doc],[trans_line],[ref_no] ");
                            sbSqlCommand.AppendLine(",[FRN],[NewHangingNo],[OpaqTFKey],[BoxType],[ClaimTax]) ");
                            sbSqlCommand.AppendLine("SELECT  ");
                            sbSqlCommand.AppendFormat("'{0}' ,'{1}' ,{2} ,[suborder_type],'{3}' ", iSub.BranchNo, iSub.ShoppingCard, nLastOrderNo, dOrderDate.ToString("yyyy-MM-dd"));
                            sbSqlCommand.AppendFormat(",'{0}' ,'{1}' ,[opaq_no],[box_no],[truck_no] ", sTaxabbNo, sClaimcheckNo);

                            if (isNewHanging2020)
                            {
                                if (preOrder != null)
                                {
                                    sbSqlCommand.AppendLine(",[trip_no],[truck_datetime],'" + getPickupFromFlight(pickupParam).Data + "',[hanging_no],[move_hanging_datetime] ");
                                }
                                else
                                {
                                    sbSqlCommand.AppendLine(",[trip_no],[truck_datetime],[pickup_code],[hanging_no],[move_hanging_datetime] ");
                                }
                            }
                            else
                            {
                                sbSqlCommand.AppendLine(",[trip_no],[truck_datetime],[pickup_code],[hanging_no],[move_hanging_datetime] ");
                            }
                            sbSqlCommand.AppendLine(",[old_hanging],[pickup_staff_code],[pickup_datetime],[issued_status],[issued_datetime] ");
                            sbSqlCommand.AppendFormat(",[issued_by],'{0}' [cashier_mac],[cancel_status],GETDATE() [add_datetime],GETDATE() [update_datetime] ", sMachineNo);
                            sbSqlCommand.AppendFormat(",'{0}','{1}',[pack_staff_code],[opaq_by],[box_by] ", requestOrder.changeBy, requestOrder.changeBy);
                            sbSqlCommand.AppendLine(",[truck_by],[issued_type],[trans_doc],[trans_line],[ref_no] ");
                            sbSqlCommand.AppendLine(",[FRN],[NewHangingNo],[OpaqTFKey],[BoxType],[ClaimTax] ");
                            sbSqlCommand.AppendLine("FROM [dbo].[df_subsohdr] ");
                            sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", iSub.BranchNo);
                            sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", iSub.ShoppingCard);
                            sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ", iSub.OrderNo);
                            sbSqlCommand.AppendFormat(" AND   [suborder_type] = '{0}' ;", iSub.SuborderType);

                            lsSqlBatch.Add(sbSqlCommand.ToString());

                        }


                        //-------------df_sohist-------------
                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohist] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no],[suborder_type],[line_no] ");
                        sbSqlCommand.AppendLine(",[item_code],[mat_code],[tbag_no],[quantity],[selling_price] ");
                        sbSqlCommand.AppendLine(",[amount],[discount],[net],[vat],[vatno] ");
                        sbSqlCommand.AppendLine(",[vat_rate],[disc_code],[disc_rate],[promo_code],[staff_code] ");
                        sbSqlCommand.AppendLine(",[staff_comm_rate],[consol_flag],[arrival_flag],[cancel_status],[pick_status] ");
                        sbSqlCommand.AppendLine(",[machine_no],[collect_status],[tbag_issue],[tbag_datetime],[add_datetime] ");
                        sbSqlCommand.AppendLine(",[update_datetime],[user_add],[user_update],[new_tbag],[line_cancel] ");
                        sbSqlCommand.AppendLine(",[recieve_qty],[recieve_flag],[recieve_user],[recieve_datetime],[consol_qty] ");
                        sbSqlCommand.AppendLine(",[consol_datetime],[consol_user],[LockDiscount],[Rewards],[RewardsPoint] ");
                        sbSqlCommand.AppendLine(",[RewardsPrice],[RewardsKarat]) ");
                        sbSqlCommand.AppendLine("SELECT ");
                        sbSqlCommand.AppendFormat("'{0}' [branch_no],'{1}' [shopping_card],{2} [order_no],[suborder_type],[line_no] ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo);
                        sbSqlCommand.AppendFormat(",[item_code],[mat_code],[tbag_no],[quantity] * {0},[selling_price] ", multiply);
                        sbSqlCommand.AppendFormat(",[amount] * {0},[discount] * {0},[net] * {0},[vat] * {0},[vatno] ", multiply);
                        sbSqlCommand.AppendLine(",[vat_rate],[disc_code],[disc_rate],[promo_code],[staff_code] ");
                        sbSqlCommand.AppendLine(",[staff_comm_rate],[consol_flag],[arrival_flag],[cancel_status],[pick_status] ");
                        sbSqlCommand.AppendFormat(",'{0}' [machine_no],[collect_status],[tbag_issue],[tbag_datetime],GETDATE() [add_datetime] ", sMachineNo);
                        sbSqlCommand.AppendFormat(",GETDATE() [update_datetime],'{0}' [user_add],'{1}' [user_update],[new_tbag],[line_cancel] ", requestOrder.changeBy, requestOrder.changeBy);
                        sbSqlCommand.AppendLine(",[recieve_qty],[recieve_flag],[recieve_user],[recieve_datetime],[consol_qty] ");
                        sbSqlCommand.AppendLine(",[consol_datetime],[consol_user],[LockDiscount],[Rewards],[RewardsPoint] ");
                        sbSqlCommand.AppendLine(",[RewardsPrice],[RewardsKarat] ");
                        sbSqlCommand.AppendLine("FROM [dbo].[df_sohist] ");
                        sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", sohdr.BranchNo);
                        sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", sohdr.ShoppingCard);
                        sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ", sohdr.OrderNo);
                        sbSqlCommand.AppendLine(" AND [line_cancel] = 0 ;");

                        lsSqlBatch.Add(sbSqlCommand.ToString());

                        //-------------df_sohist_ext-------------
                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_sohist_ext] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no] ");
                        sbSqlCommand.AppendLine(",[suborder_type],[line_no],[Code],[Value]) ");
                        sbSqlCommand.AppendLine("SELECT ");
                        sbSqlCommand.AppendFormat("'{0}','{1}',{2} ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo);
                        sbSqlCommand.AppendLine(",[suborder_type],[line_no],[Code],[Value] ");
                        sbSqlCommand.AppendLine("FROM [dbo].[df_sohist_ext] ");
                        sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", sohdr.BranchNo);
                        sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", sohdr.ShoppingCard);
                        sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ;", sohdr.OrderNo);

                        lsSqlBatch.Add(sbSqlCommand.ToString());


                        //-------------df_serial_no-------------2021-06-22
                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_serial_no] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no] ");
                        sbSqlCommand.AppendLine(",[line_no],[serial_no] ");
                        sbSqlCommand.AppendLine(",[add_datetime],[update_datetime] ");
                        sbSqlCommand.AppendLine(",[user_add],[user_update]) ");
                        sbSqlCommand.AppendLine("SELECT ");
                        sbSqlCommand.AppendFormat("'{0}','{1}',{2} ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo);
                        sbSqlCommand.AppendLine(",[line_no],[serial_no] ");
                        sbSqlCommand.AppendLine(",GETDATE() [add_datetime],GETDATE() [update_datetime] ");
                        sbSqlCommand.AppendFormat(",'{0}','{1}' ", requestOrder.changeBy, requestOrder.changeBy);
                        sbSqlCommand.AppendLine("FROM [dbo].[df_serial_no] ");
                        sbSqlCommand.AppendFormat(" WHERE [branch_no] ='{0}' ", sohdr.BranchNo);
                        sbSqlCommand.AppendFormat(" AND   [shopping_card] ='{0}' ", sohdr.ShoppingCard);
                        sbSqlCommand.AppendFormat(" AND   [order_no] = '{0}' ;", sohdr.OrderNo);

                        lsSqlBatch.Add(sbSqlCommand.ToString());


                        //----------------------------------

                        sbSqlQuery.Length = 0;
                        sbSqlQuery.AppendLine("SELECT [suborder_type]  ");
                        sbSqlQuery.AppendLine(",SUM([amount]) AS [amount] ");
                        sbSqlQuery.AppendLine(",SUM([amount_vat]) AS [amount_vat] ");
                        sbSqlQuery.AppendLine("FROM [dbo].[df_subpayment] ");
                        sbSqlQuery.AppendFormat(" WHERE [branch_no] ='{0}' ", sohdr.BranchNo);
                        sbSqlQuery.AppendFormat(" AND   [shopping_card] ='{0}' ", sohdr.ShoppingCard);
                        sbSqlQuery.AppendFormat(" AND   [order_no] = '{0}' ;", sohdr.OrderNo);
                        sbSqlQuery.AppendLine(" AND [del_flag] =' ' ");
                        sbSqlQuery.AppendLine("GROUP BY [suborder_type] ");

                        var rsSubPay = _context.DfSubpayment.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard && m.OrderNo == requestOrder.orderNo)
                            .GroupBy(x => x.SuborderType).Select(g => new QuerySumPaymentModel() { suborder_type = g.Key, amount = g.Sum(x => x.Amount), amount_vat = g.Sum(x => x.AmountVat) }).ToList();

                        foreach (var item in rsSubPay)
                        {
                            sbSqlCommand.Length = 0;
                            sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_subpayment] ");
                            sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no],[suborder_type] ");
                            sbSqlCommand.AppendLine(",[line_no],[method_code],[cred_card_no],[payment_date] ");
                            sbSqlCommand.AppendLine(",[amount],[amount_vat],[del_flag],[add_datetime] ");
                            sbSqlCommand.AppendLine(",[update_datetime],[user_add],[user_update]) ");
                            sbSqlCommand.AppendLine(" VALUES ");
                            sbSqlCommand.AppendFormat(" ('{0}','{1}','{2}','{3}' ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo, item.suborder_type);
                            sbSqlCommand.AppendLine(",1 ,'66' ,'' ,GETDATE()  ");
                            sbSqlCommand.AppendFormat(",{0} ,{1} ,' ' ,GETDATE() ", item.amount * multiply, item.amount_vat * multiply);
                            sbSqlCommand.AppendFormat(",GETDATE() ,'{0}' ,'{1}' );", requestOrder.changeBy, requestOrder.changeBy);

                            lsSqlBatch.Add(sbSqlCommand.ToString());
                        }

                        var nSumPayAmount = _context.DfSubpayment.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard && m.OrderNo == requestOrder.orderNo).Sum(s => s.Amount);

                        sbSqlCommand.Length = 0;
                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_payment] ");
                        sbSqlCommand.AppendLine("([branch_no],[shopping_card],[order_no],[line_no] ");
                        sbSqlCommand.AppendLine(",[method_code],[payment_date],[amount],[amount_round] ");
                        sbSqlCommand.AppendLine(",[amount_curr],[curr_code],[curr_rate],[cashier_code] ");
                        sbSqlCommand.AppendLine(",[posid],[cred_card_no],[cred_card_name],[expiry_date] ");
                        sbSqlCommand.AppendLine(",[approve_code],[del_flag],[add_datetime],[update_datetime] ");
                        sbSqlCommand.AppendLine(",[user_add],[user_update],[BankOfEDC],[AliBarcode] ");
                        sbSqlCommand.AppendLine(",[AliMerchantID],[AliTransID],[AlipayCancel]) ");
                        sbSqlCommand.AppendLine(" VALUES ");
                        sbSqlCommand.AppendFormat(" ('{0}','{1}','{2}','{3}' ", sohdr.BranchNo, sohdr.ShoppingCard, nLastOrderNo, 1);
                        sbSqlCommand.AppendFormat(",'66',GETDATE(),{0},0.00 ", nSumPayAmount * multiply);
                        sbSqlCommand.AppendFormat(",{0},'THB',1.00,'{1}' ", nSumPayAmount * multiply, requestOrder.cashierCode);
                        sbSqlCommand.AppendFormat(",'{0}','','',GETDATE() ", sMachineNo);
                        sbSqlCommand.AppendLine(",'',' ',GETDATE(),GETDATE() ");
                        sbSqlCommand.AppendFormat(",'{0}','{1}','','' ", requestOrder.changeBy, requestOrder.changeBy);
                        sbSqlCommand.AppendLine(",'','',0) ");

                        lsSqlBatch.Add(sbSqlCommand.ToString());



                        OrderAttribute jsonNewOrderAttribute = new OrderAttribute() { branch_no = sohdr.BranchNo, shopping_card = sohdr.ShoppingCard, order_no = nLastOrderNo.ToString() };
                        OrderAttribute jsonOldOrderAttribute = new OrderAttribute() { branch_no = sohdr.BranchNo, shopping_card = sohdr.ShoppingCard, order_no = sohdr.OrderNo.ToString() };

                        string sJsonNewOrderAttribute = JsonConvert.SerializeObject(jsonNewOrderAttribute);
                        string sJsonOldOrderAttribute = JsonConvert.SerializeObject(jsonOldOrderAttribute);

                        //sbSqlCommand.Length = 0;
                        //sbSqlCommand.AppendLine("INSERT INTO [dbo].[Attribute] ");
                        //sbSqlCommand.AppendLine("([AttrPrimary],[AttrValue]) ");
                        //sbSqlCommand.AppendFormat("SELECT {0} ", sJsonNewOrderAttribute);
                        //sbSqlCommand.AppendLine(" ,[AttrValue] "  );
                        //sbSqlCommand.AppendLine("FROM[dbo].[Attribute] ");
                        //sbSqlCommand.AppendFormat("WHERE AttrPrimary = {0} " , sJsonOldOrderAttribute);
                        //lsSqlBatch.Add(sbSqlCommand.ToString());

                        var rsOldAttribute = _context.Attribute.Where(w => w.AttrPrimary == sJsonOldOrderAttribute).FirstOrDefault();
                        if (rsOldAttribute != null)
                        {
                            DBModel.NewKpiEntity.Attribute newAttribute = new DBModel.NewKpiEntity.Attribute()
                            {
                                AttrPrimary = sJsonNewOrderAttribute,
                                AttrValue = rsOldAttribute.AttrValue
                            };

                            _context.Attribute.Add(newAttribute);
                        }

                        //string logsql = string.Format(@"C:\temp\sql\batchsql{0}_{1}_{2}.txt", reqModel.branchNo, reqModel.shoppingCard, nLastOrderNo);

                        //foreach (var sqlCommand in lsSqlBatch)
                        //{
                        //    System.IO.File.AppendAllText(logsql, sqlCommand + "\r\n\r\n");
                        //}
                        //System.IO.File.AppendAllText(logsql, "\r\n--------ExecuteSqlCommand--------\r\n");

                        foreach (var sqlCommand in lsSqlBatch)
                        {
                            //System.IO.File.AppendAllText(logsql, sqlCommand + "\r\n\r\n");
                            var retExecuteSqlCommand = _context.Database.ExecuteSqlCommand(sqlCommand);
                        }

                        if (isCancelOrder)
                        {
                            sohdr.CancelToOrder = nLastOrderNo;
                            sohdr.OrderStatus = "V";
                        }


                        ret.Data.branchNo = requestOrder.branchNo;
                        ret.Data.shoppingCard = requestOrder.shoppingCard;
                        ret.Data.orderNo = nLastOrderNo;

                        if (preOrder != null)
                        {
                            if (chkOrderType.Data == OrderType.PreOrder)//Current order type
                            {
                                preOrder.ReceiveOrderNo = nLastOrderNo;
                                preOrder.PackedDt = DateTime.Now;
                                preOrder.OrderStatus = OrderType.Receive;
                                preOrder.OrderDate = dOrderDate;
                            }
                            else if (chkOrderType.Data == OrderType.Receive)//Current order type
                            {
                                preOrder.ReceiveOrderNo = 0;
                                preOrder.PackedDt = null;
                                preOrder.OrderStatus = OrderType.PreOrder;
                                preOrder.OrderDate = sohdr.OrderDate;
                            }
                        }

                        _context.SaveChanges();

                        dbContextTransaction.Commit();
                        ret.isCompleted = true;

                    }
                    catch (Exception exTrans)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#DupOrder/dbContextTransaction",
                            MessageDesc = "Error :" + exTrans.Message,
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        });
                        ret.isCompleted = false;

                        dbContextTransaction.Rollback();
                    }
                }

                if (ret.isCompleted == true)
                {
                    //Step 2 select and update pack
                    using (var dbTranPackHanging = _context.Database.BeginTransaction())
                    {
                        try
                        {
                            //-----Change-----PK_PackingNo--------------------
                            PkPackingNo rsOldPkPack = null;
                            lsSqlBatch.Clear();

                            var listOldSub = _context.DfSubsohdr.Where(m => m.BranchNo == requestOrder.branchNo && m.ShoppingCard == requestOrder.shoppingCard
                                && m.OrderNo == requestOrder.orderNo).OrderBy(o => o.SuborderType).Include(p => p.PkPackingNo).Include(se => se.DfSubsohdrExt).ToList();
                            foreach (var iOldSub in listOldSub)
                            {
                                var rsNewSubSohd = _context.DfSubsohdr.Where(m => m.BranchNo == iOldSub.BranchNo && m.ShoppingCard == iOldSub.ShoppingCard && m.OrderNo == nLastOrderNo && m.SuborderType == iOldSub.SuborderType).FirstOrDefault();

                                rsOldPkPack = iOldSub.PkPackingNo.Where(w => w.BranchNo == iOldSub.BranchNo && w.SubSohdrRecNo == iOldSub.RecNo).FirstOrDefault();

                                if (rsOldPkPack != null)
                                {
                                    //Save Old packno
                                    var rsCheckLogOldPack = _context.DfSubsohdrExt.Where(w => w.BranchNo == rsOldPkPack.BranchNo && w.SubSohdrRecNo == rsOldPkPack.SubSohdrRecNo && w.Code == OrderConstants.PACKING_NO).FirstOrDefault();
                                    if (rsCheckLogOldPack == null)
                                    {
                                        sbSqlCommand.Length = 0;
                                        sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_subsohdr_ext] ");
                                        sbSqlCommand.AppendLine("([BranchNo],[SubSohdrRecNo],[Code] ,[Value]) ");
                                        sbSqlCommand.AppendFormat(" VALUES ('{0}',{1},'{2}','{3}')", rsOldPkPack.BranchNo, rsOldPkPack.SubSohdrRecNo, OrderConstants.PACKING_NO, rsOldPkPack.PackingNo);

                                        lsSqlBatch.Add(sbSqlCommand.ToString());
                                    }

                                    //Save New packno
                                    sbSqlCommand.Length = 0;
                                    sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_subsohdr_ext] ");
                                    sbSqlCommand.AppendLine("([BranchNo],[SubSohdrRecNo],[Code] ,[Value]) ");
                                    sbSqlCommand.AppendFormat(" VALUES ('{0}',{1},'{2}','{3}')", rsNewSubSohd.BranchNo, rsNewSubSohd.RecNo, KP.Common.OrderGateway.OrderConstants.PACKING_NO, rsOldPkPack.PackingNo);

                                    lsSqlBatch.Add(sbSqlCommand.ToString());

                                    //Save old rec no
                                    sbSqlCommand.Length = 0;
                                    sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_subsohdr_ext] ");
                                    sbSqlCommand.AppendLine("([BranchNo],[SubSohdrRecNo],[Code] ,[Value]) ");
                                    sbSqlCommand.AppendFormat(" VALUES ('{0}',{1},'{2}','{3}')", rsNewSubSohd.BranchNo, rsNewSubSohd.RecNo, KP.Common.OrderGateway.OrderConstants.REF_REC_NO, rsOldPkPack.SubSohdrRecNo);

                                    lsSqlBatch.Add(sbSqlCommand.ToString());


                                    if (isCancelOrder)
                                    {
                                        //Move PackingNo to new RecNo
                                        var rsRefRecNo = iOldSub.DfSubsohdrExt.Where(w => w.Code == KP.Common.OrderGateway.OrderConstants.REF_REC_NO).FirstOrDefault();
                                        if (rsRefRecNo != null)
                                        {
                                            var rsBackupPack = iOldSub.DfSubsohdrExt.Where(w => w.Code == KP.Common.OrderGateway.OrderConstants.PACKING_NO).FirstOrDefault();
                                            if (rsBackupPack != null)
                                            {
                                                //rollback packing to old order type
                                                sbSqlCommand.Length = 0;
                                                sbSqlCommand.AppendFormat("UPDATE [dbo].[PK_PackingNo] SET [BranchNo] = '{0}' ,[SubSohdrRecNo] = '{1}' ,[CreateDT] = GETDATE() ", rsRefRecNo.BranchNo, rsRefRecNo.Value);
                                                sbSqlCommand.AppendFormat(" WHERE [PackingNo] = '{0}' ", rsBackupPack.Value);

                                                lsSqlBatch.Add(sbSqlCommand.ToString());



                                                //Clear PackingNo
                                                sbSqlCommand.Length = 0;
                                                sbSqlCommand.AppendLine("DELETE FROM [dbo].[df_subsohdr_ext] ");
                                                sbSqlCommand.AppendFormat(" WHERE [BranchNo] = '{0}' AND [SubSohdrRecNo] = '{1}' AND [Code] = '{2}'", rsRefRecNo.BranchNo, rsRefRecNo.Value, OrderConstants.PACKING_NO);

                                                lsSqlBatch.Add(sbSqlCommand.ToString());
                                            }
                                        }

                                        //Gen new pack
                                        string _PrefixPackNo = "";

                                        var config = _context.ConfigPos.Where(w => w.ConfigCode == Common.OrderGateway.OrderConstants.CONFIG_PREFIX_PACK).FirstOrDefault();
                                        if (config != null)
                                        {
                                            _PrefixPackNo = StringBL.Strim(config.ConfigData);
                                        }

                                        string sNewPackNo = KP.Common.Pack.PackBL.generatePackingNo(_PrefixPackNo, rsNewSubSohd.RecNo).Data;

                                        var rsNewPack = _context.PkPackingNo.Where(w => w.BranchNo == rsNewSubSohd.BranchNo && w.SubSohdrRecNo == rsNewSubSohd.RecNo).FirstOrDefault();
                                        if (rsNewPack != null)
                                        {
                                            //Update old pack
                                            rsNewPack.PackingNo = sNewPackNo;
                                        }
                                        else
                                        {
                                            //Order type S,R
                                            sbSqlCommand.Length = 0;
                                            sbSqlCommand.AppendLine("INSERT INTO [dbo].[PK_PackingNo]([PackingNo],[BranchNo],[SubSohdrRecNo]) VALUES ");
                                            sbSqlCommand.AppendFormat(" ('{0}','{1}',{2}) ", sNewPackNo, rsNewSubSohd.BranchNo, rsNewSubSohd.RecNo);

                                            lsSqlBatch.Add(sbSqlCommand.ToString());
                                        }
                                    }
                                    else
                                    {
                                        sbSqlCommand.Length = 0;
                                        sbSqlCommand.AppendFormat("UPDATE [dbo].[PK_PackingNo] SET [BranchNo] = '{0}' ,[SubSohdrRecNo] = '{1}' ,[CreateDT] = GETDATE() ", rsNewSubSohd.BranchNo, rsNewSubSohd.RecNo);
                                        sbSqlCommand.AppendFormat(" WHERE [PackingNo] = '{0}' ", rsOldPkPack.PackingNo);

                                        lsSqlBatch.Add(sbSqlCommand.ToString());
                                    }

                                }

                                string sCodeNotNeed = string.Concat(OrderConstants.PACKING_NO, "-", OrderConstants.REF_ORDER_NO, "-", OrderConstants.REF_REC_NO);

                                //-------------df_subsohdr_ext-------------
                                foreach (var iSubExt in iOldSub.DfSubsohdrExt.Where(w => !sCodeNotNeed.Contains(w.Code)))
                                {
                                    sbSqlCommand.Length = 0;
                                    sbSqlCommand.AppendLine("INSERT INTO [dbo].[df_subsohdr_ext] ");
                                    sbSqlCommand.AppendLine("([BranchNo],[SubSohdrRecNo],[Code] ,[Value]) ");
                                    sbSqlCommand.AppendFormat(" VALUES ('{0}',{1},'{2}','{3}')", rsNewSubSohd.BranchNo, rsNewSubSohd.RecNo, iSubExt.Code, iSubExt.Value);

                                    lsSqlBatch.Add(sbSqlCommand.ToString());
                                }
                            }

                            //*************************Save Sale Online//*************************
                            reqChk = new OrderTypeModel
                            {
                                actType = actType.SALE,
                                branchNo = requestOrder.branchNo,
                                orderNo = nLastOrderNo,
                                shoppingCard = requestOrder.shoppingCard
                            };

                            chkOrderType = await GetOrderType(reqChk);

                            //*************************Save Sale Online//*************************
                            string sNewOrderType = OrderType.Normal;
                            if (chkOrderType.Data == OrderType.PreOrder)
                                sNewOrderType = OrderType.Receive;
                            else if (chkOrderType.Data == OrderType.DutyPaidDelivery)
                                sNewOrderType = OrderType.Shipping;
                            else if (chkOrderType.Data == OrderType.Receive)
                                sNewOrderType = OrderType.ReceivePreOrder;
                            else if (chkOrderType.Data == OrderType.Shipping)
                                sNewOrderType = OrderType.ShippingDutyPaidDelivery;

                            if (sNewOrderType.Length > 1) sNewOrderType = sNewOrderType.Substring(0, 1);

                            // using (var locDb = new KPIMNPOSMAContext(""))
                            {
                                sbSqlQuery.Length = 0;
                                sbSqlQuery.AppendFormat("SELECT t1.order_date AS SaleDate, RTRIM(m1.loc_code) AS LocCode, RTRIM(m1.machine_no) AS MachineNo, RTRIM(v1.CateCode) AS CateCode, SUM(t2.quantity * {0}) AS Qty, SUM(t2.amount * {0}) AS Amount, SUM(t2.discount * {0}) AS Discount,'{1}' AS BranchNo ", 1, requestOrder.branchNo);
                                sbSqlQuery.AppendLine("FROM df_sohist AS t2 INNER JOIN ");
                                sbSqlQuery.AppendLine("     vArticleMC AS v1 ON t2.mat_code = v1.ArticleCode INNER JOIN ");
                                sbSqlQuery.AppendLine("     df_subsohdr AS t1 ON t1.branch_no = t2.branch_no AND t1.shopping_card = t2.shopping_card AND t1.order_no = t2.order_no AND t2.suborder_type = t1.suborder_type INNER JOIN ");
                                sbSqlQuery.AppendLine("     df_machine AS m1 ON t1.branch_no = m1.branch_no AND t1.cashier_mac = m1.machine_no ");
                                sbSqlQuery.AppendFormat("WHERE t2.branch_no = '{0}' ", requestOrder.branchNo);
                                sbSqlQuery.AppendFormat("AND t2.shopping_card = '{0}' ", requestOrder.shoppingCard);
                                sbSqlQuery.AppendFormat("AND t2.order_no = {0} ", nLastOrderNo);
                                sbSqlQuery.AppendLine("AND t2.[line_cancel]  =0 ");
                                sbSqlQuery.AppendLine("GROUP BY t1.order_date, m1.loc_code, m1.machine_no, v1.CateCode ");

                                var listSumCate = _locDBContext.SolByMacCate.FromSql<SolByMacCate>(sbSqlQuery.ToString()).ToList();
                                foreach (var item in listSumCate)
                                {
                                    var rsCheckSumCate = _context.SolByMacCate.Where(w => w.SaleDate == item.SaleDate && w.LocCode == item.LocCode && w.MachineNo == item.MachineNo && w.CateCode == item.CateCode).FirstOrDefault();
                                    if (rsCheckSumCate != null)
                                    {
                                        rsCheckSumCate.Qty += item.Qty;
                                        rsCheckSumCate.Amount += item.Amount;
                                        rsCheckSumCate.Discount += item.Discount;
                                    }
                                    else
                                    {
                                        SolByMacCate newSolByMacCate = new SolByMacCate()
                                        {
                                            SaleDate = item.SaleDate,
                                            LocCode = item.LocCode,
                                            MachineNo = item.MachineNo,
                                            CateCode = item.CateCode,
                                            Qty = item.Qty.Value,
                                            Amount = item.Amount.Value,
                                            Discount = item.Discount.Value,
                                            BranchNo = requestOrder.branchNo
                                        };
                                        _context.SolByMacCate.Add(newSolByMacCate);
                                    }


                                    var rsSolByType = _context.SolByType.Where(w => w.SaleDate == item.SaleDate && w.LocCode == item.LocCode && w.MachineNo == item.MachineNo && w.Key1 == item.CateCode && w.Key2 == sNewOrderType).FirstOrDefault();
                                    if (rsSolByType != null)
                                    {
                                        rsSolByType.Qty += item.Qty.Value;
                                        rsSolByType.Amount += item.Amount.Value;
                                        rsSolByType.Discount += item.Discount.Value;
                                    }
                                    else
                                    {
                                        SolByType newSolByType = new SolByType()
                                        {
                                            TypeCode = "C",
                                            SaleDate = item.SaleDate,
                                            LocCode = item.LocCode,
                                            MachineNo = item.MachineNo,
                                            Key1 = item.CateCode,
                                            Key2 = sNewOrderType,
                                            Key3 = "",
                                            Key4 = "",
                                            Qty = item.Qty.Value,
                                            Amount = item.Amount.Value,
                                            Discount = item.Discount.Value,
                                            BranchNo = requestOrder.branchNo
                                        };
                                        _context.SolByType.Add(newSolByType);
                                    }
                                }
                            }
                            //************SOL*************


                            ////+++++++++On cancel+ Hanging+++++++
                            if (isCancelOrder == true)
                            {
                                foreach (var iSub in listOldSub)
                                {
                                    if (StringBL.Strim(iSub.SuborderType) != "T")
                                    {
                                        if (chkOrderType.Data == OrderType.Receive)
                                        {
                                            if (isNewHanging2020 == true)
                                            {
                                                //New cancel hanging 2021-01-13
                                                ParameterHanging parameterHanging = new ParameterHanging()
                                                {
                                                    branchNo = iSub.BranchNo,
                                                    shoppingCard = iSub.ShoppingCard,
                                                    orderNo = iSub.OrderNo,
                                                    subOrderType = iSub.SuborderType,
                                                    userInfo = new UserInfo() { userID = requestOrder.changeBy, clientIP = requestOrder.posIpAddress }
                                                };

                                                try
                                                {
                                                    var rsHanging = await cancelHanging(parameterHanging);
                                                    if (rsHanging.Message.Count() > 0)
                                                    {
                                                        ret.Message.AddRange(rsHanging.Message);
                                                    }
                                                }
                                                catch (Exception exRestClient)
                                                {
                                                    ret.Message.Add(new ResultMessage()
                                                    {
                                                        MessageCode = "ERR_#DupOrder/NewCancelHanging2020",
                                                        MessageDesc = exRestClient.Message,
                                                        MessageType = MessageTypes.MESSAGE_ERROR,
                                                    });
                                                }
                                                //----New cancel hanging 2021-01-13
                                            }
                                        }

                                    }
                                }
                            }




                            //*2021-01-14 Save before reserve hanging
                            foreach (var sqlCommand in lsSqlBatch)
                            {
                                var retExecuteSqlCommand = _context.Database.ExecuteSqlCommand(sqlCommand);
                            }
                            if (lsSqlBatch.Count > 0)
                                dbTranPackHanging.Commit();

                            _context.SaveChanges();
                            //-------2021-01-14 Save before reserve hanging



                            //---------------Hanging------------------- 

                            foreach (var iSub in listOldSub)
                            {
                                if (StringBL.Strim(iSub.SuborderType) != "T")
                                {
                                    if (isCancelOrder == false && chkOrderType.Data == OrderType.Receive)
                                    {
                                        //New reserve hanging 2021-01-13
                                        if (isNewHanging2020 == true)
                                        {
                                            ParameterHanging parameterHanging = new ParameterHanging()
                                            {
                                                branchNo = iSub.BranchNo,
                                                shoppingCard = iSub.ShoppingCard,
                                                orderNo = nLastOrderNo,
                                                subOrderType = iSub.SuborderType,
                                                userInfo = new UserInfo() { userID = requestOrder.changeBy, clientIP = requestOrder.posIpAddress }

                                            };

                                            try
                                            {
                                                var rsHanging = await reserveHanging(parameterHanging);
                                                if (rsHanging.Message.Count() > 0)
                                                {
                                                    ret.Message.AddRange(rsHanging.Message);
                                                }
                                            }
                                            catch (Exception exRestClient)
                                            {
                                                ret.Message.Add(new ResultMessage()
                                                {
                                                    MessageCode = "ERR_#DupOrder/NewReserveHanging2020",
                                                    MessageDesc = exRestClient.Message,
                                                    MessageType = MessageTypes.MESSAGE_ERROR,
                                                });
                                            }
                                            //----New reserve hanging 2021-01-13
                                        }
                                        else
                                        {
                                            //2021-01-13 Old hanging
                                            OrderHangingModel hangingModel = new OrderHangingModel()
                                            {
                                                BranchNo = iSub.BranchNo,
                                                ShoppingCard = iSub.ShoppingCard,
                                                OrderNo = nLastOrderNo,
                                                SubOrderType = iSub.SuborderType,
                                                UserCode = requestOrder.changeBy
                                            };

                                            try
                                            {
                                                var client = new RestClient(sHangingUrl);// ("http://localhost:60939/api/Hanging/ReserveHangingPos");
                                                client.Timeout = -1;
                                                var restRequest = new RestRequest(Method.POST);

                                                restRequest.AddHeader("Content-Type", "application/json");
                                                restRequest.AddHeader("Authorization", sAuthorization);
                                                restRequest.AddHeader("CallerID", sCallerID);

                                                string jsonPostData = JsonConvert.SerializeObject(hangingModel);

                                                restRequest.AddParameter("application/json", jsonPostData, ParameterType.RequestBody);
                                                IRestResponse response = client.Execute(restRequest);
                                                //Console.WriteLine(response.Content);
                                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                                {
                                                    ReturnObject<ResultOrderHangingModel> retResult = JsonConvert.DeserializeObject<ReturnObject<ResultOrderHangingModel>>(response.Content);

                                                    if (retResult.IsHasWarningErrorType())
                                                    {
                                                        ret.Message.AddRange(retResult.Message);
                                                    }
                                                }
                                            }
                                            catch (Exception exRestClient)
                                            {
                                                ret.Message.Add(new ResultMessage()
                                                {
                                                    MessageCode = "ERR_#DupOrder/RestClient",
                                                    MessageDesc = exRestClient.Message,
                                                    MessageType = MessageTypes.MESSAGE_ERROR,
                                                });
                                            }
                                            //-----2021-01-13 Old hanging
                                        }


                                    }
                                    else
                                    {
                                        if (isNewHanging2020 == true)
                                        {
                                            var rsSubHd = _context.DfSubsohdr.Where(w => w.BranchNo == iSub.BranchNo && w.RecNo == iSub.RecNo).FirstOrDefault();
                                            if (rsSubHd != null)
                                            {
                                                rsSubHd.NewHangingNo = null;
                                                _context.SaveChanges();
                                            }
                                        }
                                        else
                                        {
                                            //Cancel Order  - Clear Hanging
                                            var rsCancelHg = _context.PkHanging.Where(w => w.BranchNo == iSub.BranchNo && w.SubSohdrRecNo == iSub.RecNo).FirstOrDefault();
                                            if (rsCancelHg != null)
                                            {
                                                rsCancelHg.BranchNo = null;
                                                rsCancelHg.SubSohdrRecNo = null;
                                                rsCancelHg.IsInTransit = false;

                                                _context.SaveChanges();
                                            }
                                        }
                                    }
                                    ret.isCompleted = true;
                                }
                            }

                            //foreach (var sqlCommand in lsSqlBatch)
                            //{
                            //    var retExecuteSqlCommand = _context.Database.ExecuteSqlCommand(sqlCommand);
                            //}
                            //if (lsSqlBatch.Count > 0)
                            //    dbTranPackHanging.Commit();

                            //_context.SaveChanges();


                            //---------------Hanging-------------------
                        }

                        catch (Exception exTranPackHanging)

                        {

                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#DupOrder/exTranPackHanging",
                                MessageDesc = "Error :" + exTranPackHanging.Message,
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            });
                            ret.isCompleted = false;

                            dbTranPackHanging.Rollback();
                        }
                    }
                }
                else
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#DupOrder/DuplicateOrder",
                        MessageDesc = String.Format("Fail to duplication order type '{0}' is not found.", OrderType.PreOrder.ToString()),
                        MessageType = MessageTypes.MESSAGE_WARNING,
                    });
                }

            }
            catch (Exception ex)
            {
                ret.Message.Add(new ResultMessage()
                {
                    MessageCode = "ERR_#DupOrder/Exception",
                    MessageDesc = String.Format(ex.Message, OrderType.PreOrder.ToString()),
                    MessageType = MessageTypes.MESSAGE_WARNING,
                });
            }

            if (ret.IsHasWarningErrorType()) ret.isCompleted = false;
            return ret;

        }




        public Task<ReturnObject<ResultOrderModel>> DuplicateOrder(ReceiveOrderInfoModel request)
        {
            return DuplicateReceiveOrder(request, false);
        }

        public Task<ReturnObject<ResultOrderModel>> CancelOrder(ReceiveOrderInfoModel request)
        {
            return DuplicateReceiveOrder(request, true);
        }
    }
}
