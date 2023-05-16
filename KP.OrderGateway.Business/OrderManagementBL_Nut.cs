using KP.Common.Helper;
using KP.Common.Return;
using KP.OrderGateway.DBModel;
using KP.OrderGateway.DBModel.KPVirtualStockEntity;
using KP.OrderGateway.DBModel.NewKpiEntity;
using KP.OrderGateway.ServiceModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static KP.OrderGateway.ServiceModel.OrderManagementModel;

namespace KP.OrderGateway.Business
{
    public partial class OrderManagementBL
    {
        public async Task<ReturnObject<List<DataModel>>> SearchPreOrder(SearchOrderInfoModel request)
        {
            var ret = new ReturnObject<List<DataModel>>();
            try
            {
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("WR001", "BranchNo is Required!>");
                    return ret;
                }


                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

                var constr = "";
                var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" && a.SubBranch == subBranch).FirstOrDefault();

                if (getDb != null)
                {
                    var server = StringBL.StringNullToEmpty(getDb.DbServer);
                    var database = StringBL.StringNullToEmpty(getDb.DbName);
                    var user = StringBL.StringNullToEmpty(getDb.DbUser);
                    var password = StringBL.StringNullToEmpty(getDb.DbPass);
                    constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                            server, database, user, password);
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new KP.OrderGateway.DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var customerName = KP.Common.Helper.StringBL.StringNullToEmpty(request.customerName);

                var packingNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.packNo);

                var passportNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.passport);

                var sqlQuery = @"select 
                    r.branch_no as branchNo,
                    r.shopping_card as shoppingCard,
                    r.order_no as orderNo,
                    r.order_date as orderDate,
                    Ltrim(Rtrim(p.PackingNo)) as packingNo,
                    Ltrim(Rtrim(c.passport_no)) as passportNo,
                    Ltrim(RTRIM(c.cust_name)) as customerName,
                    Ltrim(rtrim(r.airline_code))+Ltrim(Rtrim(r.flight_code)) as flight,
                    FORMAT(r.flight_date, 'dd/MM/yyyy') + ' ' + LTRIM(RTRIM(r.flight_time)) as flightDateTime,
                    cast(0 as decimal(7,2)) as qty,
                    cast(0 as decimal(7,2)) as total,
                    '' as userUpdate,
                    null as dateTimeUpdate,
                    '' as remark,
                    Convert(bit, 0) as isChanged,
                    '' as shipAddress,
                    '' as orderType,
                    '' as orderStatus,
                    getdate() as updateDatetime,
                     Convert(bit, 0) as isDisPatch,
                    '' as refOrder,
                     Convert(bit, 0) as isPicking,
                    '' as pickingCheck,
                     Convert(bit, 0) as isSaveStock,
                    '' as location,
                    '' as machine,
                    '' as lastStatus,
                     Convert(bit, 0) as isScan,
                     '' as isOutOfStock, 
                     Convert(bigint,0) as runnoSohdrExt,
                     Convert(bit, 0) as isSendSCO,
                     Convert(bit, 0) as isSendSTO
                from 
                    df_sohdr r 
                        inner join df_customer c on r.branch_no = c.branch_no and r.shopping_card = c.shopping_card
                        inner join df_subsohdr s on r.branch_no = s.branch_no and r.shopping_card = s.shopping_card and r.order_no = s.order_no 
                        inner join PK_PackingNo p on s.branch_no = p.BranchNo and s.RecNo = p.SubSohdrRecNo
                        inner join df_sohdr_ext e on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
                        and e.Code='OrderType' and e.Value='P'
                ";

                long monthPreorder = 10;
                var getMonth = _cusContext.CUSD_Config.Where(a => a.ConfigCode == "MonthPreOrder").Select(a => a.ConfigData).FirstOrDefault();
                if (getMonth != null)
                {
                    monthPreorder = Convert.ToInt32(getMonth);
                }
                sqlQuery += " where r.branch_no='" + branchNo + "' and r.order_date>= Convert(date, dateadd(MONTH,-" + monthPreorder + ",GETDATE())) ";

                if (customerName != "")
                {
                    sqlQuery += " and c.cust_name like '%" + customerName + "%' ";
                }
                if (passportNo != "")
                {
                    passportNo = passportNo.ToUpper();
                    sqlQuery += " and c.passport_no ='" + passportNo + "' ";
                }

                if (packingNo != "")
                {
                    packingNo = packingNo.ToUpper();
                    sqlQuery += " and p.PackingNo ='" + packingNo + "' ";
                }

                var listLinq = _context1.Set<OrderModel>().FromSql(sqlQuery).ToList();
                var lstData = listLinq.ToList();

                var lstModel = new List<DataModel>();
                foreach (var detail in lstData)
                {
                    var checkModel = lstModel.Where(q => q.branchNo == detail.branchNo &&
                                        q.shoppingCard == detail.shoppingCard &&
                                        q.orderNo == detail.orderNo).FirstOrDefault();

                    if (checkModel == null)
                    {
                        var sumList = (from h in _context1.DfSohist
                                       join p in _context1.DfSubsohdr on new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType }
                                       equals new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType }
                                       where h.LineCancel == false
                                       && h.BranchNo == detail.branchNo &&
                                       h.ShoppingCard == detail.shoppingCard &&
                                       h.OrderNo == detail.orderNo
                                       select new
                                       {
                                           packNo = p.PkPackingNo.FirstOrDefault().PackingNo,
                                           qty = h.Quantity,
                                           amount = h.Amount,
                                           discount = h.Discount,
                                           net = h.Net
                                       }).ToList();

                        if (packingNo != "")
                        {
                            sumList = sumList.Where(a => a.packNo.Contains(packingNo)).ToList();
                        }

                        detail.qty = sumList.Sum(a => a.qty);
                        detail.total = sumList.Sum(a => a.net);

                        var checkPreOrder = _context1.PreOrderChangeFlight.Where(a =>
                        a.BranchNo == detail.branchNo &&
                        a.ShoppingCard == detail.shoppingCard &&
                        a.OrderNo == detail.orderNo).FirstOrDefault();
                        if (checkPreOrder != null)
                        {
                            detail.flight = checkPreOrder.AirlineCode.Trim() + checkPreOrder.FlightCode.Trim();
                            detail.flightDateTime = checkPreOrder.FlightDt.ToString("yyyy-MM-dd HH:mm");
                            detail.remark = checkPreOrder.Remark.Trim();
                            detail.userUpdate = checkPreOrder.UserUpdate;
                            detail.dateTimeUpdate = checkPreOrder.UpdateDatetime;
                            detail.isChanged = true;
                        }
                    }
                    else
                    {
                        checkModel.packingNo = checkModel.packingNo + "," + detail.packingNo;
                        continue;
                    }

                    DataModel model = new DataModel()
                    {
                        branchNo = detail.branchNo,
                        shoppingCard = detail.shoppingCard,
                        orderNo = detail.orderNo,
                        orderDate = detail.orderDate,
                        packingNo = detail.packingNo.Trim(),
                        passportNo = detail.passportNo.Trim(),
                        customerName = detail.customerName.Trim(),
                        flight = detail.flight.Trim(),
                        flightDateTime = detail.flightDateTime,
                        qty = detail.qty,
                        total = detail.total,
                        lstSohist = new List<listProduct>(),
                        dateTimeUpdate = detail.dateTimeUpdate,
                        userUpdate = detail.userUpdate,
                        remark = detail.remark,
                        isChanged = detail.isChanged
                    };

                    List<listProduct> lstsohist = new List<listProduct>();

                    var lstProduct = (from p in _context1.DfSohist
                                      join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                                      join h in _context1.DfSubsohdr on new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType }
                                      equals new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType }
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
                                      && p.OrderNo == detail.orderNo && p.LineCancel == false
                                      orderby p.LineNo
                                      select new listProduct
                                      {
                                          articleCode = p.ItemCode,
                                          articleName = v.ArticleName,
                                          discount = p.Discount,
                                          discrate = p.DiscRate,
                                          line_No = p.LineNo,
                                          net = p.Net,
                                          price = p.SellingPrice,
                                          amount = p.Amount,
                                          qty = p.Quantity,
                                          claimCheck = h.ClaimcheckNo.Trim(),
                                          taxabbNo = h.TaxabbNo.Trim(),
                                          subOrderType = h.SuborderType.Trim(),
                                          packingNo = h.PkPackingNo.FirstOrDefault() == null ? "" : h.PkPackingNo.FirstOrDefault().PackingNo
                                      }).ToList();

                    if (packingNo != "")
                    {
                        lstProduct = lstProduct.Where(a => a.packingNo.Contains(packingNo)).ToList();
                    }
                    //var queryProduct = String.Format(stringProduct, detail.branchNo, detail.shoppingCard, detail.orderNo);

                    //var lstProduct = new List<listProduct>();
                    //lstProduct =   _context.Set<ServiceModel.listProduct>().FromSql(queryProduct).ToList();

                    foreach (var prd in lstProduct)
                    {
                        listProduct data = new listProduct()
                        {
                            articleCode = prd.articleCode.Trim(),
                            articleName = prd.articleName.Trim(),
                            discount = prd.discount,
                            discrate = prd.discrate,
                            line_No = prd.line_No,
                            net = prd.net,
                            price = prd.price,
                            amount = prd.amount,
                            claimCheck = prd.claimCheck,
                            packingNo = prd.packingNo,
                            subOrderType = prd.subOrderType,
                            taxabbNo = prd.taxabbNo,
                            qty = prd.qty
                        };
                        lstsohist.Add(data);
                    }

                    model.lstSohist = lstsohist;
                    model.lstSummary = new List<summaryBySuborderType>();
                    var summary = lstsohist.GroupBy(q => new { q.subOrderType, q.taxabbNo, q.claimCheck, q.packingNo })
                        .Select(g => new
                        {
                            suborderType = g.Key.subOrderType,
                            packingNo = g.Key.packingNo,
                            taxAbbNo = g.Key.taxabbNo,
                            cliamCheck = g.Key.claimCheck,
                            totalQty = g.Sum(q => q.qty),
                            totalAmount = g.Sum(a => a.amount),
                            totalDiscount = g.Sum(a => a.discount),
                            totalNet = g.Sum(a => a.net)
                        }).ToList();
                    List<summaryBySuborderType> sum = new List<summaryBySuborderType>();
                    foreach (var datsum in summary)
                    {
                        sum.Add(new summaryBySuborderType()
                        {
                            subOrderType = datsum.suborderType,
                            cliamCheck = datsum.cliamCheck,
                            packingNo = datsum.packingNo,
                            taxAbbNo = datsum.taxAbbNo,
                            net = datsum.totalNet,
                            amount = datsum.totalAmount,
                            discount = datsum.totalDiscount,
                            qty = datsum.totalQty
                        });
                    }
                    model.lstSummary = sum;
                    lstModel.Add(model);
                }

                ret.Data = lstModel;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
                return ret;
            }
            return ret;
        }


        public async Task<ReturnObject<List<DataModel>>> SearchPreOrder_bk(SearchOrderInfoModel request)
        {
            var ret = new ReturnObject<List<DataModel>>();

            try
            {
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("WR001", "BranchNo is Required!>");
                    return ret;
                }


                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

                var constr = "";
                var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" && a.SubBranch == subBranch).FirstOrDefault();

                if (getDb != null)
                {
                    var server = StringBL.StringNullToEmpty(getDb.DbServer);
                    var database = StringBL.StringNullToEmpty(getDb.DbName);
                    var user = StringBL.StringNullToEmpty(getDb.DbUser);
                    var password = StringBL.StringNullToEmpty(getDb.DbPass);
                    constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                            server, database, user, password);
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new KP.OrderGateway.DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var customerName = KP.Common.Helper.StringBL.StringNullToEmpty(request.customerName);

                var packingNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.packNo);

                var passportNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.passport);

                var listLinq = (from r in _context1.DfSohdr
                                join c in _context1.DfCustomer on new { r.BranchNo, r.ShoppingCard } equals
                                   new { c.BranchNo, c.ShoppingCard }
                                join s in _context1.DfSubsohdr on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { s.BranchNo, s.ShoppingCard, s.OrderNo }
                                join p in _context1.PkPackingNo on new { s.BranchNo, s.RecNo } equals
                                new { p.BranchNo, RecNo = p.SubSohdrRecNo }
                                join e in _context1.DfSohdrExt.Where(a => a.Code == "OrderType" && a.Value == "P") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { e.BranchNo, e.ShoppingCard, e.OrderNo }
                                where r.BranchNo == branchNo
                                && r.OrderDate.Date >= DateTime.Now.Date.AddMonths(-10)
                                && r.OrderStatus == "E"
                                select new OrderModel
                                {
                                    branchNo = r.BranchNo,
                                    customerName = c.CustName.Trim(),
                                    orderNo = r.OrderNo,
                                    orderDate = r.OrderDate,
                                    packingNo = p.PackingNo.Trim(),
                                    passportNo = c.PassportNo.Trim(),
                                    shoppingCard = r.ShoppingCard,
                                    flight = r.AirlineCode.Trim() + r.FlightCode.Trim(),
                                    flightDateTime = r.FlightDate.Value.Date + " " + r.FlightTime,
                                    remark = "",
                                    isChanged = false
                                });

                if (customerName != "")
                {
                    customerName = customerName.ToUpper();
                    listLinq = listLinq.Where(a => a.customerName.Contains(customerName));
                }

                if (passportNo != "")
                {
                    passportNo = passportNo.ToUpper();
                    listLinq = listLinq.Where(a => a.passportNo == passportNo);
                }

                if (packingNo != "")
                {
                    packingNo = packingNo.ToUpper();
                    listLinq = listLinq.Where(a => a.packingNo == packingNo);
                }

                var lstData = listLinq.ToList();

                var lstModel = new List<DataModel>();
                foreach (var detail in lstData)
                {
                    var checkModel = lstModel.Where(q => q.branchNo == detail.branchNo &&
                                        q.shoppingCard == detail.shoppingCard &&
                                        q.orderNo == detail.orderNo).FirstOrDefault();

                    if (checkModel == null)
                    {
                        var sumList = (from h in _context1.DfSohist
                                       join p in _context1.DfSubsohdr on new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType }
                                       equals new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType }
                                       where h.LineCancel == false
                                       && h.BranchNo == detail.branchNo &&
                                       h.ShoppingCard == detail.shoppingCard &&
                                       h.OrderNo == detail.orderNo
                                       select new
                                       {
                                           packNo = p.PkPackingNo.FirstOrDefault().PackingNo,
                                           qty = h.Quantity,
                                           amount = h.Amount,
                                           discount = h.Discount,
                                           net = h.Net
                                       }).ToList();

                        if (packingNo != "")
                        {
                            sumList = sumList.Where(a => a.packNo.Contains(packingNo)).ToList();
                        }

                        detail.qty = sumList.Sum(a => a.qty);
                        detail.total = sumList.Sum(a => a.net);

                        var checkPreOrder = _context1.PreOrderChangeFlight.Where(a =>
                        a.BranchNo == detail.branchNo &&
                        a.ShoppingCard == detail.shoppingCard &&
                        a.OrderNo == detail.orderNo).FirstOrDefault();
                        if (checkPreOrder != null)
                        {
                            detail.flight = checkPreOrder.AirlineCode.Trim() + checkPreOrder.FlightCode.Trim();
                            detail.flightDateTime = checkPreOrder.FlightDt.ToString("yyyy-MM-dd HH:mm");
                            detail.remark = checkPreOrder.Remark.Trim();
                            detail.userUpdate = checkPreOrder.UserUpdate;
                            detail.dateTimeUpdate = checkPreOrder.UpdateDatetime;
                            detail.isChanged = true;
                        }
                    }
                    else
                    {
                        checkModel.packingNo = checkModel.packingNo + "," + detail.packingNo;
                        continue;
                    }

                    DataModel model = new DataModel()
                    {
                        branchNo = detail.branchNo,
                        shoppingCard = detail.shoppingCard,
                        orderNo = detail.orderNo,
                        orderDate = detail.orderDate,
                        packingNo = detail.packingNo.Trim(),
                        passportNo = detail.passportNo.Trim(),
                        customerName = detail.customerName.Trim(),
                        flight = detail.flight.Trim(),
                        flightDateTime = detail.flightDateTime,
                        qty = detail.qty,
                        total = detail.total,
                        lstSohist = new List<listProduct>(),
                        dateTimeUpdate = detail.dateTimeUpdate,
                        userUpdate = detail.userUpdate,
                        remark = detail.remark,
                        isChanged = detail.isChanged
                    };

                    List<listProduct> lstsohist = new List<listProduct>();

                    var lstProduct = (from p in _context1.DfSohist
                                      join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                                      join h in _context1.DfSubsohdr on new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType }
                                      equals new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType }
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
                                      && p.OrderNo == detail.orderNo && p.LineCancel == false
                                      orderby p.LineNo
                                      select new listProduct
                                      {
                                          articleCode = p.ItemCode,
                                          articleName = v.ArticleName,
                                          discount = p.Discount,
                                          discrate = p.DiscRate,
                                          line_No = p.LineNo,
                                          net = p.Net,
                                          price = p.SellingPrice,
                                          amount = p.Amount,
                                          qty = p.Quantity,
                                          claimCheck = h.ClaimcheckNo.Trim(),
                                          taxabbNo = h.TaxabbNo.Trim(),
                                          subOrderType = h.SuborderType.Trim(),
                                          packingNo = h.PkPackingNo.FirstOrDefault() == null ? "" : h.PkPackingNo.FirstOrDefault().PackingNo
                                      }).ToList();

                    if (packingNo != "")
                    {
                        lstProduct = lstProduct.Where(a => a.packingNo.Contains(packingNo)).ToList();
                    }
                    //var queryProduct = String.Format(stringProduct, detail.branchNo, detail.shoppingCard, detail.orderNo);

                    //var lstProduct = new List<listProduct>();
                    //lstProduct =   _context.Set<ServiceModel.listProduct>().FromSql(queryProduct).ToList();

                    foreach (var prd in lstProduct)
                    {
                        listProduct data = new listProduct()
                        {
                            articleCode = prd.articleCode.Trim(),
                            articleName = prd.articleName.Trim(),
                            discount = prd.discount,
                            discrate = prd.discrate,
                            line_No = prd.line_No,
                            net = prd.net,
                            price = prd.price,
                            amount = prd.amount,
                            claimCheck = prd.claimCheck,
                            packingNo = prd.packingNo,
                            subOrderType = prd.subOrderType,
                            taxabbNo = prd.taxabbNo,
                            qty = prd.qty
                        };
                        lstsohist.Add(data);
                    }

                    model.lstSohist = lstsohist;
                    model.lstSummary = new List<summaryBySuborderType>();
                    var summary = lstsohist.GroupBy(q => new { q.subOrderType, q.taxabbNo, q.claimCheck, q.packingNo })
                        .Select(g => new
                        {
                            suborderType = g.Key.subOrderType,
                            packingNo = g.Key.packingNo,
                            taxAbbNo = g.Key.taxabbNo,
                            cliamCheck = g.Key.claimCheck,
                            totalQty = g.Sum(q => q.qty),
                            totalAmount = g.Sum(a => a.amount),
                            totalDiscount = g.Sum(a => a.discount),
                            totalNet = g.Sum(a => a.net)
                        }).ToList();
                    List<summaryBySuborderType> sum = new List<summaryBySuborderType>();
                    foreach (var datsum in summary)
                    {
                        sum.Add(new summaryBySuborderType()
                        {
                            subOrderType = datsum.suborderType,
                            cliamCheck = datsum.cliamCheck,
                            packingNo = datsum.packingNo,
                            taxAbbNo = datsum.taxAbbNo,
                            net = datsum.totalNet,
                            amount = datsum.totalAmount,
                            discount = datsum.totalDiscount,
                            qty = datsum.totalQty
                        });
                    }
                    model.lstSummary = sum;
                    lstModel.Add(model);
                }

                ret.Data = lstModel;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
                return ret;
            }
            return ret;
        }

        //public async Task<ReturnObject<List<DataModel>>> SearchShippingWeb(SearchOrderInfoModel request)
        //{
        //    var ret = new ReturnObject<List<DataModel>>();

        //    try
        //    {
        //        var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
        //        if (branchNo == "")
        //        {
        //            ret.SetMessage("WR001", "BranchNo is Required!>");
        //            return ret;
        //        }

        //        var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

        //        var constr = "";
        //        var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" &&
        //        a.SubBranch == subBranch).FirstOrDefault();

        //        if (getDb != null)
        //        {
        //            var server = StringBL.StringNullToEmpty(getDb.DbServer);
        //            var database = StringBL.StringNullToEmpty(getDb.DbName);
        //            var user = StringBL.StringNullToEmpty(getDb.DbUser);
        //            var password = StringBL.StringNullToEmpty(getDb.DbPass);
        //            constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
        //                                    server, database, user, password);
        //        }

        //        var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
        //        optionBuilder.UseSqlServer(constr);
        //        var _context1 = new KP.OrderGateway.DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

        //        var customerName = KP.Common.Helper.StringBL.StringNullToEmpty(request.customerName);

        //        var packingNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.packNo);

        //        var passportNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.passport);

        //        var shoppingCard = KP.Common.Helper.StringBL.StringNullToEmpty(request.shoppingCard);

        //        var lastStatus = StringBL.StringNullToEmpty(request.lastStatus);

        //        var orderStatus = StringBL.StringNullToEmpty(request.orderStatus);

        //        var machine = StringBL.StringNullToEmpty(request.machine);

        //        //var orderType = KP.Common.Helper.StringBL.StringNullToEmpty(request.orderType);



        //        var sqlQuery = @"select 
        //                         r.branch_no as branchNo,
        //                         r.order_status as orderStatus,
        //                         LTRIM(RTRIM(c.cust_name)) as customerName,
        //                         r.order_no as OrderNo,
        //                         r.order_date as orderDate,
        //                         c.passport_no as passportNo,
        //                         r.shopping_card as shoppingCard,
        //                         LTRIM(RTRIM(r.airline_code)) + LTRIM(RTRIM(r.flight_code)) as flight,
        //                         '' as remark,
        //                         r.cashier_mac as machine,
        //                         Convert(bigint,0) as runnoSohdrExt,
        //                         FORMAT(r.flight_date, 'dd/MM/yyyy') + ' ' + LTRIM(RTRIM(r.flight_time)) as flightDateTime,
        //                        case 
        //                         when e.Value is null or e.Value = '' then ''
        //                         else e.Value
        //                            end as orderType,
        //                        case
        //                         when q.Value is null or q.Value = '' then ''
        //                         else q.Value
        //                            end as shipAddress,
        //                        case 
        //                         when z.Value is null or z.Value = '' then ''
        //                         else z.Value
        //                            end as refOrder,
        //                        case
        //                         when w.Value is null or w.Value = '' then ''
        //                         else w.Value
        //                            end as lastStatus,
        //                        null as dateTimeUpdate,
        //                        Convert(bit,0) as isChanged,
        //                        Convert(bit,0) as isDisPatch,
        //                        Convert(bit,0) as isPicking,
        //                        Convert(bit,0) as isSaveStock,
        //                        Convert(bit,0) as isScan,
        //                        '' as isOutOfStock,
        //                        '' as location,
        //                        isnull(p.PackingNo,'') as packingNo,
        //                        '' as pickingCheck,
        //                        cast(0 as decimal(7,2)) as qty,
        //                        cast(0 as decimal(7,2)) as total,
        //                        '' as userUpdate,
        //                        getdate() as updateDatetime
        //                        from df_sohdr r
        //                        inner
        //                        join df_customer c on r.branch_no = c.branch_no and r.shopping_card = c.shopping_card
        //                        left join df_subsohdr s on r.branch_no = s.branch_no and r.shopping_card = s.shopping_card and r.order_no = s.order_no
        //                        left join PK_PackingNo p on s.RecNo = p.SubSohdrRecNo and s.branch_no = p.BranchNo
        //                        left join df_sohdr_ext e on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
        //                        and e.Code = 'OrderType'
        //                        left join df_sohdr_ext q on r.branch_no = q.branch_no and r.shopping_card = q.shopping_card and r.order_no = q.order_no
        //                        and q.Code = 'ShipAddress'
        //                        left join df_sohdr_ext z on r.branch_no = z.branch_no and r.shopping_card = z.shopping_card and r.order_no = z.order_no
        //                        and(z.Code = 'ReceiveOrderNo' or z.Code = 'RefOrderNo')
        //                        left join df_sohdr_ext w on r.branch_no = w.branch_no and r.shopping_card = w.shopping_card and r.order_no = w.order_no
        //                        and w.Code = 'LastStatus'";


        //        sqlQuery += " where r.branch_no='" + branchNo + "' and (r.order_date>='" + request.startDate.Date + "' and r.order_date<='" + request.endDate.Date + "')";

        //        //var qqq = listLinq.ToList();
        //        if (customerName != "")
        //        {
        //            customerName = customerName.ToUpper();
        //            sqlQuery += " and c.cust_name like '%" + customerName + "%' ";
        //        }

        //        if (passportNo != "")
        //        {
        //            passportNo = passportNo.ToUpper();
        //            sqlQuery += " and c.passport_no ='" + passportNo + "' ";
        //        }

        //        if (packingNo != "")
        //        {
        //            packingNo = packingNo.ToUpper();
        //            sqlQuery += " and p.PackingNo='" + packingNo + "' ";
        //        }

        //        if (orderStatus != "")
        //        {
        //            sqlQuery += " and r.order_status='" + orderStatus + "' ";
        //        }

        //        if (shoppingCard != "")
        //        {
        //            sqlQuery += " and r.shopping_card='" + shoppingCard + "' ";
        //        }

        //        if (request.orderNo > 0)
        //        {
        //            sqlQuery += " and r.order_no=" + request.orderNo + " ";
        //        }

        //        if (request.orderDate != null)
        //        {
        //            //listLinq = listLinq.Where(a => a.orderDate.Date == request.orderDate.Value.Date);
        //            sqlQuery += " and r.order_date='" + request.orderDate.Value.Date + "' ";
        //        }

        //        if (lastStatus != "")
        //        {
        //            sqlQuery += " and w.value='" + lastStatus + "' ";
        //        }

        //        //if (machine != "")
        //        //{
        //        //    sqlQuery += " and r.cashier_mac ='" + machine + "' ";
        //        //}


        //        //var dataTest = _context1.Database.SqlQuery<OrderModel>(sqlQuery);// < OrderModel > sqlQuery(sqlQuery);
        //        var dataTest = _context1.Set<OrderModel>().FromSql(sqlQuery).ToList();

        //        if (request.orderType != null && request.orderType.Count() > 0)
        //        {
        //            dataTest = dataTest.Where(a => request.orderType.Contains(a.orderType)).ToList();
        //        }

        //        if (machine != "")
        //        {
        //            var splitMachine = machine.Split(',');
        //            if (splitMachine.Count() > 1)
        //            {
        //                dataTest = dataTest.Where(a => splitMachine.Contains(a.machine)).ToList();
        //            }
        //            else
        //            {
        //                dataTest = dataTest.Where(a => a.machine == machine).ToList();
        //            }
        //        }


        //        var lstData = dataTest.ToList();

        //        var lstModel = new List<DataModel>();
        //        foreach (var detail in lstData)
        //        {
        //            var checkModel = lstModel.Where(q => q.branchNo == detail.branchNo &&
        //                                q.shoppingCard == detail.shoppingCard &&
        //                                q.orderNo == detail.orderNo).FirstOrDefault();

        //            if (checkModel == null)
        //            {
        //                var sumList = (from h in _context1.DfSohist
        //                               join p in _context1.DfSubsohdr on new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType }
        //                               equals new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType } into ps
        //                               from sps in ps.DefaultIfEmpty()
        //                               where h.LineCancel == false
        //                               && h.BranchNo == detail.branchNo &&
        //                               h.ShoppingCard == detail.shoppingCard &&
        //                               h.OrderNo == detail.orderNo
        //                               select new
        //                               {
        //                                   packNo = sps.PkPackingNo.FirstOrDefault() == null ? "" : sps.PkPackingNo.FirstOrDefault().PackingNo.Trim(),  //p.PkPackingNo.FirstOrDefault().PackingNo,
        //                                   qty = h.Quantity,
        //                                   amount = h.Amount,
        //                                   discount = h.Discount,
        //                                   net = h.Net
        //                               }).ToList();

        //                if (packingNo != "")
        //                {
        //                    sumList = sumList.Where(a => a.packNo.Contains(packingNo)).ToList();
        //                }

        //                detail.qty = sumList.Sum(a => a.qty);
        //                detail.total = sumList.Sum(a => a.net);

        //                var checkPreOrder = _context1.PreOrderChangeFlight.Where(a =>
        //                a.BranchNo == detail.branchNo &&
        //                a.ShoppingCard == detail.shoppingCard &&
        //                a.OrderNo == detail.orderNo).FirstOrDefault();
        //                if (checkPreOrder != null)
        //                {
        //                    detail.flight = StringBL.StringNullToEmpty(checkPreOrder.AirlineCode) +
        //                        StringBL.StringNullToEmpty(checkPreOrder.FlightCode);
        //                    detail.flightDateTime = checkPreOrder.FlightDt.ToString("yyyy-MM-dd HH:mm");
        //                    detail.remark = StringBL.StringNullToEmpty(checkPreOrder.Remark);
        //                    detail.userUpdate = checkPreOrder.UserUpdate;
        //                    detail.dateTimeUpdate = checkPreOrder.UpdateDatetime;
        //                    detail.isChanged = true;
        //                }
        //            }
        //            else
        //            {
        //                if (detail.packingNo != "")
        //                {
        //                    checkModel.packingNo = checkModel.packingNo + "," + detail.packingNo;
        //                }
        //                continue;
        //            }

        //            bool isDispatch = false;
        //            var dataPacking = detail.packingNo.Trim();
        //            if (dataPacking.Length > 0)
        //            {
        //                var chkDispatch = _context1.DispatchTransPack.Where(a => a.ShopCard == detail.shoppingCard && a.order_no == detail.orderNo).FirstOrDefault();
        //                if (chkDispatch != null)
        //                {
        //                    isDispatch = true;
        //                }
        //            }

        //            DataModel model = new DataModel()
        //            {
        //                branchNo = detail.branchNo,
        //                shoppingCard = detail.shoppingCard,
        //                orderNo = detail.orderNo,
        //                orderDate = detail.orderDate,
        //                packingNo = detail.packingNo.Trim(),
        //                passportNo = detail.passportNo.Trim(),
        //                customerName = detail.customerName.Trim(),
        //                flight = detail.flight.Trim(),
        //                flightDateTime = detail.flightDateTime,
        //                qty = detail.qty,
        //                total = detail.total,
        //                lstSohist = new List<listProduct>(),
        //                dateTimeUpdate = detail.dateTimeUpdate,
        //                userUpdate = detail.userUpdate,
        //                remark = detail.remark,
        //                isChanged = detail.isChanged,
        //                shipAddress = detail.shipAddress,
        //                orderType = detail.orderType,
        //                orderStatus = detail.orderStatus,
        //                isDisPatch = isDispatch,
        //                refOrder = detail.refOrder,
        //                lastStatus = detail.lastStatus,
        //                machine = detail.machine,
        //                runnoSohdrExt = detail.runnoSohdrExt
        //            };

        //            List<listProduct> lstsohist = new List<listProduct>();

        //            var lstProduct = (from p in _context1.DfSohist
        //                              join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
        //                              join h in _context1.DfSubsohdr on new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType }
        //                              equals new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType } into ps
        //                              from sps in ps.DefaultIfEmpty()
        //                              where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
        //                              && p.OrderNo == detail.orderNo && p.LineCancel == false
        //                              orderby p.LineNo
        //                              select new listProduct
        //                              {
        //                                  articleCode = p.ItemCode,
        //                                  articleName = v.ArticleName,
        //                                  discount = p.Discount,
        //                                  discrate = p.DiscRate,
        //                                  line_No = p.LineNo,
        //                                  net = p.Net,
        //                                  price = p.SellingPrice,
        //                                  amount = p.Amount,
        //                                  qty = p.Quantity,
        //                                  claimCheck = sps.ClaimcheckNo == null || sps.ClaimcheckNo == "" ? "" : sps.ClaimcheckNo.Trim(), //h.ClaimcheckNo.Trim(),
        //                                  taxabbNo = sps.TaxabbNo == null || sps.TaxabbNo == "" ? "" : sps.TaxabbNo.Trim(), //h.TaxabbNo.Trim(),
        //                                  subOrderType = sps.SuborderType == null || sps.SuborderType == "" ? "" : sps.SuborderType.Trim(),// h.SuborderType.Trim(),
        //                                  packingNo = sps.PkPackingNo.FirstOrDefault() == null ? "" : sps.PkPackingNo.FirstOrDefault().PackingNo
        //                              }).ToList();

        //            if (packingNo != "")
        //            {
        //                lstProduct = lstProduct.Where(a => a.packingNo.Contains(packingNo)).ToList();
        //            }
        //            //var queryProduct = String.Format(stringProduct, detail.branchNo, detail.shoppingCard, detail.orderNo);

        //            //var lstProduct = new List<listProduct>();
        //            //lstProduct =   _context.Set<ServiceModel.listProduct>().FromSql(queryProduct).ToList();

        //            foreach (var prd in lstProduct)
        //            {
        //                listProduct data = new listProduct()
        //                {
        //                    articleCode = prd.articleCode.Trim(),
        //                    articleName = prd.articleName.Trim(),
        //                    discount = prd.discount,
        //                    discrate = prd.discrate,
        //                    line_No = prd.line_No,
        //                    net = prd.net,
        //                    price = prd.price,
        //                    amount = prd.amount,
        //                    claimCheck = prd.claimCheck,
        //                    packingNo = prd.packingNo,
        //                    subOrderType = prd.subOrderType,
        //                    taxabbNo = prd.taxabbNo,
        //                    qty = prd.qty
        //                };
        //                lstsohist.Add(data);
        //            }

        //            model.lstSohist = lstsohist;
        //            model.lstSummary = new List<summaryBySuborderType>();
        //            var summary = lstsohist.GroupBy(q => new { q.subOrderType, q.taxabbNo, q.claimCheck, q.packingNo })
        //                .Select(g => new
        //                {
        //                    suborderType = g.Key.subOrderType,
        //                    packingNo = g.Key.packingNo,
        //                    taxAbbNo = g.Key.taxabbNo,
        //                    cliamCheck = g.Key.claimCheck,
        //                    totalQty = g.Sum(q => q.qty),
        //                    totalAmount = g.Sum(a => a.amount),
        //                    totalDiscount = g.Sum(a => a.discount),
        //                    totalNet = g.Sum(a => a.net)
        //                }).ToList();
        //            List<summaryBySuborderType> sum = new List<summaryBySuborderType>();
        //            foreach (var datsum in summary)
        //            {
        //                sum.Add(new summaryBySuborderType()
        //                {
        //                    subOrderType = datsum.suborderType,
        //                    cliamCheck = datsum.cliamCheck,
        //                    packingNo = datsum.packingNo,
        //                    taxAbbNo = datsum.taxAbbNo,
        //                    net = datsum.totalNet,
        //                    amount = datsum.totalAmount,
        //                    discount = datsum.totalDiscount,
        //                    qty = datsum.totalQty
        //                });
        //            }
        //            model.lstSummary = sum;

        //            model.lstLog = new List<ExtendLogs>();
        //            if (detail.runnoSohdrExt > 0)
        //            {
        //                var datlog = (
        //                    from p in _context1.dfExtendsLog
        //                    join c in _context1.CeLov.Where(a => a.LovgroupCode == "POS_LASTSTATUS") on p.valueCode equals c.Lovcode
        //                    where p.runno == detail.runnoSohdrExt
        //                    select new { p, c }
        //                    ).OrderBy(p => p.p.datetime).ToList();

        //                var listlog = new List<ExtendLogs>();
        //                foreach (var log in datlog)
        //                {
        //                    listlog.Add(new ExtendLogs()
        //                    {
        //                        detail = log.c.Lovvalue,
        //                        dtProcess = log.p.datetime,
        //                        statusCode = log.p.valueCode
        //                    });
        //                }
        //                model.lstLog = listlog;
        //            }
        //            lstModel.Add(model);
        //        }

        //        ret.Data = lstModel;
        //        ret.isCompleted = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        ret.SetMessage(ex);
        //        return ret;
        //    }
        //    return ret;
        //}




        public async Task<ReturnObject<List<DataModel>>> SearchShipping(SearchOrderInfoModel request)
        {
            var ret = new ReturnObject<List<DataModel>>();

            try
            {
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("WR001", "BranchNo is Required!>");
                    return ret;
                }

                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

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

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new KP.OrderGateway.DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var customerName = KP.Common.Helper.StringBL.StringNullToEmpty(request.customerName);

                var packingNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.packNo);

                var passportNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.passport);

                var shoppingCard = KP.Common.Helper.StringBL.StringNullToEmpty(request.shoppingCard);

                var lastStatus = StringBL.StringNullToEmpty(request.lastStatus);

                var orderStatus = StringBL.StringNullToEmpty(request.orderStatus);

                var machine = StringBL.StringNullToEmpty(request.machine);

                //var orderType = KP.Common.Helper.StringBL.StringNullToEmpty(request.orderType);


                var sqlQuery = @"select 
                                 r.branch_no as branchNo,
                                 r.order_status as orderStatus,
                                 LTRIM(RTRIM(c.cust_name)) as customerName,
                                 r.order_no as OrderNo,
                                 r.order_date as orderDate,
                                 c.passport_no as passportNo,
                                 r.shopping_card as shoppingCard,
                                 LTRIM(RTRIM(r.airline_code)) + LTRIM(RTRIM(r.flight_code)) as flight,
                                 '' as remark,
                                 LTRIM(RTRIM(r.cashier_mac)) as machine,";
                if (request.isWeb == null)
                {
                    request.isWeb = false;
                }

                if (!request.isWeb.Value)
                {
                    sqlQuery += " isnull(w.runno,0) as runnoSohdrExt,";
                }
                else
                {
                    sqlQuery += " Convert(bigint,0) as runnoSohdrExt,";
                }
                sqlQuery += @"
                                 
                                 FORMAT(r.flight_date, 'dd/MM/yyyy') + ' ' + LTRIM(RTRIM(r.flight_time)) as flightDateTime,
                                case 
	                                when e.Value is null or e.Value = '' then ''
	                                else e.Value
                                    end as orderType,
                                case
	                                when q.Value is null or q.Value = '' then ''
	                                else q.Value
                                    end as shipAddress,
                                case 
	                                when z.Value is null or z.Value = '' then ''
	                                else z.Value
                                    end as refOrder,
                                case
	                                when w.Value is null or w.Value = '' then ''
	                                else w.Value
                                    end as lastStatus,
                                null as dateTimeUpdate,
                                Convert(bit,0) as isChanged,
                                Convert(bit,0) as isDisPatch,
                                Convert(bit,0) as isPicking,
                                Convert(bit,0) as isSaveStock,
                                Convert(bit,0) as isScan,
                                Convert(bit,0) as isSendSTO,
                                '' as isOutOfStock,
                                '' as location,
                                isnull(p.PackingNo,'') as packingNo,
                                '' as pickingCheck,
                                cast(0 as decimal(7,2)) as qty,
                                cast(0 as decimal(7,2)) as total,
                                '' as userUpdate,
                                getdate() as updateDatetime
                                from df_sohdr r
                                inner
                                join df_customer c on r.branch_no = c.branch_no and r.shopping_card = c.shopping_card
                                left join df_subsohdr s on r.branch_no = s.branch_no and r.shopping_card = s.shopping_card and r.order_no = s.order_no
                                left join PK_PackingNo p on s.RecNo = p.SubSohdrRecNo and s.branch_no = p.BranchNo
                                left join df_sohdr_ext e on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
                                and e.Code = 'OrderType'
                                left join df_sohdr_ext q on r.branch_no = q.branch_no and r.shopping_card = q.shopping_card and r.order_no = q.order_no
                                and q.Code = 'ShipAddress'
                                left join df_sohdr_ext z on r.branch_no = z.branch_no and r.shopping_card = z.shopping_card and r.order_no = z.order_no
                                and(z.Code = 'ReceiveOrderNo' or z.Code = 'RefOrderNo')
                                left join df_sohdr_ext w on r.branch_no = w.branch_no and r.shopping_card = w.shopping_card and r.order_no = w.order_no
                                and w.Code = 'LastStatus'";


                //if (lastStatus != "")
                //{
                //    //sqlQuery += " left join df_extend_log l on w.runno = l.runno and l.valueCode ='" + lastStatus + "'";
                //    //sqlQuery += " left join (select top 1 * from df_extend_log where valueCode='" + lastStatus + "' ) l on w.runno=l.runno ";
                //    sqlQuery += " and w.Value='" + lastStatus + "' ";
                //}

                sqlQuery += " where r.branch_no='" + branchNo + "' and (r.order_date>='" + request.startDate.Date + "' and r.order_date<='" + request.endDate.Date + "')";

                //var qqq = listLinq.ToList();
                if (customerName != "")
                {
                    customerName = customerName.ToUpper();
                    sqlQuery += " and c.cust_name like '%" + customerName + "%' ";
                }

                if (passportNo != "")
                {
                    passportNo = passportNo.ToUpper();
                    sqlQuery += " and c.passport_no ='" + passportNo + "' ";
                }

                if (packingNo != "")
                {
                    packingNo = packingNo.ToUpper();
                    sqlQuery += " and p.PackingNo='" + packingNo + "' ";
                }

                if (orderStatus != "")
                {
                    sqlQuery += " and r.order_status='" + orderStatus + "' ";
                }

                if (shoppingCard != "")
                {
                    sqlQuery += " and r.shopping_card='" + shoppingCard + "' ";
                }

                if (request.orderNo > 0)
                {
                    sqlQuery += " and r.order_no=" + request.orderNo + " ";
                }

                if (request.orderDate != null)
                {
                    //listLinq = listLinq.Where(a => a.orderDate.Date == request.orderDate.Value.Date);
                    sqlQuery += " and r.order_date='" + request.orderDate.Value.Date + "' ";
                }

                if (lastStatus != "")
                {
                    sqlQuery += " and w.Value='" + lastStatus + "' ";
                }

                //if (machine != "")
                //{
                //    sqlQuery += " and r.cashier_mac ='" + machine + "' ";
                //}


                //var dataTest = _context1.Database.SqlQuery<OrderModel>(sqlQuery);// < OrderModel > sqlQuery(sqlQuery);
                var dataTest = _context1.Set<OrderModelShipping>().FromSql(sqlQuery).ToList();

                if (request.orderType != null && request.orderType.Count() > 0)
                {
                    dataTest = dataTest.Where(a => request.orderType.Contains(a.orderType)).ToList();
                }

                if (machine != "")
                {
                    var splitMachine = machine.Split(',');
                    if (splitMachine.Count() > 1)
                    {
                        dataTest = dataTest.Where(a => splitMachine.Contains(a.machine)).ToList();
                    }
                    else
                    {
                        dataTest = dataTest.Where(a => a.machine == machine).ToList();
                    }
                }

                /*

                var listLinq = (from r in _context1.DfSohdr
                                join c in _context1.DfCustomer on new { r.BranchNo, r.ShoppingCard } equals
                                   new { c.BranchNo, c.ShoppingCard }
                                join s in _context1.DfSubsohdr on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { s.BranchNo, s.ShoppingCard, s.OrderNo } into rs
                                from srs in rs.DefaultIfEmpty()
                                join p in _context1.PkPackingNo on new {SubSohdrRecNo=srs.RecNo,srs.BranchNo} equals new { p.SubSohdrRecNo ,p.BranchNo} into ps
                                from sps in ps.DefaultIfEmpty()
                                join e in _context1.DfSohdrExt.Where(a => a.Code == "OrderType") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { e.BranchNo, e.ShoppingCard, e.OrderNo } into xy
                                from sxy in xy.DefaultIfEmpty()
                                join q in _context1.DfSohdrExt.Where(a => a.Code == "ShipAddress") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { q.BranchNo, q.ShoppingCard, q.OrderNo } into yz
                                from syz in yz.DefaultIfEmpty()
                                join z in _context1.DfSohdrExt.Where(a => a.Code == "ReceiveOrderNo" || a.Code == "RefOrderNo") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { z.BranchNo, z.ShoppingCard, z.OrderNo } into zz
                                from szz in zz.DefaultIfEmpty()
                                join w in _context1.DfSohdrExt.Where(a => a.Code == "LastStatus") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { w.BranchNo, w.ShoppingCard, w.OrderNo } into ww
                                from sww in ww.DefaultIfEmpty()
                                where
                                r.BranchNo == branchNo
                                && (r.OrderDate.Date >= request.startDate.Date && r.OrderDate.Date <= request.endDate.Date)
                                select new OrderModel
                                {
                                    branchNo = r.BranchNo,
                                    orderStatus = r.OrderStatus,
                                    customerName = c.CustName.Trim(),
                                    orderNo = r.OrderNo,
                                    orderDate = r.OrderDate,
                                    packingNo = sps.PackingNo == null || sps.PackingNo == "" ? "" : sps.PackingNo.Trim(), //p.PackingNo.Trim(),
                                    passportNo = c.PassportNo.Trim(),
                                    shoppingCard = r.ShoppingCard,
                                    flight = r.AirlineCode.Trim() + r.FlightCode.Trim(),
                                    flightDateTime = r.FlightDate.Value.Date + " " + r.FlightTime,
                                    remark = "",
                                    isChanged = false,
                                    orderType = sxy.Value == "" || sxy.Value == null ? "N" : sxy.Value,
                                    shipAddress = syz.Value == "" || syz.Value == null ? "" : syz.Value,
                                    refOrder = szz.Value == "" || szz.Value == null ? "" : szz.Value,
                                    lastStatus = sww.Value == "" || sww.Value == null ? "" : sww.Value,
                                    machine = r.CashierMac,
                                    runnoSohdrExt = sww.runno >0 ? sww.runno : 0
                                });


                //var qqq = listLinq.ToList();
                if (customerName != "")
                {
                    customerName = customerName.ToUpper();
                    listLinq = listLinq.Where(a => a.customerName.Contains(customerName));
                }

                if (passportNo != "")
                {
                    passportNo = passportNo.ToUpper();
                    listLinq = listLinq.Where(a => a.passportNo == passportNo);
                }

                if (packingNo != "")
                {
                    packingNo = packingNo.ToUpper();
                    listLinq = listLinq.Where(a => a.packingNo == packingNo);
                }

                if (orderStatus != "")
                {
                    listLinq = listLinq.Where(a => a.orderStatus == orderStatus);
                }

                if (shoppingCard != "")
                {
                    listLinq = listLinq.Where(a => a.shoppingCard == shoppingCard);
                }

                if (request.orderNo > 0)
                {
                    listLinq = listLinq.Where(a => a.orderNo == request.orderNo);
                }

                if (request.orderType != null && request.orderType.Count() > 0)
                {
                    listLinq = listLinq.Where(a => request.orderType.Contains(a.orderType));
                }



                if (request.orderDate != null)
                {
                    listLinq = listLinq.Where(a => a.orderDate.Date == request.orderDate.Value.Date);
                }

                if (lastStatus != "")
                {
                    listLinq = listLinq.Where(a => a.lastStatus == lastStatus);
                }

                if (machine != "")
                {
                    var splitMachine = machine.Split(',');
                    if(splitMachine.Count()>1)
                    {
                        listLinq = listLinq.Where(a => splitMachine.Contains(a.machine));
                    }
                    else
                    {
                        listLinq = listLinq.Where(a => a.machine == machine);
                    }
                }
                */

                var lstData = dataTest.ToList();

                var lstModel = new List<DataModel>();
                foreach (var detail in lstData)
                {
                    var checkModel = lstModel.Where(q => q.branchNo == detail.branchNo &&
                                        q.shoppingCard == detail.shoppingCard &&
                                        q.orderNo == detail.orderNo).FirstOrDefault();

                    if (checkModel == null)
                    {
                        var sumList = (from h in _context1.DfSohist
                                       join p in _context1.DfSubsohdr on new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType }
                                       equals new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType } into ps
                                       from sps in ps.DefaultIfEmpty()
                                       where h.LineCancel == false
                                       && h.BranchNo == detail.branchNo &&
                                       h.ShoppingCard == detail.shoppingCard &&
                                       h.OrderNo == detail.orderNo
                                       select new
                                       {
                                           packNo = sps.PkPackingNo.FirstOrDefault() == null ? "" : sps.PkPackingNo.FirstOrDefault().PackingNo.Trim(),  //p.PkPackingNo.FirstOrDefault().PackingNo,
                                           qty = h.Quantity,
                                           amount = h.Amount,
                                           discount = h.Discount,
                                           net = h.Net
                                       }).ToList();

                        if (packingNo != "")
                        {
                            sumList = sumList.Where(a => a.packNo.Contains(packingNo)).ToList();
                        }

                        detail.qty = sumList.Sum(a => a.qty);
                        detail.total = sumList.Sum(a => a.net);

                        var checkPreOrder = _context1.PreOrderChangeFlight.Where(a =>
                        a.BranchNo == detail.branchNo &&
                        a.ShoppingCard == detail.shoppingCard &&
                        a.OrderNo == detail.orderNo).FirstOrDefault();
                        if (checkPreOrder != null)
                        {
                            detail.flight = StringBL.StringNullToEmpty(checkPreOrder.AirlineCode) +
                                StringBL.StringNullToEmpty(checkPreOrder.FlightCode);
                            detail.flightDateTime = checkPreOrder.FlightDt.ToString("yyyy-MM-dd HH:mm");
                            detail.remark = StringBL.StringNullToEmpty(checkPreOrder.Remark);
                            detail.userUpdate = checkPreOrder.UserUpdate;
                            detail.dateTimeUpdate = checkPreOrder.UpdateDatetime;
                            detail.isChanged = true;
                        }
                    }
                    else
                    {
                        if (detail.packingNo != "")
                        {
                            checkModel.packingNo = checkModel.packingNo + "," + detail.packingNo;
                        }
                        continue;
                    }

                    bool isDispatch = false;
                    var dataPacking = detail.packingNo.Trim();
                    if (dataPacking.Length > 0)
                    {
                        var chkDispatch = _context1.DispatchTransPack.Where(a => a.ShopCard == detail.shoppingCard && a.order_no == detail.orderNo).FirstOrDefault();
                        if (chkDispatch != null)
                        {
                            isDispatch = true;
                        }
                    }

                    DataModel model = new DataModel()
                    {
                        branchNo = detail.branchNo,
                        shoppingCard = detail.shoppingCard,
                        orderNo = detail.orderNo,
                        orderDate = detail.orderDate,
                        packingNo = detail.packingNo.Trim(),
                        passportNo = detail.passportNo.Trim(),
                        customerName = detail.customerName.Trim(),
                        flight = detail.flight.Trim(),
                        flightDateTime = detail.flightDateTime,
                        qty = detail.qty,
                        total = detail.total,
                        lstSohist = new List<listProduct>(),
                        dateTimeUpdate = detail.dateTimeUpdate,
                        userUpdate = detail.userUpdate,
                        remark = detail.remark,
                        isChanged = detail.isChanged,
                        shipAddress = detail.shipAddress,
                        orderType = detail.orderType,
                        orderStatus = detail.orderStatus,
                        isDisPatch = isDispatch,
                        refOrder = detail.refOrder,
                        lastStatus = detail.lastStatus,
                        machine = detail.machine,
                        runnoSohdrExt = detail.runnoSohdrExt
                    };

                    List<listProduct> lstsohist = new List<listProduct>();

                    var lstProduct = (from p in _context1.DfSohist
                                      join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                                      join h in _context1.DfSubsohdr on new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType }
                                      equals new { h.BranchNo, h.ShoppingCard, h.OrderNo, h.SuborderType } into ps
                                      from sps in ps.DefaultIfEmpty()
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
                                      && p.OrderNo == detail.orderNo && p.LineCancel == false
                                      orderby p.LineNo
                                      select new listProduct
                                      {
                                          articleCode = p.ItemCode,
                                          articleName = v.ArticleName,
                                          discount = p.Discount,
                                          discrate = p.DiscRate,
                                          line_No = p.LineNo,
                                          net = p.Net,
                                          price = p.SellingPrice,
                                          amount = p.Amount,
                                          qty = p.Quantity,
                                          claimCheck = sps.ClaimcheckNo == null || sps.ClaimcheckNo == "" ? "" : sps.ClaimcheckNo.Trim(), //h.ClaimcheckNo.Trim(),
                                          taxabbNo = sps.TaxabbNo == null || sps.TaxabbNo == "" ? "" : sps.TaxabbNo.Trim(), //h.TaxabbNo.Trim(),
                                          subOrderType = sps.SuborderType == null || sps.SuborderType == "" ? "" : sps.SuborderType.Trim(),// h.SuborderType.Trim(),
                                          packingNo = sps.PkPackingNo.FirstOrDefault() == null ? "" : sps.PkPackingNo.FirstOrDefault().PackingNo
                                      }).ToList();

                    if (packingNo != "")
                    {
                        lstProduct = lstProduct.Where(a => a.packingNo.Contains(packingNo)).ToList();
                    }
                    //var queryProduct = String.Format(stringProduct, detail.branchNo, detail.shoppingCard, detail.orderNo);

                    //var lstProduct = new List<listProduct>();
                    //lstProduct =   _context.Set<ServiceModel.listProduct>().FromSql(queryProduct).ToList();

                    foreach (var prd in lstProduct)
                    {
                        listProduct data = new listProduct()
                        {
                            articleCode = prd.articleCode.Trim(),
                            articleName = prd.articleName.Trim(),
                            discount = prd.discount,
                            discrate = prd.discrate,
                            line_No = prd.line_No,
                            net = prd.net,
                            price = prd.price,
                            amount = prd.amount,
                            claimCheck = prd.claimCheck,
                            packingNo = prd.packingNo,
                            subOrderType = prd.subOrderType,
                            taxabbNo = prd.taxabbNo,
                            qty = prd.qty
                        };
                        lstsohist.Add(data);
                    }

                    model.lstSohist = lstsohist;
                    model.lstSummary = new List<summaryBySuborderType>();
                    var summary = lstsohist.GroupBy(q => new { q.subOrderType, q.taxabbNo, q.claimCheck, q.packingNo })
                        .Select(g => new
                        {
                            suborderType = g.Key.subOrderType,
                            packingNo = g.Key.packingNo,
                            taxAbbNo = g.Key.taxabbNo,
                            cliamCheck = g.Key.claimCheck,
                            totalQty = g.Sum(q => q.qty),
                            totalAmount = g.Sum(a => a.amount),
                            totalDiscount = g.Sum(a => a.discount),
                            totalNet = g.Sum(a => a.net)
                        }).ToList();
                    List<summaryBySuborderType> sum = new List<summaryBySuborderType>();
                    foreach (var datsum in summary)
                    {
                        sum.Add(new summaryBySuborderType()
                        {
                            subOrderType = datsum.suborderType,
                            cliamCheck = datsum.cliamCheck,
                            packingNo = datsum.packingNo,
                            taxAbbNo = datsum.taxAbbNo,
                            net = datsum.totalNet,
                            amount = datsum.totalAmount,
                            discount = datsum.totalDiscount,
                            qty = datsum.totalQty
                        });
                    }
                    model.lstSummary = sum;

                    model.lstLog = new List<ExtendLogs>();
                    if (detail.runnoSohdrExt > 0)
                    {
                        var datlog = (
                            from p in _context1.dfExtendsLog
                            join c in _context1.CeLov.Where(a => a.LovgroupCode == "POS_LASTSTATUS") on p.valueCode equals c.Lovcode
                            where p.runno == detail.runnoSohdrExt
                            select new { p, c }
                            ).OrderBy(p => p.p.datetime).ToList();

                        var listlog = new List<ExtendLogs>();
                        foreach (var log in datlog)
                        {
                            listlog.Add(new ExtendLogs()
                            {
                                detail = log.c.Lovvalue,
                                dtProcess = log.p.datetime,
                                statusCode = log.p.valueCode,
                                userCode = log.p.userCode
                            });
                        }
                        model.lstLog = listlog;
                    }
                    lstModel.Add(model);
                }

                ret.Data = lstModel;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
                return ret;
            }
            return ret;
        }

        public async Task<ReturnObject<List<ReportTrans>>> ReportStock(SearchOrderReport request)
        {
            ReturnObject<List<ReportTrans>> ret = new ReturnObject<List<ReportTrans>>();
            ret.Data = new List<ReportTrans>();
            try
            {
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("WR001", "BranchNo is Required!");
                    return ret;
                }

                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

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
                    ret.SetMessage("Ex-Data", "Invalid Input Please check Branch & Sub Branch !.");
                    return ret;
                }


                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);


                var listLinq = (from r in _context1.DfSohdr
                                join c in _context1.DfCustomer on new { r.BranchNo, r.ShoppingCard } equals
                                   new { c.BranchNo, c.ShoppingCard }
                                join s in _context1.DfSubsohdr on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { s.BranchNo, s.ShoppingCard, s.OrderNo } into rs
                                from srs in rs.DefaultIfEmpty()
                                join p in _context1.PkPackingNo on srs.RecNo equals p.SubSohdrRecNo into ps
                                from sps in ps.DefaultIfEmpty()
                                join e in _context1.DfSohdrExt.Where(a => a.Code == "OrderType") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { e.BranchNo, e.ShoppingCard, e.OrderNo } into xy
                                from sxy in xy.DefaultIfEmpty()
                                join q in _context1.DfSohdrExt.Where(a => a.Code == "PickingCheck") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { q.BranchNo, q.ShoppingCard, q.OrderNo } into yz
                                from syz in yz.DefaultIfEmpty()
                                join l in _context1.DfSubsohdrExt.Where(a => a.Code == "LocCode") on srs.RecNo equals l.SubSohdrRecNo
                                into ls
                                from lsz in ls.DefaultIfEmpty()

                                    //join z in _context1.DfSohdrExt.Where(a => a.Code == "ReceiveOrderNo" || a.Code == "RefOrderNo") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                    //new { z.BranchNo, z.ShoppingCard, z.OrderNo } into zz
                                    //from szz in zz.DefaultIfEmpty()
                                where
                                r.BranchNo == branchNo
                                //&& (r.OrderDate.Date >= currentDate.AddDays(-1).Date && r.OrderDate.Date <= currentDate.Date)
                                //&& (r.UpdateDatetime.TimeOfDay >= t1 && r.UpdateDatetime.TimeOfDay <= t2)
                                orderby r.UpdateDatetime ascending
                                select new OrderModel
                                {
                                    branchNo = r.BranchNo,
                                    orderStatus = r.OrderStatus,
                                    customerName = c.CustName.Trim(),
                                    orderNo = r.OrderNo,
                                    orderDate = r.OrderDate,
                                    packingNo = sps.PackingNo == null || sps.PackingNo == "" ? "" : sps.PackingNo.Trim(), //p.PackingNo.Trim(),
                                    passportNo = c.PassportNo.Trim(),
                                    shoppingCard = r.ShoppingCard,
                                    flight = r.AirlineCode.Trim() + r.FlightCode.Trim(),
                                    flightDateTime = r.FlightDate.Value.Date + " " + r.FlightTime,
                                    remark = "",
                                    machine = r.CashierMac.Trim(),
                                    isChanged = false,
                                    orderType = sxy.Value == "" || sxy.Value == null ? "N" : sxy.Value,
                                    updateDatetime = r.UpdateDatetime,
                                    pickingCheck = syz.Value == "" || syz.Value == null ? "" : syz.Value,
                                    location = lsz.Value == "" || lsz.Value == null ? "" : lsz.Value,

                                    //shipAddress = syz.Value == "" || syz.Value == null ? "" : syz.Value,
                                    //refOrder = szz.Value == "" || szz.Value == null ? "" : szz.Value
                                });

                if (request.saleDateFrom != null && request.saleDateTo != null)
                {
                    listLinq = listLinq.Where(a => a.orderDate.Date >= request.saleDateFrom.Value.Date && a.orderDate.Date <= request.saleDateTo.Value.Date);

                }
                else if (request.saleDateFrom != null || request.saleDateTo != null)
                {
                    if (request.saleDateFrom != null)
                    {
                        listLinq = listLinq.Where(a => a.orderDate.Date == request.saleDateFrom.Value.Date);
                    }
                    else if (request.saleDateTo != null)
                    {
                        listLinq = listLinq.Where(a => a.orderDate.Date == request.saleDateTo.Value.Date);
                    }
                }


                if (StringBL.StringNullToEmpty(request.timeFrom) != "" && StringBL.StringNullToEmpty(request.timeTo) != "")
                {
                    TimeSpan t1 = new TimeSpan(00, 00, 00);
                    TimeSpan t2 = new TimeSpan(00, 00, 00);

                    var split1 = request.timeFrom.Split(":");
                    var split2 = request.timeTo.Split(":");

                    t1 = new TimeSpan(Convert.ToInt32(split1[0]), Convert.ToInt32(split1[1]), 0);
                    t2 = new TimeSpan(Convert.ToInt32(split2[0]), Convert.ToInt32(split2[1]), 0);

                    listLinq = listLinq.Where(a => a.updateDatetime.TimeOfDay >= t1 && a.updateDatetime.TimeOfDay <= t2);
                }

                if (StringBL.StringNullToEmpty(request.orderType) != "")
                {
                    listLinq = listLinq.Where(a => a.orderType.Contains(request.orderType));
                }

                if (StringBL.StringNullToEmpty(request.saleType) != "")
                {
                    if (request.saleType == "E")
                    {
                        listLinq = listLinq.Where(a => a.orderStatus == "E");
                    }
                    else if (request.saleType == "V")
                    {
                        listLinq = listLinq.Where(a => a.orderStatus == "V");
                    }
                }
                else
                {
                    listLinq = listLinq.Where(a => a.orderStatus == "E" || a.orderStatus == "V");
                }


                var lstData = listLinq.ToList();



                List<ReportTrans> lstReport = new List<ReportTrans>();
                foreach (var data in lstData)
                {
                    var detail = (from s in _context1.DfSohist
                                  join v in _context1.vArticleMC on s.MatCode equals v.ArticleCode
                                  where s.BranchNo == data.branchNo && s.ShoppingCard == data.shoppingCard
                                  && s.OrderNo == data.orderNo
                                  select new ReportTrans()
                                  {
                                      branchNo = data.branchNo,
                                      brand = StringBL.StringNullToEmpty(v.BrandCode),
                                      category = StringBL.StringNullToEmpty(v.CateCode),
                                      cateName = StringBL.StringNullToEmpty(v.CateName),
                                      description = StringBL.StringNullToEmpty(v.ArticleName),
                                      dutypaidArticle = StringBL.StringNullToEmpty(v.ArticleCode),
                                      orderNo = data.orderNo,
                                      shoppingCard = data.shoppingCard,
                                      saleDate = data.updateDatetime,
                                      qty = s.Quantity,
                                      orderType = data.orderType,
                                      machine = data.machine,
                                      amount = s.Amount,
                                      discount = s.Discount,
                                      net = s.Net,
                                      orderDate = data.orderDate.ToString("dd/MM/yyyy"),
                                      packingNo = data.packingNo
                                  }).ToList();

                    if (detail.Count() > 0)
                    {
                        lstReport.AddRange(detail);
                    }
                }

                var brand = StringBL.StringNullToEmpty(request.brand);
                if (brand != "")
                {
                    lstReport = lstReport.Where(a => a.brand == brand).ToList();
                }

                var category = StringBL.StringNullToEmpty(request.category);
                if (category != "")
                {
                    lstReport = lstReport.Where(a => a.category == category).ToList();
                }




                //var listTrans = (from q in lstData
                //                 join p in _context1.DfSohist on new { BranchNo = q.branchNo, ShoppingCard = q.shoppingCard, OrderNo = q.orderNo } equals new { p.BranchNo, p.ShoppingCard, p.OrderNo }
                //                 join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                //                 // join s in _vscontext.VstArticleDutyPaidRemain on p.MatCode equals s.ArticleCodeDutyPaid into sp
                //                 // from xsq in sp.DefaultIfEmpty()
                //                 where q.branchNo == branchNo
                //                 select new ReportTrans()
                //                 {
                //                     branchNo = StringBL.StringNullToEmpty(q.branchNo),
                //                     brand = StringBL.StringNullToEmpty(v.BrandCode),
                //                     category = StringBL.StringNullToEmpty(v.CateCode),
                //                     cateName = StringBL.StringNullToEmpty(v.CateName),
                //                     description = StringBL.StringNullToEmpty(v.ArticleName),
                //                     oldArticle = StringBL.StringNullToEmpty(v.ArticleCode),
                //                     orderNo = q.orderNo,
                //                     shoppingCard = q.shoppingCard,
                //                     saleDate = q.updateDatetime,
                //                     machine =  q.machine,
                //                     //dutypaidArticle = StringBL.StringNullToEmpty(xsq.ArticleCode),
                //                     qty = p.Quantity
                //                 }
                //                 );


                //if (StringBL.StringNullToEmpty(request.brand) != "")
                //{
                //    listTrans = listTrans.Where(a => a.brand == request.brand);
                //}

                //if (StringBL.StringNullToEmpty(request.category) != "")
                //{
                //    listTrans = listTrans.Where(a => a.category == request.category);
                //}

                //var dataStock = listTrans.OrderBy(a => a.saleDate).ToList();


                var constrVS = "";
                var getDbVS = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "VS" &&
                a.SubBranch == subBranch).FirstOrDefault();

                if (getDbVS != null)
                {
                    var server = StringBL.StringNullToEmpty(getDbVS.DbServer);
                    var database = StringBL.StringNullToEmpty(getDbVS.DbName);
                    var user = StringBL.StringNullToEmpty(getDbVS.DbUser);
                    var password = StringBL.StringNullToEmpty(getDbVS.DbPass);
                    constrVS = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                            server, database, user, password);
                }
                else
                {
                    ret.SetMessage("Ex-Data", "Invalid Input Please check Branch & Sub Branch !.");
                    return ret;
                }


                var optionBuilderVS = new DbContextOptionsBuilder<KPVirtualStockContext>();
                optionBuilderVS.UseSqlServer(constrVS);
                var _vscontext1 = new KPVirtualStockContext(optionBuilderVS.Options);

                var listStock = _vscontext1.VstRemainAlls.Where(a => a.date == DateTime.Now.Date).ToList();

                int index = 0;
                foreach (var stock in lstReport)
                {
                    index++;
                    stock.lineNo = index;
                    var remark = "";
                    var qty = 0.0m;
                    var articleCode = "";
                    //find ifBlue Tag 
                    var findBlueTag = _vscontext1.VstArticleDutyPaidRemain.Where(a => a.ArticleCodeDutyPaid == stock.dutypaidArticle).FirstOrDefault();
                    if (findBlueTag != null)
                    {
                        stock.oldArticle = StringBL.StringNullToEmpty(findBlueTag.ArticleCode);
                        if (stock.dutypaidArticle.Length > 8)
                        {
                            stock.dutypaidArticle = stock.dutypaidArticle.Substring(stock.dutypaidArticle.Length - 8, 8);
                        }
                    }
                    else
                    {
                        stock.oldArticle = stock.dutypaidArticle;
                        stock.dutypaidArticle = "";
                    }

                    if (stock.oldArticle.Length > 8)
                    {
                        articleCode = stock.oldArticle;
                        stock.oldArticle = stock.dutypaidArticle.Substring(stock.dutypaidArticle.Length - 8, 8);
                    }



                    var findStockSAP = listStock.Where(a => a.article_code == articleCode).Select(a => a.qty).FirstOrDefault();
                    if (findStockSAP <= 0)
                    {
                        //remark = "Out of Stock (o/t) [No have Qty for this Article] 0/" + stock.qty;
                        remark = "Out of Stock";
                    }
                    else
                    {
                        if (findStockSAP - stock.qty >= 0)
                        {
                            qty = stock.qty;
                            foreach (var dat in listStock.Where(a => a.article_code == articleCode))
                            {
                                dat.qty = dat.qty - stock.qty;
                            }
                        }
                        else if (findStockSAP - stock.qty < 0)
                        {
                            qty = findStockSAP;
                            // remark = "Out of Stock (o/t) [" + Math.Abs(findStockSAP - stock.qty) + " / " + stock.qty;
                            remark = "Out of Stock";
                            foreach (var dat in listStock.Where(a => a.article_code == articleCode))
                            {
                                dat.qty = 0;
                            }
                        }
                    }



                    stock.qty = qty;
                    stock.remarks = remark;
                }
                ret.Data = lstReport;

                //var groupData = lstReport.GroupBy(a => new { a.shoppingCard, a.orderNo }).ToList();


                ////int index = 0;
                ////foreach (var data in groupData)
                ////{
                ////    //index++;
                ////    //ReportModel mol = new ReportModel()
                ////    //{
                ////    //    index = index,
                ////    //    order = data.ToList(),
                ////    //    summaryOrder = data.Sum(a => a.qty)
                ////    //};
                ////    //ret.Data.Add(mol);
                ////}

                //ret.Data = groupData;

                ret.totalCount = ret.Data.Count();
                /*


                var lstModel = new List<DataModel>();

                foreach (var detail in lstData)
                {

                    var model = new DataModel()
                    {
                        branchNo = detail.branchNo,
                        shoppingCard = detail.shoppingCard,
                        orderNo = detail.orderNo,
                        orderDate = detail.orderDate,
                        packingNo = detail.packingNo.Trim(),
                        passportNo = detail.passportNo.Trim(),
                        customerName = detail.customerName.Trim(),
                        flight = detail.flight.Trim(),
                        flightDateTime = detail.flightDateTime,
                        qty = detail.qty,
                        total = detail.total,
                        lstSohist = new List<listProduct>(),
                        dateTimeUpdate = detail.dateTimeUpdate,
                        userUpdate = detail.userUpdate,
                        remark = detail.remark,
                        shipAddress = detail.shipAddress,
                        orderType = detail.orderType,
                        orderStatus = detail.orderStatus,
                        isPicking = detail.orderStatus == "E" ? true : false,
                        isSaveStock = detail.pickingCheck != "" ? true : false,
                        pickingCheck = detail.pickingCheck,
                        refOrder = ""
                    };


                    List<listProduct> lstsohist = new List<listProduct>();

                    var lstProduct = (from p in _context1.DfSohist
                                      join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
                                      && p.OrderNo == detail.orderNo && p.LineCancel == false
                                      orderby p.LineNo
                                      select new listProduct
                                      {
                                          articleCode = p.ItemCode,
                                          articleName = v.ArticleName,
                                          discount = p.Discount,
                                          discrate = p.DiscRate,
                                          line_No = p.LineNo,
                                          net = p.Net,
                                          price = p.SellingPrice,
                                          amount = p.Amount,
                                          qty = p.Quantity,
                                          mccode = v.MCCode,
                                          brandCode = v.BrandCode
                                      }).ToList();

                    foreach (var prd in lstProduct)
                    {
                        var remark = "";
                        var qty = 0.0m;
                        var findStockSAP = listStock.Where(a => a.article_code == prd.articleCode).Select(a => a.qty).FirstOrDefault();
                        if (findStockSAP == null || findStockSAP <= 0)
                        {
                            remark = "Out of Stock (o/t) [No have Qty for this Article] 0/" + prd.qty;
                        }
                        else
                        {
                            if (findStockSAP - prd.qty >= 0)
                            {
                                qty = prd.qty;
                                foreach (var dat in listStock.Where(a => a.article_code == prd.articleCode))
                                {
                                    dat.qty = dat.qty - prd.qty;
                                }
                            }
                            else if (findStockSAP - prd.qty < 0)
                            {
                                qty = findStockSAP;
                                remark = "Out of Stock (o/t) [" + Math.Abs(findStockSAP - prd.qty) + " / " + prd.qty;
                                foreach (var dat in listStock.Where(a => a.article_code == prd.articleCode))
                                {
                                    dat.qty = 0;
                                }
                            }
                        }

                        listProduct data = new listProduct()
                        {
                            articleCode = prd.articleCode.Trim(),
                            articleName = prd.articleName.Trim(),
                            discount = prd.discount,
                            discrate = prd.discrate,
                            line_No = prd.line_No,
                            net = prd.net,
                            price = prd.price,
                            amount = prd.amount,
                            claimCheck = prd.claimCheck,
                            packingNo = prd.packingNo,
                            subOrderType = prd.subOrderType,
                            taxabbNo = prd.taxabbNo,
                            qty = qty,
                            remark = remark
                        };
                        lstsohist.Add(data);
                    }
                    model.lstSohist = lstsohist;
                    lstModel.Add(model);
                }
                */

                // ret.Data = lstModel;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Report", ex.Message);
            }

            return ret;
        }

        public async Task<ReturnObject<List<KPDModel>>> SearchStockKPD(SearchStockKPD request)
        {
            ReturnObject<List<KPDModel>> ret = new ReturnObject<List<KPDModel>>();

            try
            {
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("WR001", "BranchNo is Required!");
                    return ret;
                }


                //var timeCode = StringBL.StringNullToEmpty(request.timecode);
                //if (timeCode == "")
                //{
                //    ret.SetMessage("WR002", "TimeCode is Required!.");
                //}

                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

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
                    ret.SetMessage("Ex-Master", "No found Connection pos on Config!.");
                    return ret;
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var orderNo = 0;

                var customerName = StringBL.StringNullToEmpty(request.customerName);

                var packingNo = StringBL.StringNullToEmpty(request.packNo);

                var passportNo = StringBL.StringNullToEmpty(request.passport);

                var shoppingCard = StringBL.StringNullToEmpty(request.shoppingCard);

                var flightCode = StringBL.StringNullToEmpty(request.flightCode);

                var machine = StringBL.StringNullToEmpty(request.machine);

                List<string> lstsite = new List<string>();
                bool isCheckMachine = false;
                bool isOrder = false;
                if (machine != "")
                {
                    isCheckMachine = true;
                    var getMachine = (from p in _context1.CKCMachine
                                      join q in _context1.CKCMachineSite on p.machineNo equals q.machineNo
                                      where p.machineIP == machine
                                      select q
                                      ).ToList();
                    if (getMachine == null)
                    {
                        ret.SetMessage("W02", "Machine Ip :" + machine + " not found in Master");
                        return ret;
                    }
                    else
                    {
                        foreach (var site in getMachine)
                        {
                            lstsite.Add(site.siteCode.Replace("%", ""));
                        }
                    }


                    if (lstsite.Count() == 0)
                    {
                        ret.SetMessage("Ex-Data", "Site is Emply.Please Config site in Master");
                        return ret;
                    }

                    var getDefault = getMachine.FirstOrDefault();
                    if (getDefault != null)
                    {
                        var getSetting = _context1.CKCMachineSettings.Where(a => a.machine_no == getDefault.machineNo).FirstOrDefault();
                        if (getSetting == null)
                        {
                            ret.SetMessage("Ex-Data", "Input Machine " + getDefault + " is not set in MachineSettings");
                        }
                        else
                        {
                            if (getSetting.machine_group.Trim() == "KPD" && getSetting.machine_value.Trim() == "WAREHOUSE")
                            {
                                isOrder = true;
                            }
                        }
                    }

                }

                var splitStr = request.shoppingCard.Split("|");
                if (splitStr.Count() > 1)
                {
                    shoppingCard = splitStr[1];
                    orderNo = Convert.ToInt32(splitStr[2]);
                    //isCheckTime = false;
                }


                //if(isCheckTime)
                //{
                //    if (flightCode == "")
                //    {
                //        ret.SetMessage("WR005", "flight code is Required!.");
                //        return ret;
                //    }

                //    if (request.flightFrom == null || request.flightTo == null)
                //    {
                //        if (request.flightFrom == null)
                //        {
                //            ret.SetMessage("WR006", "Flight Date From is Required!.");
                //            return ret;
                //        }

                //        if (request.flightTo == null)
                //        {
                //            ret.SetMessage("WR007", "Flight Date To is Required!.");
                //            return ret;
                //        }
                //    }
                //}


                var orderStatus = StringBL.StringNullToEmpty(request.orderStatus);
                var nowDate = DateTime.Now;// new DateTime().AddDays(Convert.ToDouble(getDataTime.datediff));
                var currentDate = nowDate;

                TimeSpan t1 = new TimeSpan(), t2 = new TimeSpan();


                var filterStatus = StringBL.StringNullToEmpty(request.isSave);
                if (filterStatus == "") filterStatus = request.status;

                bool isShoppingcard = false;


                var rawSql = @"select 
        r.branch_no as BranchNo,
        r.order_status as orderStatus,
        LTRIM(RTRIM(c.cust_name)) as customerName,
        r.order_no as orderNo,
        r.order_date as orderDate,
        CASE 
            WHEN p.PackingNo is null or p.PackingNo='' then ''
            else LTRIM(RTRIM(p.PackingNo)) end as packingNo,
        LTRIM(RTRIM(c.passport_no)) as passportNo,
        r.shopping_card as shoppingCard,
        LTRIM(RTRIM(r.flight_code)) as flight,
        FORMAT(r.flight_date, 'dd/MM/yyyy') + ' ' + LTRIM(RTRIM(r.flight_time)) as flightDateTime,
        '' as remark,
        CASE 
            WHEN e.Value is null or e.Value = '' then ''
            else e.Value end as orderType,
        r.update_datetime as updateDatetime,
        CASE 
            WHEN q.Value is null or q.Value = '' then ''
            else q.Value end as pickingCheck,
        LTRIM(RTRIM(r.airline_code)) as airlineCode,
        LTRIM(RTRIM(r.airline_code)) + LTRIM(RTRIM(r.flight_code)) as flightCode,
        r.flight_date as flightDate,
        r.flight_time as flightTime,
        LTRIM(RTRIM(r.cust_type_code)) as customerType,
        LTRIM(RTRIM(c.country_code)) as nationCode,
        CASE 
            WHEN f.Value is null or f.Value = '' then ''
            else f.Value end as flightType,
        r.Posid as posID,
        r.cashier_mac as machineNo,
        CASE 
            WHEN o.Value is null or o.Value = '' then ''
            else o.Value end as operatorCode,
        s.pickup_code as pickupCode,
        s.claimcheck_no as refNo,
        s.add_datetime as transDT,
        s.user_add as userAdd,
        CASE 
            WHEN v.Value is null or v.Value = '' then 'false'
            else v.Value end as isPackAtWH,
        CASE 
            WHEN b.Value is null or b.Value = '' then ''
            else b.Value end as lastStatusKpd
     from df_sohdr r
    inner
     join df_customer c on r.branch_no = c.branch_no and r.shopping_card = c.shopping_card
    left join df_subsohdr s on r.branch_no = s.branch_no and r.shopping_card = s.shopping_card and r.order_no = s.order_no
    left join PK_PackingNo p on s.RecNo = p.SubSohdrRecNo and s.branch_no = p.BranchNo
    left join df_sohdr_ext e on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
    and e.Code = 'OrderType'
    left join df_sohdr_ext q on r.branch_no = q.branch_no and r.shopping_card = q.shopping_card and r.order_no = q.order_no
    and q.Code = 'PickingCheck'
    left join df_sohdr_ext x on r.branch_no = x.branch_no and r.shopping_card = x.shopping_card and r.order_no = x.order_no
    and x.Code = 'Channel'
    left join df_sohdr_ext o on r.branch_no = o.branch_no and r.shopping_card = o.shopping_card and r.order_no = o.order_no
    and o.Code = 'Site'
    left join df_sohdr_ext f on r.branch_no = f.branch_no and r.shopping_card = f.shopping_card and r.order_no = f.order_no
    and f.Code = 'FlightType'
    left join df_sohdr_ext v on r.branch_no = v.branch_no and r.shopping_card = v.shopping_card and r.order_no = v.order_no
    and v.Code = 'PackAtWH'
    left join df_sohdr_ext b on r.branch_no = b.branch_no and r.shopping_card = b.shopping_card and r.order_no = b.order_no
    and b.Code = 'LastStatusKPD' ";

                rawSql += " WHERE r.branch_no = '" + branchNo + "' AND isnull(x.Value,'')<>'MKT' ";

                string[] listStatus = { "ALL", "UNSEND STO", "SEND STO", "FAILED STO", "CANCELED", "UNSAVE" };

                #region Comment
                /*
                var listLinq = (from r in _context1.DfSohdr
                                join c in _context1.DfCustomer on new { r.BranchNo, r.ShoppingCard } equals
                                   new { c.BranchNo, c.ShoppingCard }
                                join s in _context1.DfSubsohdr on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { s.BranchNo, s.ShoppingCard, s.OrderNo } into rs
                                from srs in rs.DefaultIfEmpty()
                                join p in _context1.PkPackingNo on new { SubSohdrRecNo = srs.RecNo, srs.BranchNo } equals new { p.SubSohdrRecNo, p.BranchNo } into ps
                                from sps in ps.DefaultIfEmpty()
                                join e in _context1.DfSohdrExt.Where(a => a.Code == "OrderType") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { e.BranchNo, e.ShoppingCard, e.OrderNo } into xy
                                from sxy in xy.DefaultIfEmpty()
                                join q in _context1.DfSohdrExt.Where(a => a.Code == "PickingCheck") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { q.BranchNo, q.ShoppingCard, q.OrderNo } into yz
                                from syz in yz.DefaultIfEmpty()
                                join x in _context1.DfSohdrExt.Where(a => a.Code == "Channel") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { x.BranchNo, x.ShoppingCard, x.OrderNo } into xx
                                from xzx in xx.DefaultIfEmpty()
                                join o in _context1.DfSohdrExt.Where(a => a.Code == "Site") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { o.BranchNo, o.ShoppingCard, o.OrderNo } into ox
                                from oxo in ox.DefaultIfEmpty()
                                join f in _context.DfSohdrExt.Where(a => a.Code == "FlightType") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { f.BranchNo, f.ShoppingCard, f.OrderNo } into fx
                                from fxf in fx.DefaultIfEmpty()
                                join v in _context.DfSohdrExt.Where(a => a.Code == "PackAtWH") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { v.BranchNo, v.ShoppingCard, v.OrderNo } into vx
                                from vxv in vx.DefaultIfEmpty()
                                    //join z in _context1.DfSohdrExt.Where(a => a.Code == "ReceiveOrderNo" || a.Code == "RefOrderNo") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                    //new { z.BranchNo, z.ShoppingCard, z.OrderNo } into zz
                                    //from szz in zz.DefaultIfEmpty()
                                where
                                r.BranchNo == branchNo
                                //&& (r.OrderDate.Date == currentDate.Date && r.OrderDate.Date == currentDate.Date)
                                //&& r.OrderDate.Date == currentDate.Date
                                //&& (r.UpdateDatetime.TimeOfDay >= t1 && r.UpdateDatetime.TimeOfDay <= t2)
                                && r.OrderStatus == "E"
                                && (xzx.Value != "MKT")
                                //&& r.FlightCode == flightCode
                                //&& r.FlightDate.Value >= request.flightFrom.Value
                                //&& r.FlightDate.Value <= request.flightTo.Value
                                orderby r.UpdateDatetime ascending
                                select new KPDModel
                                {
                                    branchNo = r.BranchNo,
                                    orderStatus = r.OrderStatus,
                                    customerName = c.CustName.Trim(),
                                    orderNo = r.OrderNo,
                                    orderDate = r.OrderDate,
                                    packingNo = sps.PackingNo == null || sps.PackingNo == "" ? "" : sps.PackingNo.Trim(), //p.PackingNo.Trim(),
                                    passportNo = c.PassportNo.Trim(),
                                    shoppingCard = r.ShoppingCard,
                                    flight = r.FlightCode.Trim(),
                                    flightDateTime = r.FlightDate.Value.Date + " " + r.FlightTime,
                                    remark = "",
                                    isChanged = false,
                                    orderType = sxy.Value == "" || sxy.Value == null ? "N" : sxy.Value,
                                    updateDatetime = r.UpdateDatetime,
                                    pickingCheck = syz.Value == "" || syz.Value == null ? "" : syz.Value,
                                    airlineCode = r.AirlineCode.Trim(),
                                    flightCode = r.AirlineCode.Trim() + r.FlightCode.Trim(),
                                    flightDate = r.FlightDate.Value.Date,
                                    flightTime = r.FlightTime,
                                    customerType = r.CustTypeCode.Trim(),
                                    nationCode = c.CountryCode.Trim(),
                                    flightType = fxf.Value == "" || fxf.Value == null ? "" : fxf.Value,
                                    posID = r.Posid,
                                    machineNo = r.CashierMac,
                                    operatorCode = oxo.Value == "" || oxo.Value == null ? "" : oxo.Value,
                                    pickupCode = srs.PickupCode,
                                    refNo = srs.ClaimcheckNo,
                                    transDT = srs.AddDatetime,
                                    userAdd = srs.UserAdd,
                                    isPackAtWH = vxv.Value == "" || vxv.Value == null ? "false" : vxv.Value
                                });
                */
                #endregion
                if (filterStatus != "ALL" && filterStatus != "") // ALL,SAVED,UNSAVE,O/S <-- Edit on 19/05/2021
                {
                    //2021-05-21
                    //Modify with Comment When Search True 
                    //if (isSave.ToUpper() == "TRUE")
                    //{
                    //    listLinq = listLinq.Where(a => a.pickingCheck != "");
                    //}
                    //else if (isSave.ToUpper() == "FALSE")
                    //{
                    //    listLinq = listLinq.Where(a => a.pickingCheck == "");
                    //}
                    //2022-02-18

                    if (filterStatus != "UNSEND STO" && filterStatus != "SEND STO" && filterStatus != "FAILED STO" && filterStatus != "CANCELED")
                    {
                        if (filterStatus.ToUpper() == "UNSAVE" || filterStatus.ToUpper() == "FALSE") // <-- Change False to UNSAVE  on 19/05/2021
                        {
                            //listLinq = listLinq.Where(a => a.pickingCheck == "");
                            rawSql += " AND isnull(q.Value,'')='' ";
                        }
                        else
                        {
                            //listLinq = listLinq.Where(a => a.pickingCheck != "");
                            rawSql += " AND isnull(q.Value,'')!=''";
                        }
                    }

                }

                if (orderStatus != "")
                {
                    //listLinq = listLinq.Where(a => a.orderStatus == orderStatus);
                    rawSql += " AND r.order_status='" + orderStatus + "' ";
                }
                else if (filterStatus == "ALL")
                {
                    rawSql += " AND r.order_status in ('E','V') ";
                }
                else if (filterStatus == "CANCELED")
                {
                    rawSql += " AND r.order_status in ('V') ";
                }
                else
                {
                    rawSql += " AND r.order_status='E' ";
                }

                if (shoppingCard != "")
                {
                    //listLinq = listLinq.Where(a => a.shoppingCard == shoppingCard);
                    rawSql += " AND r.shopping_card='" + shoppingCard + "' ";
                    isShoppingcard = true;
                }

                if (orderNo > 0)
                {
                    //listLinq = listLinq.Where(a => a.orderNo == orderNo);
                    rawSql += " AND r.order_no=" + orderNo + " ";
                }

                if (flightCode != "")
                {
                    //listLinq = listLinq.Where(a => a.flightCode == flightCode);
                    rawSql += " AND LTRIM(RTRIM(r.airline_code)) + LTRIM(RTRIM(r.flight_code)) = '" + flightCode + "' ";
                }

                //if (isCheckMachine)
                //{
                //    if (isOrder)
                //    {
                //        //    listLinq = listLinq.Where(a => a.isPackAtWH.ToLower() == "true");
                //        rawSql += " AND LOWER(isnull(v.Value,'false')) ='true'";
                //    }
                //    else
                //    {
                //        //listLinq = listLinq.Where(a => a.isPackAtWH.ToLower() == "false");
                //        rawSql += " AND LOWER(isnull(v.Value,'false')) ='false'";
                //    }
                //}

                if (request.flightFrom != null && request.flightTo != null)
                {
                    //listLinq = listLinq.Where(a => a.flightDate.Date >= request.flightFrom.Value.Date && a.flightDate.Date <= request.flightTo.Value.Date).ToList();
                    rawSql += "  AND ((r.flight_date+' '+r.flight_time>='" + request.flightFrom.Value.ToString("yyyy-MM-dd HH:mm") + "' and r.flight_date +' '+r.flight_time<='" + request.flightTo.Value.ToString("yyyy-MM-dd HH:mm") + "'))";
                }




                var listLinq = _context1.Set<NewKPDModel>().FromSql(rawSql).ToList();



                if (request.orderType != null && request.orderType.Count() > 0)
                {
                    listLinq = listLinq.Where(a => request.orderType.Contains(a.orderType)).ToList();
                }



                //var constrVS = "";
                //var getDbVS = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "VS" &&
                //a.SubBranch == subBranch).FirstOrDefault();

                //if (getDbVS != null)
                //{
                //    var server = StringBL.StringNullToEmpty(getDbVS.DbServer);
                //    var database = StringBL.StringNullToEmpty(getDbVS.DbName);
                //    var user = StringBL.StringNullToEmpty(getDbVS.DbUser);
                //    var password = StringBL.StringNullToEmpty(getDbVS.DbPass);
                //    constrVS = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                //                            server, database, user, password);
                //}
                //else
                //{
                //    ret.SetMessage("Ex-Data", "Invalid Input Please check Branch & Sub Branch !.");
                //    return ret;
                //}


                //var optionBuilderVS = new DbContextOptionsBuilder<KPVirtualStockContext>();
                //optionBuilderVS.UseSqlServer(constrVS);
                //var _vscontext1 = new KPVirtualStockContext(optionBuilderVS.Options);


                //var listStock = _vscontext1.VstRemainAlls.Where(a => a.date == currentDate.Date && a.site != "4600").ToList();


                //var getCate = _context1.ConfigPos.Where(a => a.ConfigCode == "Pack_CateChecker").Select(a => a.ConfigData).FirstOrDefault();

                //List<string> lstCate = new List<string>();
                //if (getCate != null && getCate != "")
                //{
                //    var split = getCate.Split(',');
                //    foreach (var sp in split)
                //    {
                //        lstCate.Add(sp);
                //    }
                //}

                var lstData = listLinq.ToList();

                if (lstData.Count() > 0)
                {
                    //if (getSite != "")
                    //{
                    //    lstData = lstData.Where(a => a.operatorCode.Contains(getSite)).ToList();
                    //}



                    if (lstsite.Count() > 0)
                    {
                        //lstData = lstData.Where(a => lstsite.Contains(a.operatorCode)).ToList();
                        lstData = lstData.Where(a => lstsite.Any(f => a.operatorCode.StartsWith(f))).ToList();
                    }

                    if (lstData.Count() == 0)
                    {
                        ret.isCompleted = true;
                        return ret;
                    }

                    if (lstData.Count() > 0)
                    {
                        if (isCheckMachine)
                        {
                            if (isOrder)
                            {
                                lstData = lstData.Where(a => a.isPackAtWH == "true").ToList();
                            }
                            else
                            {
                                lstData = lstData.Where(a => a.isPackAtWH == "false").ToList();
                            }

                            if (lstData.Count() == 0)
                            {
                                if (isShoppingcard)
                                {
                                    ret.SetMessage("Ex-Data", "Found Data but Machine Setting Shop or WH is wrong");
                                }
                                ret.isCompleted = true;
                                return ret;
                            }
                        }
                    }
                }

                var lstModel = new List<KPDModel>();
                foreach (var detail in lstData)
                {
                    var model = new KPDModel()
                    {
                        branchNo = detail.branchNo,
                        shoppingCard = detail.shoppingCard,
                        orderNo = detail.orderNo,
                        orderDate = detail.orderDate,
                        packingNo = detail.packingNo.Trim(),
                        passportNo = detail.passportNo.Trim(),
                        customerName = detail.customerName.Trim(),
                        flight = detail.flight.Trim(),
                        flightDateTime = detail.flightDateTime,
                        qty = 0,
                        total = 0,
                        lstSohist = new List<listProduct>(),
                        updateDatetime = detail.updateDatetime,
                        userUpdate = "",
                        remark = detail.remark,
                        shipAddress = "",
                        orderType = detail.orderType,
                        orderStatus = detail.orderStatus,
                        isPicking = orderStatus == "E" ? true : false,
                        isSaveStock = detail.pickingCheck != "" ? true : false,
                        pickingCheck = detail.pickingCheck,
                        lastStatusKpd = detail.lastStatusKpd,
                        refOrder = "",
                        isOutOfStock = "",
                        isSendSTO = false,
                        customerType = detail.customerType,
                        airlineCode = detail.airlineCode,
                        flightCode = detail.flightCode,
                        flightDate = detail.flightDate,
                        flightTime = detail.flightTime,
                        nationCode = detail.nationCode.Trim(),
                        flightType = detail.flightType.Trim(),
                        flightNo = detail.flight,
                        pickupCode = StringBL.StringNullToEmpty(detail.pickupCode), //detail.pickupCode.Trim(),
                        operatorCode = detail.operatorCode.Trim(),
                        machineNo = detail.machineNo.Trim(),
                        posID = detail.posID.Trim(),
                        transType = detail.orderType == "D" || detail.orderType == "P" ? "2001" : "",
                        refNo = StringBL.StringNullToEmpty(detail.refNo),//detail.refNo.Trim(),
                        transDT = detail.transDT,// detail.transDT.Value,
                        userAdd = StringBL.StringNullToEmpty(detail.userAdd),//detail.userAdd.Trim(),
                        isPackAtWH = detail.isPackAtWH
                    };



                    if (model.pickingCheck != "" && model.isSaveStock)
                    {
                        var deserialize = JsonConvert.DeserializeObject<lstStock>(model.pickingCheck);
                        if (deserialize.isOutofStock)
                        {
                            model.isOutOfStock = "YES";
                        }
                        else
                        {
                            model.isOutOfStock = "NO";
                        }
                    }

                    var getMobile = _context1.DfCustomerAttr.Where(a => a.BranchNo == detail.branchNo && a.ShoppingCard == detail.shoppingCard && a.Attribute == "MOBILE").Select(a => a.ValueString).FirstOrDefault();
                    if (getMobile != null)
                    {
                        model.mobileNo = StringBL.StringNullToEmpty(getMobile);
                    }

                    //add Cause Search With With out of Stock // 2021-05-12
                    //ALL Record = No Filter
                    //SAVE = ISSAVE No Filter
                    //UNSAVE = Vaidate From Above
                    //O/S = 
                    if (filterStatus.ToUpper() == "O/S" && model.isOutOfStock == "NO")
                    {
                        continue;
                    }

                    if (filterStatus.ToUpper() == "SAVED" && model.isOutOfStock == "YES")
                    {
                        continue;
                    }


                    var chkSendSCO = _context1.SAPTransferOrders.Where(a => a.branch_no == detail.branchNo && a.shopping_card == detail.shoppingCard && a.order_no == detail.orderNo).FirstOrDefault();
                    if (chkSendSCO != null)
                    {
                        model.SAPStatus = false;
                        //model.isSendSTO = true;
                        model.hangingNo = chkSendSCO.HangingNo.Trim();

                        if (chkSendSCO.hang_rs_status == "OK")
                        {
                            model.isSendSTO = true;
                        }

                        if (!isOrder && chkSendSCO.hang_rs_status == "OK")
                        {
                            model.SAPStatus = true;
                        }
                        else if (isOrder && chkSendSCO.sap_status.Trim().ToUpper() == "S" && chkSendSCO.hang_rs_status == "OK")
                        {
                            model.SAPStatus = true;
                        }

                    }


                    model.lstPayment = new List<paymentKPD>();

                    //var lstPayment = _context1.DfPayment.Where(a => a.BranchNo == detail.branchNo && a.ShoppingCard == detail.shoppingCard && a.OrderNo == detail.orderNo)
                    //    .Select(b => new paymentKPD
                    //    {
                    //        bahtAmount = b.Amount,
                    //        lineNo = b.LineNo,
                    //        currentAmount = b.AmountCurr,
                    //        currenyCode = b.CurrCode.Trim(),
                    //        paymentCode = b.MethodCode.Trim(),
                    //        paymentDT = b.PaymentDate,
                    //        currenyRate = b.CurrRate,
                    //        paymentShort = "",
                    //        paymentName = "",
                    //        creditCardNo = ""
                    //    }).ToList();



                    var lstPayment = (from p in _context1.DfSubpayment
                                      join m in _context1.DfPaymeth on p.MethodCode equals m.MethodCode
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard && p.OrderNo == detail.orderNo
                                      select new paymentKPD
                                      {
                                          bahtAmount = p.Amount,
                                          creditCardNo = p.CredCardNo.Trim(),
                                          currentAmount = p.Amount,
                                          currencyCode = "THB",
                                          currencyRate = 1.0M,
                                          lineNo = p.LineNo,
                                          paymentCode = p.MethodCode.Trim(),
                                          paymentDT = p.PaymentDate,
                                          paymentName = m.MethodDesc.Trim(),
                                          paymentShort = m.MethodShort.Trim(),
                                          suborderType = p.SuborderType.Trim()
                                      }).ToList();


                    if (lstPayment.Count() > 0)
                    {
                        model.lstPayment = lstPayment;
                    }

                    List<listProduct> lstsohist = new List<listProduct>();



                    var getMaterial = _context1.DfSohist.Where(a => a.BranchNo == detail.branchNo && a.ShoppingCard == detail.shoppingCard
                    && a.OrderNo == detail.orderNo && a.LineCancel == false).OrderBy(a => a.LineNo).Select(a => a.MatCode).FirstOrDefault();

                    if (getMaterial == null || getMaterial == "")
                    {
                        continue;
                    }

                    var checkCate = _context1.vArticleMC.Where(a => a.ArticleCode == getMaterial).Select(a => a.CateCode).FirstOrDefault();
                    if (checkCate == null && checkCate == "")
                    {
                        continue;
                    }

                    //if (lstCate.Count() > 0 && !lstCate.Contains(checkCate))
                    //{
                    //    continue;
                    //}


                    var lstProduct = (from p in _context1.DfSohist
                                      join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                                      join q in _context1.DfSubsohdr on new { p.BranchNo, p.ShoppingCard, p.OrderNo, p.SuborderType } equals new { q.BranchNo, q.ShoppingCard, q.OrderNo, q.SuborderType }
                                      join x in _context1.PkPackingNo on new { q.BranchNo, q.RecNo } equals new { x.BranchNo, RecNo = x.SubSohdrRecNo }
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
                                      && p.OrderNo == detail.orderNo && p.LineCancel == false
                                      orderby p.LineNo
                                      select new listProduct
                                      {
                                          articleCode = p.MatCode,
                                          articleName = v.ArticleName,
                                          barcode = p.ItemCode,
                                          discount = p.Discount,
                                          discrate = p.DiscRate,
                                          line_No = p.LineNo,
                                          net = p.Net,
                                          price = p.SellingPrice,
                                          amount = p.Amount,
                                          qty = p.Quantity,
                                          mccode = v.MCCode,
                                          brandCode = v.BrandCode,
                                          cateCode = v.CateCode,
                                          EaUnit = v.Unit,
                                          vatRate = p.VatRate,
                                          vatAmount = p.Vat,
                                          taxAmount = 0,
                                          subOrderType = p.SuborderType,
                                          taxabbNo = q.TaxabbNo,
                                          pickupCode = q.PickupCode,
                                          operatorCode = "",
                                          claimCheck = q.ClaimcheckNo,
                                          hangingType = "",
                                          packingNo = x.PackingNo
                                      }).ToList();

                    if (lstProduct.Count() == 0)
                    {
                        continue;
                    }

                    var sumProduct = new List<listProduct>();
                    foreach (var prd in lstProduct)
                    {
                        var chkSum = sumProduct.Where(a => a.articleCode == prd.articleCode).FirstOrDefault();
                        if (chkSum == null)
                        {
                            sumProduct.Add(new listProduct()
                            {
                                articleCode = prd.articleCode,
                                articleName = prd.articleName,
                                barcode = prd.barcode,
                                qty = prd.qty,
                                mccode = prd.mccode,
                                brandCode = prd.brandCode,
                                price = prd.price,
                                discount = prd.discount,
                                taxabbNo = prd.taxabbNo.Trim(),
                                subOrderType = prd.subOrderType.Trim(),
                                amount = prd.amount,
                                net = prd.net,
                                packingNo = prd.packingNo,
                                EaUnit = prd.EaUnit
                            });
                        }
                        else
                        {
                            chkSum.qty = chkSum.qty + prd.qty;
                        }
                    }


                    foreach (var prd in sumProduct)
                    {

                        var articleCode = "";
                        prd.articleCode = StringBL.StringNullToEmpty(prd.articleCode);
                        //var checkBluePaid = _vscontext1.VstArticleDutyPaidRemain.Where(a => a.ArticleCodeDutyPaid == prd.articleCode).FirstOrDefault();
                        //if (checkBluePaid == null)
                        //{
                        //    articleCode = prd.articleCode;
                        //}
                        //else
                        //{
                        //    articleCode = checkBluePaid.ArticleCode;
                        //}
                        var remark = "";

                        //var findStockSAP = listStock.Where(a => a.article_code == articleCode).Select(a => a.qty).FirstOrDefault();
                        //if (findStockSAP <= 0)
                        //{
                        //    remark = "Out of Stock (o/t)";
                        //}
                        //else
                        //{
                        //    if (findStockSAP - prd.qty >= 0)
                        //    {
                        //        prd.qtyVS = findStockSAP;
                        //        foreach (var dat in listStock.Where(a => a.article_code == articleCode))
                        //        {
                        //            dat.qty = dat.qty - prd.qty;
                        //        }
                        //    }
                        //    else if (findStockSAP - prd.qty < 0)
                        //    {
                        //        prd.qtyVS = findStockSAP;
                        //        remark = "Out of Stock (o/t) ";
                        //        foreach (var dat in listStock.Where(a => a.article_code == articleCode))
                        //        {
                        //            dat.qty = 0;
                        //        }
                        //    }
                        //}

                        listProduct data = new listProduct()
                        {
                            articleCode = prd.articleCode.Trim(),
                            articleName = prd.articleName.Trim(),
                            barcode = prd.barcode.Trim(),
                            discount = prd.discount,
                            discrate = prd.discrate,
                            line_No = prd.line_No,
                            net = prd.net,
                            price = prd.price,
                            amount = prd.amount,
                            claimCheck = prd.claimCheck,
                            packingNo = prd.packingNo,
                            subOrderType = prd.subOrderType,
                            taxabbNo = prd.taxabbNo,
                            qty = prd.qty,
                            remark = remark,
                            qtyVS = prd.qty,
                            EaUnit = prd.EaUnit
                        };
                        lstsohist.Add(data);
                    }
                    model.lstSohist = lstsohist;
                    if (model.lstSohist.Count(a => a.remark == "") > 0)
                    {
                        model.isScan = true;
                    }
                    lstModel.Add(model);
                }

                if (filterStatus.ToUpper() == "SEND STO")
                {
                    lstModel = lstModel.Where(a => a.isSendSTO == true).ToList();
                }
                else if (filterStatus.ToUpper() == "UNSEND STO")
                {
                    lstModel = lstModel.Where(a => a.isSendSTO == false).ToList();
                }

                if (filterStatus.ToUpper() == "FAILED STO")
                {
                    if (isOrder)
                    {
                        lstModel = lstModel.Where(a => a.SAPStatus == false && a.isSendSTO == true).ToList();
                    }
                }

                ret.Data = lstModel;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage("Exception", ex.Message);
            }
            return ret;
        }


        public async Task<ReturnObject<List<DataModel>>> SearchStock(SearchOrderInfoModel request)
        {
            ReturnObject<List<DataModel>> ret = new ReturnObject<List<DataModel>>();

            try
            {
                var branchNo = KP.Common.Helper.StringBL.StringNullToEmpty(request.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("WR001", "BranchNo is Required!");
                    return ret;
                }


                var timeCode = StringBL.StringNullToEmpty(request.timecode);
                if (timeCode == "")
                {
                    ret.SetMessage("WR002", "TimeCode is Required!.");
                }

                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(request.subBranch);

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
                    ret.SetMessage("Ex-Master", "No found Connection pos on Config!.");
                    return ret;
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var orderNo = 0;

                var customerName = StringBL.StringNullToEmpty(request.customerName);

                var packingNo = StringBL.StringNullToEmpty(request.packNo);

                var passportNo = StringBL.StringNullToEmpty(request.passport);

                var shoppingCard = StringBL.StringNullToEmpty(request.shoppingCard);

                var isCheckTime = true;
                var isCheckPack = false;

                var splitStr = request.shoppingCard.Split("|");
                if (splitStr.Count() > 1)
                {
                    shoppingCard = splitStr[1];
                    orderNo = Convert.ToInt32(splitStr[2]);
                    isCheckTime = false;
                }

                if (request.shoppingCard.Length == 10)
                {
                    isCheckPack = true;
                }

                var orderStatus = StringBL.StringNullToEmpty(request.orderStatus);

                var filterStatus = StringBL.StringNullToEmpty(request.status);

                timeCode = timeCode.ToLower();
                var nowDate = DateTime.Now;
                TimeSpan t1 = new TimeSpan(), t2 = new TimeSpan();

                var currentDate = nowDate;

                if (isCheckTime)
                {
                    var getDataTime = _context1.VstTimeStock.Where(a => a.timeCode == timeCode).FirstOrDefault();
                    if (getDataTime == null)
                    {
                        ret.SetMessage("WR003", "Invalid Time Code");
                        return ret;
                    }

                    var timeFrom = getDataTime.timeFrom;
                    var timeTo = getDataTime.timeTo;
                    t1 = new TimeSpan(Convert.ToInt32(timeFrom.Split(':')[0]), Convert.ToInt32(timeFrom.Split(':')[1]), 00);
                    t2 = new TimeSpan(Convert.ToInt32(timeTo.Split(':')[0]), Convert.ToInt32(timeTo.Split(':')[1]), 00);

                    // new DateTime().AddDays(Convert.ToDouble(getDataTime.datediff));

                    currentDate = nowDate.AddDays(getDataTime.datediff);
                }

                //                string sql = @"select r. from df_sohdr r 
                //inner join df_customer c on r.branch_no = c.branch_no and r.shopping_card = c.shopping_card
                //left join df_subsohdr s on r.branch_no = s.branch_no and r.shopping_card = s.shopping_card and r.order_no = s.order_no
                //left join PK_PackingNo p on s.RecNo = p.SubSohdrRecNo and s.branch_no = p.BranchNo
                //left join df_sohdr_ext e  on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
                //and e.Code = 'OrderType'
                //left join df_sohdr_ext q on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
                //and q.Code = 'PickingCheck'
                //where r.branch_no = {0};";

                //                if()

                //sql = string.Format(sql, branchNo);

                //var listLinqs = _context1.OrderModels.FromSql(sql).ToList();


                var rawSql = @"select 
        r.branch_no as BranchNo,
        r.order_status as orderStatus,
        LTRIM(RTRIM(c.cust_name)) as customerName,
        r.order_no as orderNo,
        r.order_date as orderDate,
        CASE 
            WHEN p.PackingNo is null or p.PackingNo='' then ''
            else LTRIM(RTRIM(p.PackingNo)) end as packingNo,
        LTRIM(RTRIM(c.passport_no)) as passportNo,
        r.shopping_card as shoppingCard,
        LTRIM(RTRIM(r.flight_code)) as flight,
        FORMAT(r.flight_date, 'dd/MM/yyyy') + ' ' + LTRIM(RTRIM(r.flight_time)) as flightDateTime,
        '' as remark,
        CASE 
            WHEN e.Value is null or e.Value = '' then ''
            else e.Value end as orderType,
        r.update_datetime as updateDatetime,
        CASE 
            WHEN q.Value is null or q.Value = '' then ''
            else q.Value end as pickingCheck,
        LTRIM(RTRIM(r.airline_code)) as airlineCode,
        LTRIM(RTRIM(r.airline_code)) + LTRIM(RTRIM(r.flight_code)) as flightCode,
        r.flight_date as flightDate,
        r.flight_time as flightTime,
        LTRIM(RTRIM(r.cust_type_code)) as customerType,
        LTRIM(RTRIM(c.country_code)) as nationCode,
        r.Posid as posID,
        r.cashier_mac as machineNo,
        s.pickup_code as pickupCode,
        s.claimcheck_no as refNo,
        s.add_datetime as transDT,
        s.user_add as userAdd,
        Convert(bit,0) as isChanged,
        Convert(bit,0) as isDisPatch,
        Convert(bit,0) as isPicking,
        Convert(bit,0) as isSaveStock,
        Convert(bit,0) as isScan,
        Convert(bit,0) as isSendSTO,
        cast(0 as decimal(7,2)) as qty,
        cast(0 as decimal(7,2)) as total,
        '' as userUpdate,
        '' as isOutOfStock,
        '' as location,
        '' as shipAddress,
        '' as refOrder,
        '' as lastStatus,
        Convert(bigint,0) as runnoSohdrExt,
        getDate() as dateTimeUpdate,
        '' as machine
     from df_sohdr r
    inner
     join df_customer c on r.branch_no = c.branch_no and r.shopping_card = c.shopping_card
    left join df_subsohdr s on r.branch_no = s.branch_no and r.shopping_card = s.shopping_card and r.order_no = s.order_no
    left join PK_PackingNo p on s.RecNo = p.SubSohdrRecNo and s.branch_no = p.BranchNo
    left join df_sohdr_ext e on r.branch_no = e.branch_no and r.shopping_card = e.shopping_card and r.order_no = e.order_no
    and e.Code = 'OrderType'
    left join df_sohdr_ext q on r.branch_no = q.branch_no and r.shopping_card = q.shopping_card and r.order_no = q.order_no
    and q.Code = 'PickingCheck'
    left join df_sohdr_ext x on r.branch_no = x.branch_no and r.shopping_card = x.shopping_card and r.order_no = x.order_no
    and x.Code = 'Channel'";

                rawSql += " WHERE r.branch_no = '" + branchNo + "' AND r.order_status='E' AND isnull(x.Value,'')<>'MKT' ";

                /*
                var listLinq = (from r in _context1.DfSohdr
                                join c in _context1.DfCustomer on new { r.BranchNo, r.ShoppingCard } equals
                                   new { c.BranchNo, c.ShoppingCard }
                                join s in _context1.DfSubsohdr on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { s.BranchNo, s.ShoppingCard, s.OrderNo } into rs
                                from srs in rs.DefaultIfEmpty()
                                join p in _context1.PkPackingNo on new { SubSohdrRecNo = srs.RecNo, srs.BranchNo } equals new { p.SubSohdrRecNo, p.BranchNo } into ps
                                from sps in ps.DefaultIfEmpty()
                                join e in _context1.DfSohdrExt.Where(a => a.Code == "OrderType") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { e.BranchNo, e.ShoppingCard, e.OrderNo } into xy
                                from sxy in xy.DefaultIfEmpty()
                                join q in _context1.DfSohdrExt.Where(a => a.Code == "PickingCheck") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { q.BranchNo, q.ShoppingCard, q.OrderNo } into yz
                                from syz in yz.DefaultIfEmpty()
                                join x in _context1.DfSohdrExt.Where(a => a.Code == "Channel") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                new { x.BranchNo, x.ShoppingCard, x.OrderNo } into xx
                                from xzx in xx.DefaultIfEmpty()
                                    //join z in _context1.DfSohdrExt.Where(a => a.Code == "ReceiveOrderNo" || a.Code == "RefOrderNo") on new { r.BranchNo, r.ShoppingCard, r.OrderNo } equals
                                    //new { z.BranchNo, z.ShoppingCard, z.OrderNo } into zz
                                    //from szz in zz.DefaultIfEmpty()
                                where
                                r.BranchNo == branchNo
                                //&& (r.OrderDate.Date == currentDate.Date && r.OrderDate.Date == currentDate.Date)
                                //&& r.OrderDate.Date == currentDate.Date
                                //&& (r.UpdateDatetime.TimeOfDay >= t1 && r.UpdateDatetime.TimeOfDay <= t2)
                                && r.OrderStatus == "E"
                                && (xzx.Value != "MKT")
                                orderby r.UpdateDatetime ascending
                                select new OrderModel
                                {
                                    branchNo = r.BranchNo,
                                    orderStatus = r.OrderStatus,
                                    customerName = c.CustName.Trim(),
                                    orderNo = r.OrderNo,
                                    orderDate = r.OrderDate,
                                    packingNo = sps.PackingNo == null || sps.PackingNo == "" ? "" : sps.PackingNo.Trim(), //p.PackingNo.Trim(),
                                    passportNo = c.PassportNo.Trim(),
                                    shoppingCard = r.ShoppingCard,
                                    flight = r.AirlineCode.Trim() + r.FlightCode.Trim(),
                                    flightDateTime = r.FlightDate.Value.Date + " " + r.FlightTime,
                                    remark = "",
                                    isChanged = false,
                                    orderType = sxy.Value == "" || sxy.Value == null ? "N" : sxy.Value,
                                    updateDatetime = r.UpdateDatetime,
                                    pickingCheck = syz.Value == "" || syz.Value == null ? "" : syz.Value
                                });
                                
                */
                if (filterStatus != "ALL" && filterStatus != "") // ALL,SAVED,UNSAVE,O/S <-- Edit on 19/05/2021
                {
                    //2021-05-21
                    //Modify with Comment When Search True 
                    //if (isSave.ToUpper() == "TRUE")
                    //{
                    //    listLinq = listLinq.Where(a => a.pickingCheck != "");
                    //}
                    //else if (isSave.ToUpper() == "FALSE")
                    //{
                    //    listLinq = listLinq.Where(a => a.pickingCheck == "");
                    //}
                    if (filterStatus.ToUpper() == "UNSAVE" || filterStatus.ToUpper() == "FALSE") // <-- Change False to UNSAVE  on 19/05/2021
                    {
                        //     listLinq = listLinq.Where(a => a.pickingCheck == "");
                        rawSql += " AND isnull(q.Value,'') = ''";
                    }
                    else
                    {
                        //     listLinq = listLinq.Where(a => a.pickingCheck != "");
                        rawSql += " AND isnull(q.Value,'') <>'' ";
                    }
                }

                if (orderStatus != "")
                {
                    //listLinq = listLinq.Where(a => a.orderStatus == orderStatus);
                    rawSql += " AND r.order_status='" + orderStatus + "' ";
                }

                if (isCheckPack)
                {
                    //listLinq = listLinq.Where(a => a.packingNo == shoppingCard);
                    rawSql += " AND isnull(LTRIM(RTRIM(p.PackingNo)),'') ='" + shoppingCard + "' ";
                }
                else
                {
                    if (shoppingCard != "")
                    {
                        //listLinq = listLinq.Where(a => a.shoppingCard == shoppingCard);
                        rawSql += " AND r.shopping_card='" + shoppingCard + "' ";
                    }
                }


                if (orderNo > 0)
                {
                    //listLinq = listLinq.Where(a => a.orderNo == orderNo);
                    rawSql += " AND r.order_no=" + orderNo + " ";
                }

                if (isCheckTime)
                {
                    rawSql += " AND r.order_date='" + currentDate.Date.ToString("yyyy-MM-dd") + "' ";
                }

                var listLinq = _context1.Set<OrderModel>().FromSql(rawSql).ToList();

                if (isCheckTime)
                {
                    // a.orderDate.Date == currentDate.Date &&
                    listLinq = listLinq.Where(a => a.updateDatetime.TimeOfDay >= t1 && a.updateDatetime.TimeOfDay <= t2).ToList();
                }

                //listLinq = listLinq.Where(a => a.orderType == "D");
                if (request.orderType != null && request.orderType.Count() > 0)
                {
                    listLinq = listLinq.Where(a => request.orderType.Contains(a.orderType)).ToList();
                }


                //var constrVS = "";
                //var getDbVS = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "VS" &&
                //a.SubBranch == subBranch).FirstOrDefault();

                //if (getDbVS != null)
                //{
                //    var server = StringBL.StringNullToEmpty(getDbVS.DbServer);
                //    var database = StringBL.StringNullToEmpty(getDbVS.DbName);
                //    var user = StringBL.StringNullToEmpty(getDbVS.DbUser);
                //    var password = StringBL.StringNullToEmpty(getDbVS.DbPass);
                //    constrVS = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                //                            server, database, user, password);
                //}
                //else
                //{
                //    ret.SetMessage("Ex-Data", "Invalid Input Please check Branch & Sub Branch !.");
                //    return ret;
                //}


                //var optionBuilderVS = new DbContextOptionsBuilder<KPVirtualStockContext>();
                //optionBuilderVS.UseSqlServer(constrVS);
                //var _vscontext1 = new KPVirtualStockContext(optionBuilderVS.Options);


                //var listStock = _vscontext1.VstRemainAlls.Where(a => a.date == currentDate.Date && a.site != "4600").ToList();


                var getCate = _context1.ConfigPos.Where(a => a.ConfigCode == "Pack_CateChecker").Select(a => a.ConfigData).FirstOrDefault();

                List<string> lstCate = new List<string>();
                if (getCate != null && getCate != "")
                {
                    var split = getCate.Split(',');
                    foreach (var sp in split)
                    {
                        lstCate.Add(sp);
                    }
                }


                var lstData = listLinq.ToList();
                var lstModel = new List<DataModel>();
                foreach (var detail in lstData)
                {
                    var model = new DataModel()
                    {
                        branchNo = detail.branchNo,
                        shoppingCard = detail.shoppingCard,
                        orderNo = detail.orderNo,
                        orderDate = detail.orderDate,
                        packingNo = detail.packingNo.Trim(),
                        passportNo = detail.passportNo.Trim(),
                        customerName = detail.customerName.Trim(),
                        flight = detail.flight.Trim(),
                        flightDateTime = detail.flightDateTime,
                        qty = detail.qty,
                        total = detail.total,
                        lstSohist = new List<listProduct>(),
                        dateTimeUpdate = detail.dateTimeUpdate,
                        userUpdate = detail.userUpdate,
                        remark = detail.remark,
                        shipAddress = detail.shipAddress,
                        orderType = detail.orderType,
                        orderStatus = detail.orderStatus,
                        isPicking = orderStatus == "E" ? true : false,
                        isSaveStock = detail.pickingCheck != "" ? true : false,
                        pickingCheck = detail.pickingCheck,
                        refOrder = "",
                        isOutOfStock = "",
                        isSendSTO = false
                    };

                    if (model.pickingCheck != "" && model.isSaveStock)
                    {
                        var deserialize = JsonConvert.DeserializeObject<lstStock>(model.pickingCheck);
                        if (deserialize.isOutofStock)
                        {
                            model.isOutOfStock = "YES";
                        }
                        else
                        {
                            model.isOutOfStock = "NO";
                        }
                    }

                    //add Cause Search With With out of Stock // 2021-05-12
                    //ALL Record = No Filter
                    //SAVE = ISSAVE No Filter
                    //UNSAVE = Vaidate From Above
                    //O/S = 
                    if (filterStatus.ToUpper() == "O/S" && model.isOutOfStock == "NO")
                    {
                        continue;
                    }

                    if (filterStatus.ToUpper() == "SAVED" && model.isOutOfStock == "YES")
                    {
                        continue;
                    }


                    //var chkSendSCO = _context1.SAPTransferOrders.Where(a => a.branch_no == detail.branchNo && a.shopping_card == detail.shoppingCard && a.order_no == detail.orderNo && a.sap_status == "S").FirstOrDefault();
                    //if (chkSendSCO != null)
                    //{
                    //    model.isSendSTO = true;
                    //}


                    List<listProduct> lstsohist = new List<listProduct>();


                    var getMaterial = _context1.DfSohist.Where(a => a.BranchNo == detail.branchNo && a.ShoppingCard == detail.shoppingCard
                    && a.OrderNo == detail.orderNo && a.LineCancel == false).OrderBy(a => a.LineNo).Select(a => a.MatCode).FirstOrDefault();

                    if (getMaterial == null || getMaterial == "")
                    {
                        continue;
                    }

                    var checkCate = _context1.vArticleMC.Where(a => a.ArticleCode == getMaterial).Select(a => a.CateCode).FirstOrDefault();
                    if (checkCate == null && checkCate == "")
                    {
                        continue;
                    }

                    if (lstCate.Count() > 0 && !lstCate.Contains(checkCate))
                    {
                        continue;
                    }


                    var lstProduct = (from p in _context1.DfSohist
                                      join v in _context1.vArticleMC on p.MatCode equals v.ArticleCode
                                      where p.BranchNo == detail.branchNo && p.ShoppingCard == detail.shoppingCard
                                      && p.OrderNo == detail.orderNo && p.LineCancel == false
                                      orderby p.LineNo
                                      select new listProduct
                                      {
                                          articleCode = p.MatCode,
                                          articleName = v.ArticleName,
                                          barcode = p.ItemCode,
                                          discount = p.Discount,
                                          discrate = p.DiscRate,
                                          line_No = p.LineNo,
                                          net = p.Net,
                                          price = p.SellingPrice,
                                          amount = p.Amount,
                                          qty = p.Quantity,
                                          mccode = v.MCCode,
                                          brandCode = v.BrandCode,
                                          cateCode = v.CateCode,
                                          EaUnit = v.Unit,
                                          vatRate = p.VatRate,
                                          vatAmount = p.Vat,
                                          taxAmount = 0
                                      }).ToList();


                    if (lstProduct.Count() == 0)
                    {
                        continue;
                    }

                    var sumProduct = new List<listProduct>();
                    foreach (var prd in lstProduct)
                    {
                        var chkSum = sumProduct.Where(a => a.articleCode == prd.articleCode).FirstOrDefault();
                        if (chkSum == null)
                        {
                            sumProduct.Add(new listProduct()
                            {
                                articleCode = prd.articleCode,
                                articleName = prd.articleName,
                                barcode = prd.barcode,
                                qty = prd.qty,
                                mccode = prd.mccode,
                                brandCode = prd.brandCode,
                                price = prd.price
                            });
                        }
                        else
                        {
                            chkSum.qty = chkSum.qty + prd.qty;
                        }
                    }


                    foreach (var prd in sumProduct)
                    {
                        var remark = "";
                        /*
                         * comment on 2022-02-28
                         * not use check qty sap
                        var articleCode = "";
                        prd.articleCode = StringBL.StringNullToEmpty(prd.articleCode);
                        var checkBluePaid = _vscontext1.VstArticleDutyPaidRemain.Where(a => a.ArticleCodeDutyPaid == prd.articleCode).FirstOrDefault();
                        if (checkBluePaid == null)
                        {
                            articleCode = prd.articleCode;
                        }
                        else
                        {
                            articleCode = checkBluePaid.ArticleCode;
                        }
                        var remark = "";

                        var findStockSAP = listStock.Where(a => a.article_code == articleCode).Select(a => a.qty).FirstOrDefault();
                        if (findStockSAP <= 0)
                        {
                            remark = "Out of Stock (o/t)";
                        }
                        else
                        {
                            if (findStockSAP - prd.qty >= 0)
                            {
                                prd.qtyVS = findStockSAP;
                                foreach (var dat in listStock.Where(a => a.article_code == articleCode))
                                {
                                    dat.qty = dat.qty - prd.qty;
                                }
                            }
                            else if (findStockSAP - prd.qty < 0)
                            {
                                prd.qtyVS = findStockSAP;
                                remark = "Out of Stock (o/t) ";
                                foreach (var dat in listStock.Where(a => a.article_code == articleCode))
                                {
                                    dat.qty = 0;
                                }
                            }
                        }
                        */

                        //var remark = "";
                        //var qty = 0.0m;
                        //var findStockSAP = listStock.Where(a => a.article_code == prd.articleCode).Select(a=>a.qty).FirstOrDefault();
                        //if(findStockSAP==null || findStockSAP <=0)
                        //{
                        //    remark = "Out of Stock (o/t) [No have Qty for this Article] 0/"+prd.qty;
                        //}
                        //else
                        //{
                        //    if(findStockSAP - prd.qty >=0)
                        //    {
                        //        qty = prd.qty;
                        //        foreach(var dat in listStock.Where(a=>a.article_code==prd.articleCode))
                        //        {
                        //            dat.qty = dat.qty - prd.qty;
                        //        }
                        //    }
                        //    else if(findStockSAP - prd.qty <0)
                        //    {
                        //        qty = findStockSAP;
                        //        remark = "Out of Stock (o/t) [" + Math.Abs(findStockSAP - prd.qty) + " / " + prd.qty;
                        //        foreach (var dat in listStock.Where(a => a.article_code == prd.articleCode))
                        //        {
                        //            dat.qty = 0;
                        //        }
                        //    }
                        //}

                        listProduct data = new listProduct()
                        {
                            articleCode = prd.articleCode.Trim(),
                            articleName = prd.articleName.Trim(),
                            barcode = prd.barcode.Trim(),
                            discount = prd.discount,
                            discrate = prd.discrate,
                            line_No = prd.line_No,
                            net = prd.net,
                            price = prd.price,
                            amount = prd.amount,
                            claimCheck = prd.claimCheck,
                            packingNo = prd.packingNo,
                            subOrderType = prd.subOrderType,
                            taxabbNo = prd.taxabbNo,
                            qty = prd.qty,
                            remark = remark,
                            qtyVS = prd.qtyVS
                        };
                        lstsohist.Add(data);
                    }
                    model.lstSohist = lstsohist;
                    if (model.lstSohist.Count(a => a.remark == "") > 0)
                    {
                        model.isScan = true;
                    }
                    lstModel.Add(model);
                }
                ret.Data = lstModel;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage("Exception", ex.Message);
            }
            return ret;
        }


        public async Task<ReturnObject<bool>> updateLastStatus(ParamUpdateOrder param)
        {
            ReturnObject<bool> ret = new ReturnObject<bool>();
            try
            {
                var subBranchCode = StringBL.StringNullToEmpty(param.subBranch);

                var getConPos = getConnectionPOS(subBranchCode);
                if (getConPos.Message.Count() > 0)
                {
                    ret.Message.AddRange(getConPos.Message);
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(getConPos.Data);
                var _contextPOS = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                if (param.user == null || StringBL.StringNullToEmpty(param.user.userID) == "")
                {
                    ret.SetMessage("Ex-Data", "Input User is Required!.");
                    return ret;
                }

                using (var dbContext = _contextPOS.Database.BeginTransaction())
                {

                    var dateNow = _contextPOS.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();

                    foreach (var detail in param.lstUpdateOrder)
                    {

                        var branchNo = StringBL.StringNullToEmpty(detail.BranchNo);
                        var shopCard = StringBL.StringNullToEmpty(detail.ShoppingCard);
                        var orderno = detail.orderNo;
                        var code = StringBL.StringNullToEmpty(detail.Code);
                        var value = StringBL.StringNullToEmpty(detail.Value);


                        long runno = 0;
                        var findData = _contextPOS.DfSohdrExt.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shopCard &&
                        a.OrderNo == orderno && a.Code == code).FirstOrDefault();

                        if (findData != null)
                        {
                            findData.Value = value;
                            runno = findData.runno;
                        }
                        else
                        {
                            var inst = _contextPOS.DfSohdrExt.Add(new DfSohdrExt()
                            {
                                BranchNo = branchNo,
                                ShoppingCard = shopCard,
                                OrderNo = orderno,
                                Code = code,
                                Value = value,
                            });

                            _contextPOS.SaveChanges();

                            runno = inst.Entity.runno;
                        }

                        _contextPOS.dfExtendsLog.Add(new DfExtendsLog()
                        {
                            datetime = dateNow.DbDt,
                            runno = runno,
                            tableLog = "df_sohdr_ext",
                            userCode = StringBL.StringNullToEmpty(param.user.userID),
                            valueCode = value,
                        });

                        _contextPOS.SaveChanges();
                    }
                    dbContext.Commit();
                }

                ret.Data = true;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Opertaion", ex.Message);
            }

            return ret;
        }

        public async Task<ReturnObject<bool>> UpdateShipping(lstShippingUpdate lstUpdate)
        {
            ReturnObject<bool> ret = new ReturnObject<bool>();

            try
            {
                var detail = StringBL.StringNullToEmpty(lstUpdate.jsonUpdate);
                var subBranchCode = StringBL.StringNullToEmpty(lstUpdate.subbranchCode);

                var getConPos = getConnectionPOS(subBranchCode);
                if (getConPos.Message.Count() > 0)
                {
                    ret.Message.AddRange(getConPos.Message);
                }

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(getConPos.Data);
                var _contextPOS = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                if (detail != "")
                {

                    var datebaseCustomer = _cusContext.Set<DtServer>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();
                    var databasePos = _contextPOS.Set<Dtserver>().FromSql("select -1 as Id,GETDATE() as Dbdt").First();
                    foreach (var dat in lstUpdate.lstDetail)
                    {
                        var sessionId = dat.branchNo + dat.shoppingCard + dat.orderNo;
                        var updateTrans = _cusContext.CUSD_ShippingTrans.Where(a => a.transSessionID == sessionId).FirstOrDefault();
                        if (updateTrans != null)
                        {
                            var dup = updateTrans;
                            _cusContext.CUSD_ShippingTrans.Add(new DBModel.ShipTrans()
                            {
                                transSessionID = dup.transSessionID + "_EDIT_" + datebaseCustomer.Dbdt.ToString("yyyyMMddHHmm"),
                                transSessionValue = dup.transSessionValue,
                                userModify = StringBL.StringNullToEmpty(dup.userModify),
                                DatetimeUpdate = dup.DatetimeUpdate,
                                addDatetime = datebaseCustomer.Dbdt,
                            });

                            updateTrans.transSessionValue = detail;
                            updateTrans.userModify = lstUpdate.userCode;
                            updateTrans.DatetimeUpdate = datebaseCustomer.Dbdt;
                            updateTrans.addDatetime = datebaseCustomer.Dbdt;
                        }
                        else
                        {
                            _cusContext.CUSD_ShippingTrans.Add(new DBModel.ShipTrans()
                            {
                                transSessionID = sessionId,
                                transSessionValue = detail,
                                userModify = lstUpdate.userCode,
                                DatetimeUpdate = datebaseCustomer.Dbdt,
                                addDatetime = datebaseCustomer.Dbdt
                            });
                        }


                        //
                        var sql = "select branch_no,shopping_card,order_no,Code,Value from df_sohdr_ext where branch_no='" + dat.branchNo + "' and shopping_card='" + dat.shoppingCard + "' and order_no=" + dat.orderNo + " and Code='ShipAddress'";

                        var dataTest = _contextPOS.Set<dfSohdrExtTable>().FromSql(sql).ToList();

                        if (dataTest.Any())
                        {
                            var sqlUpdate = "update df_sohdr_ext set value ={0} where branch_no={1} and shopping_card={2} and order_no={3} and Code='ShipAddress'";

                            _contextPOS.Database.ExecuteSqlCommand(sqlUpdate, detail, dat.branchNo, dat.shoppingCard, dat.orderNo);

                            _contextPOS.LogChangeShipping.Add(new LogChangeShipping()
                            {
                                sessionID = dat.branchNo + dat.shoppingCard + dat.orderNo,
                                sessionValue = detail,
                                userUpdateBy = lstUpdate.userCode,
                                userUpdateDatetime = databasePos.DbDt

                            });
                        }
                        else
                        {
                            _contextPOS.LogChangeShipping.Add(new LogChangeShipping()
                            {
                                sessionID = dat.branchNo + dat.shoppingCard + dat.orderNo,
                                sessionValue = detail,
                                userUpdateBy = lstUpdate.userCode,
                                userUpdateDatetime = databasePos.DbDt
                            });

                            var sqlInsert = " insert into df_sohdr_ext (branch_no,shopping_card,order_no,Code,Value) values ({0},{1},{2},'ShipAddress',{3})";

                            _contextPOS.Database.ExecuteSqlCommand(sqlInsert, dat.branchNo, dat.shoppingCard, dat.orderNo, detail);
                        }

                        //var updateSohdrExt = _contextPOS.DfSohdrExt.Where(a => a.BranchNo == dat.branchNo && a.ShoppingCard == dat.shoppingCard
                        //&& a.OrderNo == dat.orderNo && a.Code == "ShipAddress").FirstOrDefault();
                        //if (updateSohdrExt != null)
                        //{

                        //    _contextPOS.LogChangeShipping.Add(new LogChangeShipping()
                        //    {
                        //        sessionID = dat.branchNo + dat.shoppingCard + dat.orderNo,
                        //        sessionValue = detail,
                        //        userUpdateBy = lstUpdate.userCode,
                        //        userUpdateDatetime = databasePos.DbDt

                        //    });
                        //    updateSohdrExt.Value = detail;
                        //}
                        //else
                        //{

                        //    _contextPOS.LogChangeShipping.Add(new LogChangeShipping()
                        //    {
                        //        sessionID = dat.branchNo + dat.shoppingCard + dat.orderNo,
                        //        sessionValue = detail,
                        //        userUpdateBy = lstUpdate.userCode,
                        //        userUpdateDatetime = databasePos.DbDt
                        //    });


                        //    var sqlInsert = " insert into df_sohdr_ext (branch_no,shopping_card,order_no,Code,Value) values ('" + dat.branchNo + "','" + dat.shoppingCard + "'," + dat.orderNo + ",'ShipAddress','" + detail + "')";

                        //    _contextPOS.Database.ExecuteSqlCommand(sqlInsert);

                        //    //_contextPOS.DfSohdrExt.Add(new DBModel.NewKpiEntity.DfSohdrExt()
                        //    //{
                        //    //    BranchNo = dat.branchNo,
                        //    //    ShoppingCard = dat.shoppingCard,
                        //    //    OrderNo = dat.orderNo,
                        //    //    Code = "ShipAddress",
                        //    //    Value = detail
                        //    //});
                        //}
                        try
                        {
                            _cusContext.SaveChanges();
                            _contextPOS.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            ret.SetMessage("Exception Update/Save", ex.Message);
                        }
                    }
                }
                ret.Data = true;
                ret.isCompleted = true;
            }
            catch (Exception e)
            {
                ret.SetMessage(e);
            }

            return ret;
        }

        public ReturnObject<string> getConnectionPOS(string Subbranch)
        {
            ReturnObject<string> ret = new ReturnObject<string>();
            ret.Data = "";

            var findConPos = _cusContext.DbConnection.Where(a => a.SubBranch == Subbranch && a.DbType == "POS").FirstOrDefault();
            if (findConPos == null)
            {
                ret.SetMessage("Data_Ex", "POS Subbranch : " + Subbranch + " not found!.");
            }
            else
            {
                var server = StringBL.StringNullToEmpty(findConPos.DbServer);
                var database = StringBL.StringNullToEmpty(findConPos.DbName);
                var user = StringBL.StringNullToEmpty(findConPos.DbUser);
                var password = StringBL.StringNullToEmpty(findConPos.DbPass);
                var dbConString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                        server, database, user, password);

                ret.Data = dbConString;
            }

            return ret;
        }

        public async Task<ReturnObject<bool>> SaveStock(saveTrans param)
        {
            ReturnObject<bool> ret = new ReturnObject<bool>();
            ret.Data = false;
            try
            {
                if (param.listStock == null || param.listStock.Count() == 0)
                {
                    ret.SetMessage("Ex_Input", "List Stock is Required!.");
                    return ret;
                }

                var summaryStock = param.listStock.Sum(a => a.qty);
                var summaryCount = param.listStock.Sum(a => a.qtyCount);

                //if (param.isOutofStock && (summaryCount == summaryStock))
                //{
                //    ret.SetMessage("Ex_operation", "Can't Save Out of Stock.Count Stock equals Qty!.");
                //    return ret;
                //}
                //else if (!param.isOutofStock && (summaryStock != summaryCount))
                //{
                //    ret.SetMessage("Ex_operation", "Can't Save Stock.Count Stock not equals Qty!.");
                //    return ret;
                //}

                var branchNo = StringBL.StringNullToEmpty(param.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("Ex_Input", "Branch No is Required.!.");
                    return ret;
                }

                var shoppingCard = StringBL.StringNullToEmpty(param.shoppingCard);
                if (shoppingCard == "")
                {
                    ret.SetMessage("Ex_Input", "Shopping Card is Required!.");
                    return ret;
                }

                if (param.orderNo <= 0)
                {
                    ret.SetMessage("Ex_Input", "Order No is Required!.");
                    return ret;
                }

                if (param.user == null || StringBL.StringNullToEmpty(param.user.userID) == "")
                {
                    ret.SetMessage("Ex_Input", "User is Required!.");
                    return ret;
                }

                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(param.subBranch);

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

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);


                var dateNow = _context1.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();

                //mappingObject 
                lstStock lststock = new lstStock()
                {
                    isOutofStock = param.isOutofStock,
                    listStock = new List<lstStockProduct>()
                };
                lststock.listStock = param.listStock;
                var valustoJson = Newtonsoft.Json.JsonConvert.SerializeObject(lststock);

                var dfsohdrext = _context1.DfSohdrExt.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == param.orderNo && a.Code == "PickingCheck").FirstOrDefault();
                if (dfsohdrext == null)
                {
                    _context1.DfSohdrExt.Add(new DBModel.NewKpiEntity.DfSohdrExt()
                    {
                        BranchNo = branchNo,
                        Code = "PickingCheck",
                        OrderNo = param.orderNo,
                        ShoppingCard = shoppingCard,
                        Value = valustoJson,
                    });
                }
                else
                {
                    dfsohdrext.Value = valustoJson;
                }

                var value = "000";

                if (param.isOutofStock)
                {
                    value = "0001";
                }

                var dfsohdrextt = _context1.DfSohdrExt.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == param.orderNo && a.Code == "LastStatus").FirstOrDefault();
                if (dfsohdrextt == null)
                {
                    dfsohdrextt = new DfSohdrExt()
                    {
                        BranchNo = branchNo,
                        Code = "LastStatus",
                        OrderNo = param.orderNo,
                        ShoppingCard = shoppingCard,
                        Value = value,
                    };
                    _context1.DfSohdrExt.Add(dfsohdrextt);
                    _context1.SaveChanges();
                }
                else
                {
                    if (dfsohdrextt.Value == "000" && param.isOutofStock)
                    {
                        ret.SetMessage("Ex-Operator", "This Stock have Completed.! Can't Change to O/S");
                        return ret;
                    }
                    dfsohdrextt.Value = value;
                }

                _context1.dfExtendsLog.Add(new DfExtendsLog()
                {
                    datetime = dateNow.DbDt,
                    runno = dfsohdrextt.runno,
                    tableLog = "df_sohdr_ext",
                    userCode = StringBL.StringNullToEmpty(param.user.userID),
                    valueCode = value
                });
                _context1.SaveChanges();

                if (param.saveKPD && !param.isOutofStock)
                {
                    // ** Startwith 899 -  ONLY KPC
                    if (shoppingCard.StartsWith("899"))
                    {
                        var isSkipUpdatStatusECom = false;
                        var getEndpointWs = _context1.ConfigPos.Where(a => a.ConfigCode == "eComWSBaseAddress").FirstOrDefault();
                        if (getEndpointWs == null)
                        {
                            ret.SetMessage("Ex-Config", "Endpoint Ws eCom no have config");
                            return ret;
                        }

                        var getConfigUpdateECom = _context1.ConfigPos.Where(a => a.ConfigCode == "isSkipUpdatStatusECom").FirstOrDefault();
                        if (getConfigUpdateECom != null)
                        {
                            isSkipUpdatStatusECom = Convert.ToBoolean(getConfigUpdateECom.ConfigData);
                        }

                        // dfsohdrext มีค่า ไม่ต้องส่งไปอัพเดตซ้ำ ให้ skip 
                        if (dfsohdrext != null)
                        {
                            isSkipUpdatStatusECom = true;
                        }
                        if (!param.isSkipCancelKPD && !isSkipUpdatStatusECom)
                        {

                            var getUserToken = _context1.ConfigPos.Where(a => a.ConfigCode == "ecomWSUserToken").FirstOrDefault();
                            if (getUserToken == null)
                            {
                                ret.SetMessage("Ex-Config", "Token WS eCom no have config");
                            }

                            var getSyncOrder = _context1.ConfigPos.Where(a => a.ConfigCode == "eComWSSyncOrder").FirstOrDefault();

                            var paramWS = new eComSyncParameter()
                            {
                                OrderStatus = "S",
                                OrderNo = shoppingCard.Substring(0, 12),
                                UserToken = getUserToken.ConfigData
                            };


                            var json = Newtonsoft.Json.JsonConvert.SerializeObject(paramWS);
                            var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

                            var url = getEndpointWs.ConfigData + getSyncOrder.ConfigData;
                            using (var client = new HttpClient())
                            {
                                var response = await client.PostAsync(url, data);
                                string result = response.Content.ReadAsStringAsync().Result;

                                //var DeSerial = Newtonsoft.Json.JsonConvert.DeserializeObject<ReturnWsEcom>(result);
                                //if (DeSerial.ErrorOBJ != null)
                                //{
                                //    //ret.SetMessage("WS-Exception", DeSerial.ErrorOBJ.ErrorID + "-" + DeSerial.ErrorOBJ.ErrorMessage);
                                //    //return ret;
                                //}
                            }
                        }
                    }

                    /*
                        Comment for update 2022-07-10
                        
                    */

                    // LastStatusKPD มีค่า ไม่ต้องส่งไปอัพเดตซ้ำ
                    var getOrderStatusKPD = _context1.DfSohdrExt.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == param.orderNo && a.Code == "LastStatusKPD").FirstOrDefault();
                    if (getOrderStatusKPD == null)
                    {
                        var update = new UpdateOrderStatusKPDReq
                        {
                            StatusCode = "003",
                            OnlineOrderNo = shoppingCard,
                            OrderNo = param.orderNo,
                            SubBranch = subBranch,
                            BranchNo = branchNo,
                            UserID = StringBL.StringNullToEmpty(param.user.userID),
                        };

                        var restUpdate = await updateOrderLastStatusKPD(update, _context1);
                        if (!restUpdate.isCompleted)
                        {
                            ret.Message.AddRange(restUpdate.Message);
                            return ret;
                        }
                    }
                }

                ret.Data = true;
                ret.isCompleted = true;

            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        public async Task<ReturnObject<bool>> ChangeFlightPreOrder(ChangeFlightPreOrderInfoModel request)
        {
            ReturnObject<bool> ret = new ReturnObject<bool>();

            try
            {

                var airlineCode = StringBL.StringNullToEmpty(request.airlineCode);
                if (airlineCode == "")
                {
                    ret.SetMessage("WRN_input", "Airline is Required!.");
                    return ret;
                }

                var flightCode = StringBL.StringNullToEmpty(request.flightCode);
                if (flightCode == "")
                {
                    ret.SetMessage("WRN_Input", "Flight Code is Required!.");
                    return ret;
                }

                var flightDateTime = request.flightDateTime;
                if (flightDateTime == null)
                {
                    ret.SetMessage("WRN_Input", "Flight Date Time is Required!.");
                    return ret;
                }
                var userUpdate = StringBL.StringNullToEmpty(request.changeBy);

                var remark = StringBL.StringNullToEmpty(request.remark);

                foreach (var data in request.lstCustomer)
                {
                    //check Parameters
                    var branchNo = StringBL.StringNullToEmpty(data.branchNo);
                    if (branchNo == "")
                    {
                        ret.SetMessage("WRN_Input", "Branch is Required!.");
                        return ret;
                    }

                    var shoppingCard = StringBL.StringNullToEmpty(data.shoppingCard);
                    if (shoppingCard == "")
                    {
                        ret.SetMessage("WRN_Input", "Shopping Card is Required!.");
                        return ret;
                    }

                    if (data.orderNo <= 0)
                    {
                        ret.SetMessage("WRN_Input", "Order No is Required!.");
                        return ret;
                    }

                    var subbranchCode = StringBL.StringNullToEmpty(request.subBranchCode);

                    var constr = "";
                    var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" &&
                    a.SubBranch == subbranchCode && a.IsCancel == false).FirstOrDefault();

                    if (getDb != null)
                    {
                        var server = StringBL.StringNullToEmpty(getDb.DbServer);
                        var database = StringBL.StringNullToEmpty(getDb.DbName);
                        var user = StringBL.StringNullToEmpty(getDb.DbUser);
                        var password = StringBL.StringNullToEmpty(getDb.DbPass);
                        constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                                server, database, user, password);
                    }

                    try
                    {
                        var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                        optionBuilder.UseSqlServer(constr);
                        var _context1 = new KP.OrderGateway.DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                        var checkData = _context1.PreOrderChangeFlight.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard
                        && a.OrderNo == data.orderNo).FirstOrDefault();

                        if (checkData != null)
                        {
                            checkData.AirlineCode = airlineCode;
                            checkData.FlightCode = flightCode;
                            checkData.FlightDt = flightDateTime;
                            checkData.Remark = remark;
                            checkData.UserUpdate = userUpdate;
                            checkData.UpdateDatetime = DateTime.Now;
                        }
                        else
                        {
                            var getDateTime = DateTime.Now.Date;
                            var getOrderDate = _context1.DfSohdr.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == data.orderNo).FirstOrDefault();
                            if (getOrderDate != null)
                            {
                                getDateTime = getOrderDate.OrderDate;
                            }
                            var insert = _context1.PreOrderChangeFlight.Add(new DBModel.NewKpiEntity.PreOrderChangeFlight()
                            {
                                AirlineCode = airlineCode,
                                BranchNo = branchNo,
                                FlightCode = flightCode,
                                FlightDt = flightDateTime,
                                OrderNo = data.orderNo,
                                Remark = remark,
                                ShoppingCard = shoppingCard,
                                UserAdd = userUpdate,
                                AddDatetime = DateTime.Now,
                                UpdateDatetime = DateTime.Now,
                                UserUpdate = userUpdate,
                                OrderDate = getDateTime,
                                OrderStatus = "P"
                            });
                        }
                        _context1.SaveChanges();
                    }
                    catch (Exception)
                    {

                    }
                }

                ret.Data = true;
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        public async Task<ReturnObject<List<OrderSubBranch>>> listSubBranch()
        {
            ReturnObject<List<OrderSubBranch>> ret = new ReturnObject<List<OrderSubBranch>>();

            try
            {
                var data = (from s in _cusContext.CONS_SubBranch
                            where s.isCancel == false
                            select new OrderSubBranch
                            {
                                branchNo = s.branchNo.Trim(),
                                subBranchCode = s.subBranchCode.Trim(),
                                subBranchName = s.subBranchName.Trim()
                            }).ToList();

                ret.Data = data.ToList();
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        //public async Task<ReturnObject<List<string>>> getSite()
        //{

        //}


        public async Task<ReturnObject<string>> getHangingType(ParameterHanging param)
        {
            ReturnObject<string> ret = new ReturnObject<string>();
            ret.Data = "";

            try
            {
                var branchNo = StringBL.StringNullToEmpty(param.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("Ex-Input", "Input Branch No is Required!.");
                    return ret;
                }

                //var subBranch = StringBL.StringNullToEmpty(param.subBranchCode);
                //if (subBranch == "")
                //{
                //    ret.SetMessage("Ex-Input", "Input SubBranch Code is Required!.");
                //    return ret;
                //}

                if (param.orderNo <= 0)
                {
                    ret.SetMessage("Ex-Input", "Input Order No is Required!.");
                    return ret;
                }

                var subOrderType = StringBL.StringNullToEmpty(param.subOrderType);
                if (subOrderType == "")
                {
                    ret.SetMessage("Ex-Input", "Input Sub Order Type is Required!.");
                    return ret;
                }

                var shoppingCard = StringBL.StringNullToEmpty(param.shoppingCard);
                if (shoppingCard == "")
                {
                    ret.SetMessage("Ex-Input", "Input Shopping Card is Required!.");
                    return ret;
                }


                //var constr = "";
                //var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" &&
                //a.SubBranch == subBranch).FirstOrDefault();

                //if (getDb != null)
                //{
                //    var server = StringBL.StringNullToEmpty(getDb.DbServer);
                //    var database = StringBL.StringNullToEmpty(getDb.DbName);
                //    var user = StringBL.StringNullToEmpty(getDb.DbUser);
                //    var password = StringBL.StringNullToEmpty(getDb.DbPass);
                //    constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                //                            server, database, user, password);
                //}
                //else
                //{
                //    ret.SetMessage("Ex-Master", "No found Connection pos on Config!.");
                //    return ret;
                //}

                //var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                //optionBuilder.UseSqlServer(constr);
                //var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var orderNo = param.orderNo;

                var dataSale = (from p in _context.DfSubsohdr.Where(a => a.SuborderType == subOrderType)
                                join h in _context.DfSohdr on new { p.BranchNo, p.ShoppingCard, p.OrderNo } equals new { h.BranchNo, h.ShoppingCard, h.OrderNo }
                                where h.BranchNo == branchNo && h.ShoppingCard == shoppingCard && h.OrderNo == orderNo
                                select new { p, h }
                                ).FirstOrDefault();


                if (dataSale == null)
                {
                    ret.SetMessage("Ex-Data:Find Sohdr join Subsohdr", "Data order not found!.");
                    return ret;
                }

                if (dataSale.h.CustTypeCode == "SE") //Resale return s
                {
                    ret.Data = KP.Common.Hanging.TypeHanging.Resale; // Resale
                }
                else
                {
                    //algorithm

                    List<HangingTypeLis> lstHang = new List<HangingTypeLis>();

                    var listGroupHeader = _context.PkHangingTypeHead.Where(a => a.ParentKey == null).OrderBy(a => a.OrderNo).ToList();
                    foreach (var hd in listGroupHeader)
                    {
                        var strWhere = "";
                        var stritemwhere = "";
                        var detail = _context.PkHangingTypeItems.Where(a => a.TypeGroupKey == hd.TypeGroupKey).ToList();
                        foreach (var de in detail)
                        {
                            var itemwhere = "";
                            var cfCode = StringBL.StringNullToEmpty(de.HangingTypeCfcode);
                            if (cfCode == KP.Common.Hanging.TypeBaseHangingCF.Category)
                            {
                                itemwhere = "CateCode";
                            }
                            else if (cfCode == Common.Hanging.TypeBaseHangingCF.BrandCode)
                            {
                                itemwhere = "BrandCode";
                            }
                            else if (cfCode == Common.Hanging.TypeBaseHangingCF.Material)
                            {
                                itemwhere = "ArticleCode";
                            }
                            else if (cfCode == Common.Hanging.TypeBaseHangingCF.Price)
                            {
                                itemwhere = "price";
                            }


                            var opCode = StringBL.StringNullToEmpty(de.Operation);
                            if (opCode == KP.Common.Hanging.CommandHanging.Equal)
                            {
                                itemwhere += " = ";
                            }
                            else if (opCode == KP.Common.Hanging.CommandHanging.Greathan)
                            {
                                itemwhere += " > ";
                            }
                            else if (opCode == KP.Common.Hanging.CommandHanging.Lessthan)
                            {
                                itemwhere += " < ";
                            }
                            else if (opCode == KP.Common.Hanging.CommandHanging.NoEqual)
                            {
                                itemwhere += " <> ";
                            }

                            var strKeySearch = "";
                            if (cfCode == KP.Common.Hanging.TypeBaseHangingCF.Price)
                            {
                                strKeySearch = de.SearchCode.Trim();
                            }
                            else
                            {
                                strKeySearch = "'" + de.SearchCode.Trim() + "'";
                            }

                            if (stritemwhere != "")
                            {
                                stritemwhere += " " + hd.GroupOper + " ( " + itemwhere + strKeySearch + " ) ";
                            }
                            else
                            {
                                stritemwhere = " ( " + itemwhere + strKeySearch + " ) ";
                            }
                        }
                        if (stritemwhere != "")
                        {
                            if (strWhere != "")
                            {
                                strWhere += " " + hd.GroupOper + " ( " + stritemwhere + " ) ";
                            }
                            else
                            {
                                strWhere = " ( " + stritemwhere + " ) ";
                            }
                        }
                        //end Step Type Key not have parent keys

                        var dataChildParent = _context.PkHangingTypeHead.Where(a => a.ParentKey == hd.TypeGroupKey).ToList();
                        foreach (var child in dataChildParent)
                        {
                            var strHeadWhere = "";
                            var dataChild = _context.PkHangingTypeItems.Where(a => a.TypeGroupKey == child.TypeGroupKey).ToList();
                            foreach (var chd in dataChild)
                            {
                                var itemwhere = "";
                                var cfCode = StringBL.StringNullToEmpty(chd.HangingTypeCfcode);
                                if (cfCode == KP.Common.Hanging.TypeBaseHangingCF.Category)
                                {
                                    itemwhere = "CateCode";
                                }
                                else if (cfCode == Common.Hanging.TypeBaseHangingCF.BrandCode)
                                {
                                    itemwhere = "BrandCode";
                                }
                                else if (cfCode == Common.Hanging.TypeBaseHangingCF.Material)
                                {
                                    itemwhere = "ArticleCode";
                                }
                                else if (cfCode == Common.Hanging.TypeBaseHangingCF.Price)
                                {
                                    itemwhere = "price";
                                }


                                var opCode = StringBL.StringNullToEmpty(chd.Operation);
                                if (opCode == KP.Common.Hanging.CommandHanging.Equal)
                                {
                                    itemwhere += " = ";
                                }
                                else if (opCode == KP.Common.Hanging.CommandHanging.Greathan)
                                {
                                    itemwhere += " > ";
                                }
                                else if (opCode == KP.Common.Hanging.CommandHanging.Lessthan)
                                {
                                    itemwhere += " < ";
                                }
                                else if (opCode == KP.Common.Hanging.CommandHanging.NoEqual)
                                {
                                    itemwhere += " <> ";
                                }

                                var strKeySearch = "";
                                if (cfCode == KP.Common.Hanging.TypeBaseHangingCF.Price)
                                {
                                    strKeySearch = chd.SearchCode.Trim();
                                }
                                else
                                {
                                    strKeySearch = "'" + chd.SearchCode.Trim() + "'";
                                }

                                if (strHeadWhere != "")
                                {
                                    strHeadWhere += " " + child.GroupOper + " ( " + itemwhere + strKeySearch + " ) ";
                                }
                                else
                                {
                                    strHeadWhere = " ( " + itemwhere + strKeySearch + " ) ";
                                }
                            }
                            if (strHeadWhere != "")
                            {
                                if (strWhere != "")
                                {
                                    strWhere += " " + child.GroupOper + " ( " + strHeadWhere + " ) ";
                                }
                                else
                                {
                                    strWhere = " ( " + strHeadWhere + " ) ";
                                }
                            }

                            var inlawChild = _context.PkHangingTypeHead.Where(a => a.ParentKey == child.TypeGroupKey).ToList();
                            foreach (var law in inlawChild)
                            {
                                dataChild = _context.PkHangingTypeItems.Where(a => a.TypeGroupKey == law.TypeGroupKey).ToList();
                                foreach (var chd in dataChild)
                                {
                                    var itemwhere = "";
                                    var cfCode = StringBL.StringNullToEmpty(chd.HangingTypeCfcode);
                                    if (cfCode == KP.Common.Hanging.TypeBaseHangingCF.Category)
                                    {
                                        itemwhere = "CateCode";
                                    }
                                    else if (cfCode == Common.Hanging.TypeBaseHangingCF.BrandCode)
                                    {
                                        itemwhere = "BrandCode";
                                    }
                                    else if (cfCode == Common.Hanging.TypeBaseHangingCF.Material)
                                    {
                                        itemwhere = "ArticleCode";
                                    }
                                    else if (cfCode == Common.Hanging.TypeBaseHangingCF.Price)
                                    {
                                        itemwhere = "price";
                                    }


                                    var opCode = StringBL.StringNullToEmpty(chd.Operation);
                                    if (opCode == KP.Common.Hanging.CommandHanging.Equal)
                                    {
                                        itemwhere += " = ";
                                    }
                                    else if (opCode == KP.Common.Hanging.CommandHanging.Greathan)
                                    {
                                        itemwhere += " > ";
                                    }
                                    else if (opCode == KP.Common.Hanging.CommandHanging.Lessthan)
                                    {
                                        itemwhere += " < ";
                                    }
                                    else if (opCode == KP.Common.Hanging.CommandHanging.NoEqual)
                                    {
                                        itemwhere += " <> ";
                                    }

                                    var strKeySearch = "";
                                    if (cfCode == KP.Common.Hanging.TypeBaseHangingCF.Price)
                                    {
                                        strKeySearch = chd.SearchCode.Trim();
                                    }
                                    else
                                    {
                                        strKeySearch = "'" + chd.SearchCode.Trim() + "'";
                                    }

                                    if (strHeadWhere != "")
                                    {
                                        strHeadWhere += " " + law.GroupOper + " ( " + itemwhere + strKeySearch + " ) ";
                                    }
                                    else
                                    {
                                        strHeadWhere = " ( " + itemwhere + strKeySearch + " ) ";
                                    }
                                }
                                if (strHeadWhere != "")
                                {
                                    if (strWhere != "")
                                    {
                                        strWhere += " " + law.GroupOper + " ( " + strHeadWhere + " ) ";
                                    }
                                    else
                                    {
                                        strWhere = " ( " + strHeadWhere + " ) ";
                                    }
                                }
                            }
                        }
                        lstHang.Add(new HangingTypeLis()
                        {
                            HangingTypeCode = hd.HangingTypeCode,
                            SqlWhere = strWhere
                        });
                    }

                    foreach (var query in lstHang)
                    {
                        var datasohist = _context.DfSohist.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == orderNo && a.SuborderType == subOrderType && a.LineCancel == false && a.CancelStatus == false).OrderBy(a => a.LineNo).ToList();

                        if (datasohist.Count() == 0)
                        {
                            ret.SetMessage("Ex-Data", "List item not found!.");
                            return ret;
                        }

                        foreach (var item in datasohist)
                        {

                            var checkData = " select ArticleCode From ( select * from ( select * ," + item.SellingPrice.ToString() + " as price from vArticleMC where ArticleCode='" + item.MatCode + "') a ";
                            checkData += " where ArticleCode='" + item.MatCode + "' and (" + query.SqlWhere + ") ) b";

                            var res = _context.Set<Query>().FromSql(checkData).FirstOrDefault();

                            if (res != null)
                            {
                                ret.Data = query.HangingTypeCode;
                                //return ret;
                            }
                        }
                    }

                    if (ret.Data == "")
                    {

                        var dateNow = _context.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();

                        var FTime = dataSale.h.FlightDate;
                        var t = dataSale.h.FlightTime.Split(":");
                        if (t.Count() == 2)
                        {
                            try
                            {
                                ret.Data = KP.Common.Hanging.TypeHanging.NormalHanging;
                                DateTime FlightDTime = new DateTime(FTime.Value.Year, FTime.Value.Month, FTime.Value.Day, Convert.ToInt32(t[0]), Convert.ToInt32(t[1]), 0);
                                //if(dateNow.DbDt.AddDays(1).Date <= FlightDTime.Date)
                                //{
                                //    if(FlightDTime.Hour<6 )
                                //    {
                                //        ret.Data = KP.Common.Hanging.TypeHanging.UrgentHanging;
                                //    }
                                //}


                                DateTime odDateNow = dateNow.DbDt.Date.AddDays(1).AddHours(6);  // 24/11/21 --> +1 --> 25/11/21  => +6h --> 25/11/21 06:00
                                DateTime fdCheckDate = FlightDTime; // 24/11/21 23:00
                                if (odDateNow > fdCheckDate)// 25/11/21 06:00 > 24/11/21 23:00 ,25/11/21 06:00 > 25/11/21 05:00  else -->***  25/11/21 06:00 > 25/11/21 06:10
                                {
                                    //U***
                                    ret.Data = KP.Common.Hanging.TypeHanging.UrgentHanging;
                                }

                                //FTime = new DateTime(FTime.Value.Year, FTime.Value.Month, FTime.Value.Day, Convert.ToInt32(t[0]), Convert.ToInt32(t[1]), 0);

                                //var mTime = dateNow.DbDt;

                                //if (mTime.Hour < 6)
                                //{
                                //    mTime = mTime.AddDays(1);
                                //}

                                //mTime = new DateTime(mTime.Year, mTime.Month, mTime.Day, 6, 0, 0);

                                //if (FTime <= mTime)
                                //{
                                //    ret.Data = KP.Common.Hanging.TypeHanging.UrgentHanging;//UrgentHanging
                                //}
                                //else
                                //{
                                //    //mTime = dateNow.DbDt.AddDays(2);
                                //    //mTime = new DateTime(mTime.Year, mTime.Month, mTime.Day, 6, 0, 0);
                                //    //if (FTime <= mTime)
                                //    //{
                                //    //    ret.Data = KP.Common.Hanging.TypeHanging.TempHaning; //Temp Hanging
                                //    //}
                                //    //else
                                //    //{
                                //        ret.Data = KP.Common.Hanging.TypeHanging.NormalHanging; // Normal Hanging
                                //    //}
                                //}
                            }
                            catch (Exception ex)
                            {
                                ret.SetMessage("Ex-Operation Convert Date", "Invalid Format Date!");
                                return ret;
                            }
                        }
                        else
                        {
                            ret.SetMessage("Ex-Data Split Flight Time", "Invalid Flight Time!");
                            return ret;
                        }
                    }
                }

                if (ret.Data != "")
                {
                    if (ret.Data == "I" || ret.Data == "H")
                    {
                        ret.Data = "H";
                    }

                    ret.totalCount = 1;
                    ret.isCompleted = true;
                }
            }

            catch (Exception ex)
            {
                ret.SetMessage("Ex-Operation", ex.Message);
            }

            return ret;
        }


        public async Task<ReturnObject<bool>> reserveHanging(ParameterHanging param)
        {
            ReturnObject<bool> ret = new ReturnObject<bool>();

            try
            {
                var branchNo = StringBL.StringNullToEmpty(param.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("Ex-Input", "Input Branch No is Required!.");
                    return ret;
                }

                if (param.orderNo <= 0)
                {
                    ret.SetMessage("Ex-Input", "Input Order No is Required!.");
                    return ret;
                }

                var subOrderType = StringBL.StringNullToEmpty(param.subOrderType);
                if (subOrderType == "")
                {
                    ret.SetMessage("Ex-Input", "Input Sub Order Type is Required!.");
                    return ret;
                }

                var shoppingCard = StringBL.StringNullToEmpty(param.shoppingCard);
                if (shoppingCard == "")
                {
                    ret.SetMessage("Ex-Input", "Input Shopping Card is Required!.");
                    return ret;
                }

                //PackingData.PackingEntities.df_subsohdr subsohdr = new PackingData.PackingEntities.df_subsohdr() {
                //    branch_no = branchNo,
                //    shopping_card = shoppingCard,
                //    suborder_type = subOrderType,
                //    order_no = param.orderNo,

                //}; 

                //PackingData.Contexts.PackingDataContext dbPack = new PackingData.Contexts.PackingDataContext(_context.Database.GetDbConnection().ConnectionString);
                //var findType = PackingData.BusinessLayer.HangingBL.GetHangingTypeNew(dbPack, branchNo, subsohdr);

                var getType = await getHangingType(param);
                if (getType.Message.Count() > 0)
                {
                    ret.Message.AddRange(getType.Message);
                }
                else
                {
                    var dateNow = _context.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();


                    var getconfigList = _context.ConfigPos.ToList();
                    var urlAPI = getconfigList.Where(a => a.ConfigCode == "GetTokenHangingAPI").FirstOrDefault();
                    if (urlAPI == null)
                    {
                        ret.SetMessage("Ex-Data", "Config POS Hanging API not Found!.");
                        return ret;
                    }

                    var userApi = getconfigList.Where(a => a.ConfigCode == "UserHangingAPI").FirstOrDefault();
                    if (userApi == null)
                    {
                        ret.SetMessage("Ex-Data", "Config POS User Name not Found!.");
                        return ret;
                    }

                    var passApi = getconfigList.Where(a => a.ConfigCode == "PassHangingAPI").FirstOrDefault();
                    if (passApi == null)
                    {
                        ret.SetMessage("Ex-Data", "Config POS Password not Found!.");
                        return ret;
                    }

                    var grantAPI = getconfigList.Where(a => a.ConfigCode == "GrantHangingAPI").FirstOrDefault();
                    if (grantAPI == null)
                    {
                        ret.SetMessage("Ex-Data", "Config POS Grants not Found!.");
                        return ret;
                    }

                    var urlReserve = getconfigList.Where(a => a.ConfigCode == "ReserveHangingAPI");
                    if (urlReserve == null)
                    {
                        ret.SetMessage("Ex-Data", "Reserve Hanging URL not Found!.");
                        return ret;
                    }

                    var client = new RestClient(urlAPI.ConfigData);
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/json");

                    authenModel model = new authenModel()
                    {
                        userName = userApi.ConfigData,
                        password = passApi.ConfigData,
                        grantType = grantAPI.ConfigData
                    };
                    string postDatas = JsonConvert.SerializeObject(model);
                    request.AddParameter("application/json", postDatas, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    var returnObject = JsonConvert.DeserializeObject<ReturnObject<respAuthen>>(response.Content);


                    var urlRequest = getconfigList.Where(a => a.ConfigCode == "ReserveHangingAPI").FirstOrDefault();
                    var urlBearear = "Bearer " + returnObject.Data.accessToken;

                    var requestURL = WebRequest.Create(urlRequest.ConfigData) as HttpWebRequest;
                    //var requestURL = WebRequest.Create("https://openpickupapi.kingpower.com/opapipreprd/api/Hanging/ReserveHanging") as HttpWebRequest;
                    requestURL.KeepAlive = true;
                    requestURL.Method = "POST";
                    requestURL.Headers.Add("Authorization", urlBearear);
                    requestURL.ContentType = "application/json";


                    var findPackingNo = (from s in _context.DfSubsohdr
                                         join p in _context.PkPackingNo on new { s.RecNo, s.BranchNo } equals new { RecNo = p.SubSohdrRecNo, p.BranchNo }
                                         where s.BranchNo == branchNo && s.ShoppingCard == shoppingCard && s.OrderNo == param.orderNo && s.SuborderType == param.subOrderType
                                         select p.PackingNo
                                          ).FirstOrDefault();

                    if (findPackingNo == null)
                    {
                        ret.SetMessage("Ex-Data", "Packing No not found!.");
                        _context.DfHangingapis.Add(new DfHangingapi()
                        {
                            branchNo = branchNo,
                            shoppingCard = shoppingCard,
                            description = "Packing not found!.",
                            orderNo = param.orderNo,
                            subOrderType = subOrderType,
                            addDatetime = dateNow.DbDt,
                            jsonBody = JsonConvert.SerializeObject(param, Formatting.Indented)
                        });
                        _context.SaveChanges();
                    }

                    var dataCustomer = (from h in _context.DfSohdr
                                        join s in _context.DfSubsohdr on new { h.BranchNo, h.ShoppingCard, h.OrderNo } equals new { s.BranchNo, s.ShoppingCard, s.OrderNo }
                                        join c in _context.DfCustomer on new { h.BranchNo, h.ShoppingCard } equals new { c.BranchNo, c.ShoppingCard }
                                        where s.BranchNo == branchNo && s.ShoppingCard == shoppingCard && s.OrderNo == param.orderNo && s.SuborderType == subOrderType
                                        select new { h, s, c }
                                        ).FirstOrDefault();
                    if (dataCustomer != null)
                    {
                        posReserveHanging reqtohang = new posReserveHanging()
                        {
                            flightCode = StringBL.StringNullToEmpty(dataCustomer.h.AirlineCode) + StringBL.StringNullToEmpty(dataCustomer.h.FlightCode),
                            flightDate = dataCustomer.h.FlightDate.Value,
                            flightTime = dataCustomer.h.FlightTime,
                            hangingType = getType.Data,
                            packingNo = findPackingNo,
                            passportNo = dataCustomer.c.PassportNo,
                            pickupCode = dataCustomer.s.PickupCode,
                            userInfo = param.userInfo
                        };


                        Stream reqStream = requestURL.GetRequestStream();
                        string postData = JsonConvert.SerializeObject(reqtohang);
                        byte[] postArray = Encoding.UTF8.GetBytes(postData);
                        reqStream.Write(postArray, 0, postArray.Length);
                        reqStream.Close();
                        StreamReader sr = new StreamReader(requestURL.GetResponse().GetResponseStream());
                        string jsonResult = sr.ReadToEnd();


                        var returnObjects = JsonConvert.DeserializeObject<KP.Common.ReturnApi.ReturnApiObject<List<ReserveHangingInfo>>>(jsonResult);

                        if (returnObjects.Message.Count() > 0)
                        {
                            //case Already Has hanging No
                            if (returnObjects.Message.FirstOrDefault().MessageCode == "OP0111" && returnObjects.Message.FirstOrDefault().MessageType == "WARNING")
                            {
                                if (returnObjects.Data != null && returnObjects.Data.FirstOrDefault() != null)
                                {
                                    var hangingNo = StringBL.StringNullToEmpty(returnObjects.Data.FirstOrDefault().HangingNo);

                                    if (hangingNo != "")
                                    {
                                        var findUpdate = _context.DfSubsohdr.Where(a =>
                                        a.BranchNo == branchNo
                                        && a.ShoppingCard == shoppingCard
                                        && a.OrderNo == param.orderNo
                                        && a.SuborderType == subOrderType).FirstOrDefault();

                                        if (findUpdate != null)
                                        {
                                            findUpdate.NewHangingNo = hangingNo;
                                            _context.SaveChanges();
                                            ret.Data = true;
                                            return ret;
                                        }
                                    }
                                    else
                                    {
                                        ret.SetMessage("Ex-Hanging", "No found Hanging From Pickup");
                                    }
                                }
                            }
                            else
                            {
                                ret.Message.Add(new ResultMessage()
                                {
                                    MessageCode = returnObjects.Message.FirstOrDefault().MessageCode,
                                    MessageDesc = returnObjects.Message.FirstOrDefault().MessageDesc,
                                    MessageType = returnObjects.Message.FirstOrDefault().MessageType
                                });

                                _context.DfHangingapis.Add(new DfHangingapi()
                                {
                                    branchNo = branchNo,
                                    shoppingCard = shoppingCard,
                                    description = returnObjects.Message.FirstOrDefault().MessageCode + " " + returnObjects.Message.FirstOrDefault().MessageDesc,
                                    orderNo = param.orderNo,
                                    subOrderType = subOrderType,
                                    addDatetime = dateNow.DbDt,
                                    jsonBody = JsonConvert.SerializeObject(reqtohang, Formatting.Indented)
                                });
                                _context.SaveChanges();
                                return ret;
                            }
                        }

                        var datasubsohdr = _context.DfSubsohdr.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == param.orderNo && a.SuborderType == subOrderType).FirstOrDefault();
                        if (datasubsohdr == null)
                        {
                            ret.SetMessage("Ex-Data", "Order Not Found!.");
                            _context.DfHangingapis.Add(new DfHangingapi()
                            {
                                branchNo = branchNo,
                                shoppingCard = shoppingCard,
                                description = "Order not found!.",
                                orderNo = param.orderNo,
                                subOrderType = subOrderType,
                                addDatetime = dateNow.DbDt,
                                jsonBody = JsonConvert.SerializeObject(param, Formatting.Indented)
                            });
                            _context.SaveChanges();

                        }
                        else
                        {
                            datasubsohdr.NewHangingNo = returnObjects.Data.FirstOrDefault().HangingNo;

                            var packingNo = "";
                            var findPack = _context.PkPackingNo.Where(a => a.BranchNo == branchNo && a.SubSohdrRecNo == datasubsohdr.RecNo).Select(a => a.PackingNo).FirstOrDefault();
                            if (findPack != null)
                            {
                                packingNo = findPack;
                            }


                            _context.LogHangingApis.Add(new LogHangingApi()
                            {
                                addDatetime = dateNow.DbDt,
                                branchNo = branchNo,
                                orderNo = param.orderNo,
                                shoppingCard = shoppingCard,
                                subOrderType = subOrderType,
                                status = "Reserve",
                                hangingNo = returnObjects.Data.FirstOrDefault().HangingNo,
                                recNo = datasubsohdr.RecNo,
                                packingNo = packingNo,
                            });

                        }

                        _context.SaveChanges();
                        ret.Data = true;
                    }
                    else
                    {
                        ret.SetMessage("Ex-Data", "Data not found!.");

                        return ret;
                    }
                }

                ret.isCompleted = true;

            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Operation", ex.Message);
            }

            return ret;
        }

        public async Task<ReturnObject<bool>> cancelHanging(ParameterHanging param)
        {
            ReturnObject<bool> ret = new ReturnObject<bool>();

            try
            {
                var branchNo = StringBL.StringNullToEmpty(param.branchNo);
                if (branchNo == "")
                {
                    ret.SetMessage("Ex-Input", "Input Branch No is Required!.");
                    return ret;
                }

                var subOrderType = StringBL.StringNullToEmpty(param.subOrderType);
                if (subOrderType == "")
                {
                    ret.SetMessage("Ex-Input", "Input Sub Order Type is Required!.");
                    return ret;
                }

                var shoppingCard = StringBL.StringNullToEmpty(param.shoppingCard);
                if (shoppingCard == "")
                {
                    ret.SetMessage("Ex-Input", "Input Shopping Card is Required!.");
                    return ret;
                }

                var dateNow = _context.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();

                //var constr = "";
                //var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == branchNo && a.DbType == "POS" &&
                //a.SubBranch == subBranch).FirstOrDefault();

                //if (getDb != null)
                //{
                //    var server = StringBL.StringNullToEmpty(getDb.DbServer);
                //    var database = StringBL.StringNullToEmpty(getDb.DbName);
                //    var user = StringBL.StringNullToEmpty(getDb.DbUser);
                //    var password = StringBL.StringNullToEmpty(getDb.DbPass);
                //    constr = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                //                            server, database, user, password);
                //}
                //else
                //{
                //    ret.SetMessage("Ex-Master", "No found Connection pos on Config!.");
                //    return ret;
                //}

                //var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                //optionBuilder.UseSqlServer(constr);
                //var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);


                var getconfigList = _context.ConfigPos.ToList();
                var urlAPI = getconfigList.Where(a => a.ConfigCode == "GetTokenHangingAPI").FirstOrDefault();
                if (urlAPI == null)
                {
                    ret.SetMessage("Ex-Data", "Config POS Token API not Found!.");
                    return ret;
                }

                var cancelHanging = getconfigList.Where(a => a.ConfigCode == "CancelHangingAPI").FirstOrDefault();
                if (cancelHanging == null)
                {
                    ret.SetMessage("Ex-Data", "Config Cancel Hanging not Found!.");
                    return ret;
                }

                var userApi = getconfigList.Where(a => a.ConfigCode == "UserHangingAPI").FirstOrDefault();
                if (userApi == null)
                {
                    ret.SetMessage("Ex-Data", "Config POS User Name not Found!.");
                    return ret;
                }

                var passApi = getconfigList.Where(a => a.ConfigCode == "PassHangingAPI").FirstOrDefault();
                if (passApi == null)
                {
                    ret.SetMessage("Ex-Data", "Config POS Password not Found!.");
                    return ret;
                }

                var grantAPI = getconfigList.Where(a => a.ConfigCode == "GrantHangingAPI").FirstOrDefault();
                if (grantAPI == null)
                {
                    ret.SetMessage("Ex-Data", "Config POS Grants not Found!.");
                    return ret;
                }


                var client = new RestClient(urlAPI.ConfigData);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                authenModel model = new authenModel()
                {
                    userName = userApi.ConfigData,
                    password = passApi.ConfigData,
                    grantType = grantAPI.ConfigData
                };
                string postDatas = JsonConvert.SerializeObject(model);
                request.AddParameter("application/json", postDatas, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                var returnObject = JsonConvert.DeserializeObject<ReturnObject<respAuthen>>(response.Content);



                var urlRequest = getconfigList.Where(a => a.ConfigCode == "CancelHangingAPI").FirstOrDefault();
                var urlBearear = "Bearer " + returnObject.Data.accessToken;

                var requestURL = WebRequest.Create(cancelHanging.ConfigData) as HttpWebRequest;
                requestURL.KeepAlive = true;
                requestURL.Method = "POST";
                requestURL.Headers.Add("Authorization", urlBearear);
                requestURL.ContentType = "application/json";


                var data = (from s in _context.DfSubsohdr
                            join p in _context.PkPackingNo on new { s.BranchNo, s.RecNo } equals new { p.BranchNo, RecNo = p.SubSohdrRecNo }
                            where s.BranchNo == branchNo && s.ShoppingCard == shoppingCard && s.OrderNo == param.orderNo && s.SuborderType == subOrderType
                            select new { s, p }).FirstOrDefault();

                if (data != null)
                {

                    CancelHangingInfo reqtohang = new CancelHangingInfo()
                    {
                        hangingNo = data.s.NewHangingNo,
                        packingNo = data.p.PackingNo,
                        pickupCode = data.s.PickupCode,
                        userInfo = param.userInfo
                    };


                    Stream reqStream = requestURL.GetRequestStream();
                    string postData = JsonConvert.SerializeObject(reqtohang);
                    byte[] postArray = Encoding.UTF8.GetBytes(postData);
                    reqStream.Write(postArray, 0, postArray.Length);
                    reqStream.Close();
                    StreamReader sr = new StreamReader(requestURL.GetResponse().GetResponseStream());
                    string jsonResult = sr.ReadToEnd();


                    var returnObjects = JsonConvert.DeserializeObject<KP.Common.ReturnApi.ReturnApiObject<bool>>(jsonResult);

                    if (returnObjects.Message.Count() > 0)
                    {
                        ret.Message.Add(new ResultMessage()
                        {
                            MessageCode = returnObjects.Message.FirstOrDefault().MessageCode,
                            MessageDesc = returnObjects.Message.FirstOrDefault().MessageDesc,
                            MessageType = returnObjects.Message.FirstOrDefault().MessageType
                        });

                        _context.DfHangingapis.Add(new DfHangingapi()
                        {
                            branchNo = branchNo,
                            shoppingCard = shoppingCard,
                            description = returnObjects.Message.FirstOrDefault().MessageCode + " " + returnObjects.Message.FirstOrDefault().MessageDesc,
                            orderNo = param.orderNo,
                            subOrderType = subOrderType,
                            addDatetime = dateNow.DbDt,
                            jsonBody = JsonConvert.SerializeObject(reqtohang, Formatting.Indented)
                        });

                        _context.SaveChanges();

                    }

                    var newhanging = "";
                    var detail = _context.DfSubsohdr.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == param.orderNo && a.SuborderType == subOrderType).FirstOrDefault();
                    if (detail != null)
                    {
                        newhanging = detail.NewHangingNo;
                        detail.NewHangingNo = "";

                        var packing = "";
                        var findPack = _context.PkPackingNo.Where(a => a.BranchNo == branchNo && a.SubSohdrRecNo == detail.RecNo).Select(a => a.PackingNo).FirstOrDefault();
                        if (findPack != null)
                        {
                            packing = findPack;
                        }

                        _context.LogHangingApis.Add(new LogHangingApi()
                        {
                            addDatetime = dateNow.DbDt,
                            branchNo = branchNo,
                            orderNo = param.orderNo,
                            shoppingCard = shoppingCard,
                            subOrderType = subOrderType,
                            status = "CANCEL",
                            recNo = detail.RecNo,
                            hangingNo = newhanging,
                            packingNo = packing
                        });

                    }
                    _context.SaveChanges();


                    ret.Data = returnObjects.Data;
                    ret.isCompleted = true;
                }
                else
                {
                    ret.SetMessage("Ex-Data", "Data not found!.");
                    return ret;
                }
                ret.isCompleted = true;
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Operation", ex.Message);
            }

            return ret;

        }

        public ReturnObject<string> getPickupFromFlight(InputPickupFromFlight param)
        {
            ReturnObject<string> ret = new ReturnObject<string>();

            try
            {
                string pick = "", charter = "";

                var pickCode = _context.DfFlight.Where(t => t.AirlineCode.Trim().Equals(param.airlineCode) && t.FlightCode.Trim().Equals(param.flightCode)).FirstOrDefault();

                var dataPick = _context.DfPickup.Where(t => t.BranchNo.Trim().Equals(param.branchNo) && t.PickupCode.Trim().Equals(pickCode.PickupCode)).Select(t => t.PickupName).ToList();

                if (dataPick.Count() > 0)
                {
                    pick = pickCode.PickupCode.Trim();
                    charter = pickCode.CharterFlight.ToString();
                }
                if (pick.Trim() == "")
                {
                    var dataFlight = _context.DfAirline.Where(t => t.AirlineCode.Trim().Equals(param.airlineCode)).ToList();

                    if (dataFlight.Count() > 0)
                    {
                        pick = dataFlight.FirstOrDefault().PickupCode;
                    }
                }

                if (pick != "")
                {
                    //if (pick.Trim().Equals("PU02") && param.country.Trim().ToUpper().Equals("THA"))
                    //{
                    //    pick = "PU03";
                    //}
                    if (pick != "")
                    {
                        if (param.isIncludeName)
                        {
                            pick = pick + "-" + dataPick;
                        }
                    }
                }

                ret.Data = pick;
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }


        public async Task<ReturnObject<ListSite>> getListByMachine(StockModels param)
        {
            ReturnObject<ListSite> ret = new ReturnObject<ListSite>();
            ret.Data = new ListSite();
            ret.Data.lstSite = new List<detailSite>();
            ret.Data.lstGroup = new List<groupSite>();
            try
            {
                if (param == null)
                {
                    ret.SetMessage("WM001", "Input is required!.");
                    return ret;
                }

                var machineIp = StringBL.StringNullToEmpty(param.machineIp);
                if (machineIp == "")
                {
                    ret.SetMessage("WM002", "Machine ip is Required!.");
                    return ret;
                }


                var getMachineNo = (from p in _context.CKCMachine
                                    join q in _context.CKCMachineSite on p.machineNo equals q.machineNo
                                    where p.machineIP == machineIp && p.isCancel == false
                                    select q).ToList();

                if (getMachineNo == null)
                {
                    ret.SetMessage("WM003", "Data IP : " + machineIp + " not found!.");
                    return ret;
                }
                else
                {

                    foreach (var lstSite in getMachineNo)
                    {
                        var getSite = lstSite.siteCode.Replace("%", "");

                        var getDataSite = _context.CKCSite.Where(a => a.siteCode.StartsWith(getSite)).Select(a => new detailSite()
                        {
                            site = a.siteCode,
                            siteName = a.siteName
                        }).ToList();

                        if (getDataSite.Count > 0)
                        {
                            ret.Data.lstSite.AddRange(getDataSite);
                        }

                    }

                    var getMachineFirst = getMachineNo.FirstOrDefault();
                    if (getMachineFirst != null)
                    {
                        var getGroupType = _context.CKCMachineSettings.Where(a => a.machine_no == getMachineFirst.machineNo).ToList();

                        if (getGroupType.Count() > 0)
                        {
                            List<groupSite> lstGroup = new List<groupSite>();
                            var districtType = getGroupType.Select(a => a.machine_group).Distinct().ToList();
                            foreach (var group in districtType)
                            {
                                groupSite site = new groupSite();
                                site.grouptype = group;
                                site.lstdept = new List<department>();
                                foreach (var dept in getGroupType.Where(a => a.machine_group == group))
                                {
                                    department dep = new department()
                                    {
                                        deptValue = dept.machine_value
                                    };

                                    site.lstdept.Add(dep);
                                }
                                lstGroup.Add(site);
                            }
                            ret.Data.lstGroup = lstGroup;
                        }
                    }

                    ret.isCompleted = true;
                }
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Data", ex.Message + "-" + ex.InnerException);
            }

            return ret;
        }

        public async Task<ReturnObject<List<ConfigData>>> ConfigValue(ConfigParam param)
        {
            ReturnObject<List<ConfigData>> ret = new ReturnObject<List<ConfigData>>();
            ret.Data = new List<ConfigData>();
            try
            {
                var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(param.subBranchCode);
                var branchNo = StringBL.StringNullToEmpty(param.branchNo);
                var configCode = StringBL.StringNullToEmpty(param.configCode);
                if (subBranch == "")
                {
                    ret.SetMessage("Ex-Input", "Input SubBranch is Required!.");
                    return ret;
                }

                if (branchNo == "")
                {
                    ret.SetMessage("Ex-Input", "Input Branch No is Required!.");
                    return ret;
                }

                if (configCode == "")
                {
                    ret.SetMessage("Ex-Input", "Input Config Code is Required!.");
                    return ret;
                }

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

                var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                optionBuilder.UseSqlServer(constr);
                var _context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);

                var getdata = _context1.ConfigPos.Select(a => new ConfigData { configCode = a.ConfigCode, configValue = a.ConfigData });
                if (param.isLike)
                {
                    getdata = getdata.Where(a => a.configCode.Contains(param.configCode));
                }
                else
                {
                    getdata = getdata.Where(a => a.configCode == param.configCode);
                }

                var tolst = getdata.ToList();
                if (tolst.Count() > 0)
                {
                    ret.Data = tolst;
                    ret.isCompleted = true;
                    ret.totalCount = 1;
                }
                else
                {
                    ret.SetMessage("Ex-Data", "Input Config Code : " + configCode + " not found!.");
                    return ret;
                }

                //var getData = _context1.ConfigPos.Where(a => a.ConfigCode == configCode).Select(a => a.ConfigData).FirstOrDefault();
                //if (getData != null)
                //{
                //    ret.Data = StringBL.StringNullToEmpty(getData);
                //    ret.isCompleted = true;
                //    ret.totalCount = 1;
                //}
                //else
                //{
                //    ret.SetMessage("Ex-Data", "Input Config Code : " + configCode + " not found!.");
                //    return ret;
                //}
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Data", ex.Message + "-" + ex.InnerException);
            }

            return ret;
        }


        public async Task<ReturnObject<UpdateOrderStatusKPDModel>> updateOrderLastStatusKPD(UpdateOrderStatusKPDReq param, object context = null)
        {
            var ret = new ReturnObject<UpdateOrderStatusKPDModel>();
            try
            {
                var context1 = context as DBModel.NewKpiEntity.KPIMNPOSMAContext;
                if (context == null)
                {
                    var subBranch = KP.Common.Helper.StringBL.StringNullToEmpty(param.SubBranch);

                    var constr = "";
                    var getDb = _cusContext.DbConnection.Where(a => a.DbBranch == param.BranchNo && a.DbType == "POS" &&
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

                    var optionBuilder = new DbContextOptionsBuilder<DBModel.NewKpiEntity.KPIMNPOSMAContext>();
                    optionBuilder.UseSqlServer(constr);
                    context1 = new DBModel.NewKpiEntity.KPIMNPOSMAContext(optionBuilder.Options);
                }


                var getEndpoint = context1.ConfigPos.Where(a => a.ConfigCode == "UpdateOrderStatusKPD").FirstOrDefault();//EndpointKPDUpdateOrderStatusKPD
                if (getEndpoint == null)
                {
                    ret.SetMessage("Ex-Config", "Endpoint UpdateOrderStatusKPD no have config");
                    return ret;
                }

                var token = context1.ConfigPos.Where(a => a.ConfigCode == "UpdateOrderStatusKPDAuth").FirstOrDefault();//EndpointKPDUpdateOrderStatusKPD
                if (token == null)
                {
                    ret.SetMessage("Ex-Config", "Endpoint UpdateOrderStatusKPD no have config");
                    return ret;
                }

                var paramUpdateStatus = new UpdateOrderStatusKPDModel()
                {
                    StatusCode = param.StatusCode,
                    OnlineOrderNo = param.OnlineOrderNo.Substring(0, 12),
                };

                string url = getEndpoint.ConfigData;
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(paramUpdateStatus);
                var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.ConfigData}");
                    var response = await client.PostAsync(url, data);
                    string result = await response.Content.ReadAsStringAsync();

                    ret = Newtonsoft.Json.JsonConvert.DeserializeObject<ReturnObject<UpdateOrderStatusKPDModel>>(result);
                }

                string lastStatusKpd = param.StatusCode == "003" ? "002" : param.StatusCode == "0021" ? "003" : "";
                if (ret.Data != null)
                {
                    lastStatusKpd = ret.Data.StatusCode;
                }

                var dateNow = context1.Set<Dtserver>().FromSql("select -1 as Id, GETDATE() as DbDt ").First();
                LogDFSohdrextt(context1, "LastStatusKPD", param.BranchNo, param.OrderNo, param.OnlineOrderNo, lastStatusKpd, dateNow.DbDt, param.UserID);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        public void LogDFSohdrextt(KPIMNPOSMAContext _context1, string code, string branchNo, int orderNo, string shoppingCard, string value, DateTime DbDt, string userID)
        {
            // LastStatusKPD มีค่า ไม่ต้องส่งไปอัพเดตซ้ำ
            var dfsohdrexttLog = _context1.DfSohdrExt.Where(a => a.BranchNo == branchNo && a.ShoppingCard == shoppingCard && a.OrderNo == orderNo && a.Code == code).FirstOrDefault();
            if (dfsohdrexttLog == null)
            {
                // log update kpd
                dfsohdrexttLog = new DfSohdrExt()
                {
                    BranchNo = branchNo,
                    Code = code,
                    OrderNo = orderNo,
                    ShoppingCard = shoppingCard,
                    Value = value
                };
                _context1.DfSohdrExt.Add(dfsohdrexttLog);
                _context1.SaveChanges();
            }
            else
            {
                dfsohdrexttLog.Value = value;
                _context1.SaveChanges();
            }

            _context1.dfExtendsLog.Add(new DfExtendsLog()
            {
                datetime = DbDt,
                runno = dfsohdrexttLog.runno,
                tableLog = "df_sohdr_ext",
                userCode = StringBL.StringNullToEmpty(userID),
                valueCode = value
            });
            _context1.SaveChanges();
        }
    }
}
