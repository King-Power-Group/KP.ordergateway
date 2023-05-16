using KP.OrderGateway.DBModel.NewKpiEntity;
using System;
using System.Collections.Generic;
using System.Text;
using KP.OrderGateway.IService;
using System.Threading.Tasks;
using KP.Common.Return;
using KP.OrderGateway.ServiceModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using KP.Common.Message;
using static KP.OrderGateway.ServiceModel.OrderManagementModel;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.SqlClient;
using KP.Common.Helper;
using KP.Common.OrderGateway;
using KP.OrderGateway.DBModel.KPVirtualStockEntity;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace KP.OrderGateway.Business
{
    public partial class OrderManagementBL : IOrderManagement
    {
        /// <summary>
        /// Author by oilzaa 09/06/2020
        /// </summary>
        private KPIMNPOSMAContext _context;
        private KPIMNPOSMAContext _locDBContext;
        private DBModel.CustomerDataContext _cusContext;
        private KPVirtualStockContext _vscontext;
        public OrderManagementBL(KPIMNPOSMAContext context, DBModel.CustomerDataContext cusContext, KPVirtualStockContext vsContext, string constring)
        {
            this._context = context;
            this._cusContext = cusContext;
            this._vscontext = vsContext;
            var optionBuilder1 = new DbContextOptionsBuilder<KPIMNPOSMAContext>();
            optionBuilder1.UseSqlServer(constring);
            _locDBContext = new KPIMNPOSMAContext(optionBuilder1.Options);
        }

        public async Task<ReturnObject<string>> GetOrderType(OrderManagementModel.OrderTypeModel request)
        {
            var ret = new ReturnObject<string>();
            try
            {

                var defaultPos = "DOWNTOWN";

                var checkTypePos = _context.ConfigPos.Where(a => a.ConfigCode == "mPosType").Select(q => q.ConfigData).FirstOrDefault();
                if (checkTypePos != null && checkTypePos != "" && checkTypePos.ToUpper() == "AIRPORT")
                {
                    defaultPos = "AIRPORT";
                }


                var getPosType = _context.ConfigPos.Where(a => a.ConfigCode == "").Select(a => a.ConfigData).FirstOrDefault();

                var branch = _context.DfBranch.Where(m => m.BranchNo == request.branchNo).FirstOrDefault();
                if (branch == null)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#CheckOrderType",
                        MessageDesc = String.Format("Branch no. '{0}' is not found.", request.branchNo),
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    }); ;
                    return ret;
                }
                var sohdr = _context.DfSohdr.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderNo == request.orderNo).Include(i => i.DfSohdrExt).FirstOrDefault();
                if (sohdr != null)
                {
                    var sohdrex = sohdr.DfSohdrExt.Where(m => m.BranchNo == request.branchNo
                    && m.ShoppingCard == request.shoppingCard
                    && m.OrderNo == request.orderNo
                    && m.Code == KP.Common.OrderGateway.OrderConstants.ORDER_TYPE).FirstOrDefault();
                    if (sohdrex != null)
                    {
                        ret.Data = sohdrex.Value;
                    }
                    else
                    {
                        ret.Data = OrderType.Normal;
                        if (defaultPos == "AIRPORT")
                        {
                            ret.Data = OrderType.AirportAll;
                        }
                    }
                    ret.totalCount = 1;
                }
                else if (request.orderNo == 0)
                {
                    //var dateNow = _context.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();
                    sohdr = _context.DfSohdr.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderDate == branch.CurrentOrderDate && (m.OrderStatus == "A" || m.OrderStatus == "a")).OrderByDescending(o => o.OrderNo).Include(i => i.DfSohdrExt).FirstOrDefault();
                    if (sohdr == null)
                    {
                        sohdr = null;
                    }
                    //if (sohdr != null && (sohdr.OrderStatus == "E" || sohdr.OrderStatus == "V"))
                    //{
                    //    sohdr = null;
                    //}
                }

                if (sohdr != null)
                {
                    var sohdrex = sohdr.DfSohdrExt.Where(m => m.BranchNo == request.branchNo
                    && m.ShoppingCard == request.shoppingCard
                    && m.OrderNo == sohdr.OrderNo
                    && m.Code == KP.Common.OrderGateway.OrderConstants.ORDER_TYPE).FirstOrDefault();
                    if (sohdrex != null)
                    {
                        ret.Data = sohdrex.Value;
                    }
                    else
                    {
                        var sohist = _context.DfSohist.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderNo == sohdr.OrderNo).ToList();
                        if (sohist.Count > 0)
                        {
                            ret.Data = OrderType.Normal;
                            if (defaultPos == "AIRPORT")
                            {
                                ret.Data = OrderType.AirportAll;
                            }
                        }
                    }
                    ret.totalCount = 1;
                }
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        public async Task<ReturnObject<string>> CheckOrderType(OrderManagementModel.OrderTypeModel request, bool forceChange = false)
        {
            var ret = new ReturnObject<string>();
            try
            {
                var defaultPos = "DOWNTOWN";

                var checkTypePos = _context.ConfigPos.Where(a => a.ConfigCode == "mPosType").Select(q => q.ConfigData).FirstOrDefault();
                if (checkTypePos != null && checkTypePos != "" && checkTypePos.ToUpper() == "AIRPORT")
                {
                    defaultPos = "AIRPORT";
                }


                var branch = _context.DfBranch.Where(m => m.BranchNo == request.branchNo).FirstOrDefault();
                if (branch == null)
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#CheckOrderType",
                        MessageDesc = String.Format("Branch no. '{0}' is not found.", request.branchNo),
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    }); ;
                    return ret;
                }

                ret.Data = request.orderType;
                if (defaultPos == "DOWNTOWN")
                {
                    if (request.orderType != OrderType.Normal && request.orderType != OrderType.DutyPaidDelivery && request.orderType != OrderType.PreOrder)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#CheckOrderType",
                            MessageDesc = String.Format("Order type '{0}' is not found.", request.orderType),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        }); ;
                        return ret;
                    }

                    var allowOrderType = _context.ConfigPos.Where(m => m.ConfigCode == OrderConstants.ALLOW_DELIVERY || m.ConfigCode == OrderConstants.ALLOW_PREORDER).ToList();
                    switch (request.orderType)
                    {
                        case OrderType.DutyPaidDelivery:
                            var notAllowDelivery = allowOrderType.Where(m => m.ConfigCode == OrderConstants.ALLOW_DELIVERY && m.ConfigData == Confirm.NO).FirstOrDefault();
                            if (notAllowDelivery != null)
                            {
                                ret.Message.Add(new ResultMessage()
                                {
                                    MessageCode = "ERR_#CheckOrderType",
                                    MessageDesc = String.Format("Can't allow delivery."),
                                    MessageType = MessageTypes.MESSAGE_ERROR,
                                }); ;
                                return ret;
                            }
                            break;
                        case OrderType.PreOrder:
                            var notAllowPreOrder = allowOrderType.Where(m => m.ConfigCode == OrderConstants.ALLOW_PREORDER && m.ConfigData == Confirm.NO).FirstOrDefault();
                            if (notAllowPreOrder != null)
                            {
                                ret.Message.Add(new ResultMessage()
                                {
                                    MessageCode = "ERR_#CheckOrderType",
                                    MessageDesc = String.Format("Can't allow pre order."),
                                    MessageType = MessageTypes.MESSAGE_ERROR,
                                }); ;
                                return ret;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else //AIRPORT
                {
                    if (request.orderType != OrderType.AirportArrival && request.orderType != OrderType.AirportDeposit && request.orderType != OrderType.AirportAll)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#CheckOrderType",
                            MessageDesc = String.Format("Order type '{0}' is not found.", request.orderType),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        }); ;
                        return ret;
                    }

                    var allowOrderType = _context.ConfigPos.Where(m => m.ConfigCode == OrderConstants.ALLOW_ARRIVAL || m.ConfigCode == OrderConstants.ALLOW_DEPOSIT).ToList();
                    switch (request.orderType)
                    {
                        case OrderType.AirportArrival:
                            var notAllowDelivery = allowOrderType.Where(m => m.ConfigCode == OrderConstants.ALLOW_ARRIVAL && m.ConfigData == Confirm.NO).FirstOrDefault();
                            if (notAllowDelivery != null)
                            {
                                ret.Message.Add(new ResultMessage()
                                {
                                    MessageCode = "ERR_#CheckOrderType",
                                    MessageDesc = String.Format("Can't allow arrival."),
                                    MessageType = MessageTypes.MESSAGE_ERROR,
                                }); ;
                                return ret;
                            }
                            break;
                        case OrderType.AirportDeposit:
                            var notAllowPreOrder = allowOrderType.Where(m => m.ConfigCode == OrderConstants.ALLOW_DEPOSIT && m.ConfigData == Confirm.NO).FirstOrDefault();
                            if (notAllowPreOrder != null)
                            {
                                ret.Message.Add(new ResultMessage()
                                {
                                    MessageCode = "ERR_#CheckOrderType",
                                    MessageDesc = String.Format("Can't allow deposit."),
                                    MessageType = MessageTypes.MESSAGE_ERROR,
                                }); ;
                                return ret;
                            }
                            break;
                        default:
                            break;
                    }
                }

                var dateNow = _context.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();
                //var dateQuery = _context.Database.SqlQuery<DateTime>("SELECT getdate()");
                //DateTime serverDate = dateQuery.AsEnumerable().First();

                DfSohdr sohdr = new DfSohdr();
                List<DfSohdr> sohdr_list = new List<DfSohdr>();

                if (defaultPos == "DOWNTOWN")
                {
                    sohdr_list = _context.DfSohdr.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard
             && m.OrderDate == branch.CurrentOrderDate).Include(i => i.DfSohdrExt).ToList();
                    sohdr = sohdr_list.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard
                   && m.OrderDate == branch.CurrentOrderDate && (m.OrderStatus == "A" || m.OrderStatus == "a")).OrderByDescending(o => o.OrderNo).FirstOrDefault();
                }
                else //airport 
                {
            //        sohdr_list = _context.DfSohdr.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard
            //&& m.OrderDate >= branch.CurrentOrderDate).Include(i => i.DfSohdrExt).ToList();

                    int flightDelay = 0;
                    var getFlightDelay = _context.ConfigPos.Where(a => a.ConfigCode == "flightDelay").Select(a=>a.ConfigData).FirstOrDefault();
                    if (getFlightDelay != null)
                    {
                        flightDelay = Convert.ToInt32(getFlightDelay);
                    }

                    var rawSql = @"select * from df_sohdr where branch_no='" + request.branchNo + "' and shopping_card='" + request.shoppingCard + "' " +
                        " and getdate() <=  DateAdd(hour," + flightDelay + " ,flight_date+flight_time)";

                    sohdr_list = _context.DfSohdr.FromSql(rawSql).ToList();

                    sohdr = sohdr_list.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard
                     && (m.OrderStatus == "A" || m.OrderStatus == "a")).OrderByDescending(o => o.OrderNo).FirstOrDefault();

                }
                if (sohdr == null)
                {
                    if (defaultPos == "DOWNTOWN")
                    {
                        sohdr = sohdr_list.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderDate == branch.CurrentOrderDate).OrderByDescending(o => o.OrderNo).FirstOrDefault();
                    }
                    else
                    {
                        sohdr = sohdr_list.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard).OrderByDescending(o => o.OrderNo).FirstOrDefault();
                    }
                }

                var orderNo = sohdr != null ? sohdr.OrderNo : 0;
                var sohdrex = new DfSohdrExt();

                if (sohdr != null)
                {
                    sohdrex = _context.DfSohdrExt.Where(m => m.BranchNo == request.branchNo
                   && m.ShoppingCard == request.shoppingCard
                   && m.OrderNo == orderNo
                   && m.Code == KP.Common.OrderGateway.OrderConstants.ORDER_TYPE).FirstOrDefault();
                }
                else
                {
                    sohdrex = null;
                }

                var sohist = _context.DfSohist.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderNo == orderNo).ToList();
                var discount = _context.DfDiscount.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderNo == orderNo).ToList();
                var payment = _context.DfPayment.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard && m.OrderNo == orderNo).ToList();

                var orderType = OrderType.Normal;
                if(defaultPos == "AIRPORT")
                {
                    orderType = OrderType.AirportAll;
                }

                var user = KP.Common.Helper.StringBL.StringNullToEmpty(request.user);
                if (user == "")
                {
                    user = "OMADD";
                }

                if (sohdrex != null)
                {
                    orderType = sohdrex.Value;
                }

                if (sohdr != null && (sohdr.OrderStatus == "E" || sohdr.OrderStatus == "V") || payment.Count > 0) //มี Order ที่จบบิล หรือ Refund สำเร็จไปแล้ว
                {
                    if (forceChange)
                    {
                        // Todo add order type.
                        var cust = _context.DfCustomer.Where(m => m.BranchNo == request.branchNo && m.ShoppingCard == request.shoppingCard).FirstOrDefault();
                        var insert_sohdr = new DfSohdr()
                        {
                            BranchNo = sohdr.BranchNo,
                            ShoppingCard = sohdr.ShoppingCard,
                            OrderNo = sohdr.OrderNo + 1,
                            OrderDate = sohdr.OrderDate,
                            TourCode = cust.TourCode,
                            CustTypeCode = cust.CustTypeCode,
                            CountryCode = cust.CountryCode,
                            AirlineCode = cust.AirlineCode,
                            FlightCode = cust.FlightCode,
                            FlightDate = cust.FlightDate,
                            FlightTime = cust.FlightTime,
                            OrderStatus = "A",
                            AddDatetime = dateNow.DbDt,
                            UpdateDatetime = dateNow.DbDt,
                            UserAdd = user,
                            UserUpdate = user,
                            CashierMac = "",
                            CashierCode = "",
                            CancelToOrder = 0,
                            HotelCode = StringBL.StringNullToEmpty(cust.HotelCode),
                            HotelSource = StringBL.StringNullToEmpty(cust.HotelSource),
                            MachineTax = "",
                            RefDoc = "",
                            CardTypeCode = "",
                            EmBossId = "",
                            CardTypeId = "",
                            ShopRef = sohdr.ShopRef,
                            LvheaderKey = 0,
                            AlipaySession = 0
                        };
                        _context.DfSohdr.Add(insert_sohdr);
                        var tmpSohdrex = new DfSohdrExt()
                        {
                            BranchNo = request.branchNo,
                            ShoppingCard = request.shoppingCard,
                            OrderNo = sohdr.OrderNo + 1,
                            Code = KP.Common.OrderGateway.OrderConstants.ORDER_TYPE,
                            Value = request.orderType
                        };
                        _context.DfSohdrExt.Add(tmpSohdrex);

                        _context.SaveChanges();
                        // -----------------------   
                    }
                    else
                    {
                        ret.Data = request.orderType;
                    }
                    ret.isCompleted = true;
                    ret.totalCount = 1;
                }
                else if (sohdr != null && (sohdr.OrderStatus != "E" && sohdr.OrderStatus != "V" && sohdr.OrderStatus != "v"))
                {
                    if (forceChange)
                    {
                        // Todo change order type.
                        var tmpSohdrex = new DfSohdrExt()
                        {
                            BranchNo = request.branchNo,
                            ShoppingCard = request.shoppingCard,
                            OrderNo = sohdr.OrderNo,
                            Code = KP.Common.OrderGateway.OrderConstants.ORDER_TYPE,
                            Value = request.orderType
                        };
                        if (request.orderType != orderType)
                        {
                            if (discount.Count > 0)
                            {
                                _context.DfDiscount.RemoveRange(discount);
                            }
                            if (sohist.Count > 0)
                            {
                                _context.DfSohist.RemoveRange(sohist);

                                //----------- คืนสินค้า Virtual Stock---
                                var configPos = _context.ConfigPos.ToList();
                                var virtualStock = KP.Common.VirtualStock.VirtualStockConstants.VIRTUALSTOCK_NO;
                                var vsData = configPos.Where(m => StringBL.Strim(m.ConfigCode).Trim() == KP.Common.VirtualStock.VirtualStockConstants.VIRTUALSTOCK).FirstOrDefault();
                                if (vsData != null)
                                {
                                    virtualStock = StringBL.Strim(vsData.ConfigData).ToUpper();
                                }
                                if (virtualStock == KP.Common.VirtualStock.VirtualStockConstants.VIRTUALSTOCK_YES)
                                {
                                    jsonSessionKey jsonKey = new jsonSessionKey()
                                    {
                                        branchNo = request.branchNo,
                                        shoppingCard = request.shoppingCard,
                                        order = sohdr.OrderNo
                                    };
                                    var transSessionkey = JsonConvert.SerializeObject(jsonKey, Formatting.Indented); //"{shoppingcard: '" + shoppingCard + "',order: '" + orderNo + "',branchNo: '" + branchNo + "'}";
                                    var param = new inputSessionkey()
                                    {
                                        session_key = transSessionkey
                                    };

                                    var urlRSVSAPI = configPos.Where(m => m.ConfigCode == "VirtualStockURL").FirstOrDefault().ConfigData + "VirtualStock/RSVirtualStock";
                                    var callerID = configPos.Where(m => m.ConfigCode == "CallerID").FirstOrDefault().ConfigData;
                                    var authorization = configPos.Where(m => m.ConfigCode == "Bearer").FirstOrDefault().ConfigData;

                                    var requestAPI = WebRequest.Create(urlRSVSAPI) as HttpWebRequest;
                                    requestAPI.KeepAlive = true;
                                    requestAPI.UseDefaultCredentials = true;
                                    requestAPI.PreAuthenticate = true;
                                    requestAPI.Credentials = CredentialCache.DefaultCredentials;
                                    requestAPI.Method = "POST";
                                    requestAPI.ContentType = "application/json";
                                    requestAPI.Headers.Add("Authorization", authorization);
                                    requestAPI.Headers.Add("CallerID", callerID);

                                    Stream reqStream = requestAPI.GetRequestStream();
                                    string postData = JsonConvert.SerializeObject(param);
                                    byte[] postArray = Encoding.UTF8.GetBytes(postData);
                                    reqStream.Write(postArray, 0, postArray.Length);
                                    reqStream.Close();
                                    StreamReader sr = new StreamReader(requestAPI.GetResponse().GetResponseStream());
                                    string jsonResult = sr.ReadToEnd();

                                    // JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                                    // T returnObject = json_serializer.Deserialize<T>(jsonResult);
                                }
                                //-----------------------------------
                            }
                        }
                        if (sohdrex == null)
                        {
                            _context.DfSohdrExt.Add(tmpSohdrex);
                        }
                        else
                        {
                            sohdrex.Value = request.orderType;
                        }

                        _context.SaveChanges();
                        // -----------------------
                        ret.isCompleted = true;
                        ret.totalCount = 1;
                    }
                    else
                    {
                        if (request.orderType == orderType)
                        {
                            ret.totalCount = 1;
                        }
                        else
                        {
                            var msgConfDeleteItems = "";
                            if (sohist.Count > 0)
                            {
                                msgConfDeleteItems = " ,Your items will be empty.";
                            }
                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "WARN_#CheckOrderType",
                                MessageDesc = String.Format("Do you want to change order type to '{0}'?{1}", OrderMasterBL.GetOrderTypeDetail(request.orderType), msgConfDeleteItems),
                                MessageType = MessageTypes.MESSAGE_WARNING,
                            }); ;
                        }
                        ret.isCompleted = true;
                    }
                }
                else
                {
                    ret.Message.Add(new ResultMessage()
                    {
                        MessageCode = "ERR_#CheckOrderType",
                        MessageDesc = "Please register before shopping.",
                        MessageType = MessageTypes.MESSAGE_ERROR,
                    });
                }
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        public async Task<ReturnObject<string>> CanAddItemToOrder(CheckScanItemToOrder request)
        {
            var ret = new ReturnObject<string>();
            try
            {
                var defaultPos = "DOWNTOWN";

                var checkTypePos = _context.ConfigPos.Where(a => a.ConfigCode == "mPosType").Select(q => q.ConfigData).FirstOrDefault();
                if (checkTypePos != null && checkTypePos != "" && checkTypePos.ToUpper() == "AIRPORT")
                {
                    defaultPos = "AIRPORT";
                }

                if (defaultPos == "DOWNTOWN")
                {
                    if (request.orderType != OrderType.Normal && request.orderType != OrderType.DutyPaidDelivery && request.orderType != OrderType.PreOrder)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#CanAddItemToOrder",
                            MessageDesc = String.Format("Order type '{0}' is not found.", request.orderType),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        }); ;
                        return ret;
                    }
                    ret.Data = request.orderType;
                    //var data = _context.vArticleMC.Where(m => m.ArticleCode == request.articleCode).FirstOrDefault();
                    var data = _vscontext.VstArticleDutyPaidRemain.Where(m => m.ArticleCodeDutyPaid == request.articleCode).FirstOrDefault();
                    //if (data != null)
                    //{
                    var isBlueMapWhiteTag = false;
                    //var isNormalOnly = false;
                    if (data != null)
                    {
                        isBlueMapWhiteTag = true;
                    }
                    //if (data.BrandCode == "DNY" || data.BrandCode == "SWR" || data.BrandCode == "MVL")
                    //{
                    //    isNormalOnly = true;
                    //}
                    if (isBlueMapWhiteTag)
                    {
                        if (request.orderType == OrderType.DutyPaidDelivery || request.orderType == OrderType.Normal)
                        {
                            ret.isCompleted = true;
                            ret.totalCount = 1;
                        }
                        else
                        {
                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#CanAddItemToOrder",
                                MessageDesc = String.Format("Can not add article code '{0}' to order type '{1}'.", request.articleCode, OrderMasterBL.GetOrderTypeDetail(request.orderType)),
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            }); ;
                            return ret;
                        }
                    }
                    else
                    {
                        if (request.orderType != OrderType.DutyPaidDelivery)
                        {
                            ret.isCompleted = true;
                            ret.totalCount = 1;
                        }
                        else
                        {
                            ret.Message.Add(new ResultMessage()
                            {
                                MessageCode = "ERR_#CanAddItemToOrder",
                                MessageDesc = String.Format("Can not add article code '{0}' to order type '{1}'.", request.articleCode, OrderMasterBL.GetOrderTypeDetail(request.orderType)),
                                MessageType = MessageTypes.MESSAGE_ERROR,
                            }); ;
                            return ret;
                        }
                    }
                }
                else
                {
                    if (request.orderType != OrderType.AirportDeposit && request.orderType != OrderType.AirportArrival && request.orderType != OrderType.AirportAll)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = "ERR_#CanAddItemToOrder",
                            MessageDesc = String.Format("Order type '{0}' is not found.", request.orderType),
                            MessageType = MessageTypes.MESSAGE_ERROR,
                        }); ;
                        return ret;
                    }

                    ret.Data = request.orderType;
                    ret.isCompleted = true;
                    ret.totalCount = 1;
                }

                //}
                //else
                //{
                //    ret.Message.Add(new ResultMessage()
                //    {
                //        MessageCode = "ERR_#CanAddItemToOrder",
                //        MessageDesc = String.Format("Article code '{0}' in vArticleMC not found.", request.articleCode),
                //        MessageType = MessageTypes.MESSAGE_ERROR,
                //    }); ;
                //    return ret;
                //}
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        public async Task<ReturnObject<List<string>>> TimeVirtualStock(settings param)
        {
            var ret = new ReturnObject<List<string>>();

            try
            {
                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(param.subBranchCode);
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(param.branchNo);
                var constr = "";
                var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" &&
                a.SubBranch == subBranch).FirstOrDefault();

                if (getDb != null)
                {
                    var server = StringBL.StringNullToEmpty(getDb.DbServer);
                    var database = StringBL.StringNullToEmpty(getDb.DbName);
                    var user = StringBL.StringNullToEmpty(getDb.DbUser);
                    var password = StringBL.StringNullToEmpty(getDb.DbPass);
                    constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                            server, database, user, password);
                }
                else
                {
                    ret.SetMessage("Ex-Input", "Master Connection not found!.");
                    return ret;
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);


                var data = _context1.VstTimeStock.Select(a => a.timeCode).ToList();

                if (data.Count() > 0)
                {
                    ret.Data = data;
                    ret.totalCount = ret.Data.Count();
                    ret.isCompleted = true;
                }
                else
                {
                    ret.SetMessage("Ex-Master", "Data not Fount!.");
                }
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Master", ex.Message);
            }

            return ret;
        }
    }
}
