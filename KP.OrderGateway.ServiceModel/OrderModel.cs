using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KP.OrderGateway.ServiceModel
{

    public class OrderModelShipping
    {
        [Key]
        public string branchNo { get; set; }

        [Key]
        public string shoppingCard { get; set; }

        [Key]
        public int orderNo { get; set; }

        public DateTime orderDate { get; set; }

        public string packingNo { get; set; }

        public string passportNo { get; set; }

        public string customerName { get; set; }

        public string flight { get; set; }

        public string flightDateTime { get; set; }

        public decimal qty { get; set; }

        public decimal total { get; set; }

        public string userUpdate { get; set; }

        public DateTime? dateTimeUpdate { get; set; }

        public string remark { get; set; }

        public bool isChanged { get; set; }

        public string shipAddress { get; set; }

        public string orderType { get; set; }

        public string orderStatus { get; set; }

        public DateTime updateDatetime { get; set; }

        public bool isDisPatch { get; set; }

        public string refOrder { get; set; }

        public bool isPicking { get; set; }

        public string pickingCheck { get; set; }

        public bool isSaveStock { get; set; }

        public string location { get; set; }

        public string machine { get; set; }

        public string lastStatus { get; set; }

        public bool isScan { get; set; }

        public string isOutOfStock { get; set; }

        public long runnoSohdrExt { get; set; }

        public bool isSendSTO { get; set; }

    }

    public class OrderModel
    {
        [Key]
        public string branchNo { get; set; }

        [Key]
        public string shoppingCard { get; set; }

        [Key]
        public int orderNo { get; set; }

        public DateTime orderDate { get; set; }

        public string packingNo { get; set; }

        public string passportNo { get; set; }

        public string customerName { get; set; }

        public string flight { get; set; }

        public string flightDateTime { get; set; }

        public decimal qty { get; set; }

        public decimal total { get; set; }

        public string userUpdate { get; set; }

        public DateTime? dateTimeUpdate { get; set; }

        public string remark { get; set; }

        public bool isChanged { get; set; }

        public string shipAddress { get; set; }

        public string orderType { get; set; }

        public string orderStatus { get; set; }

        public DateTime updateDatetime { get; set; }

        public bool isDisPatch { get; set; }

        public string refOrder { get; set; }

        public bool isPicking { get; set; }

        public string pickingCheck { get; set; }

        public bool isSaveStock { get; set; }

        public string location { get; set; }

        public string machine { get; set; }

        public string lastStatus { get; set; }

        public bool isScan { get; set; }

        public string isOutOfStock { get; set; }

        public long runnoSohdrExt { get; set; }

        public bool isSendSTO { get; set; }

    }

    public class listProduct
    {
        [Key]
        public int line_No { get; set; }
        public string articleCode { get; set; }
        public string articleName { get; set; }
        public string subOrderType { get; set; }
        public string taxabbNo { get; set; }
        public string claimCheck { get; set; }
        public string packingNo { get; set; }
        public decimal amount { get; set; }
        public decimal price { get; set; }
        public decimal qty { get; set; }
        public decimal discount { get; set; }
        public decimal net { get; set; }
        public decimal discrate { get; set; }
        public string mccode { get; set; }
        public string brandCode { get; set; }
        public string remark { get; set; }
        public decimal qtyVS { get; set; }
        public string barcode { get; set; }
        public string EaUnit { get; set; }
        public string cateCode { get; set; }
        public decimal vatRate { get; set; }
        public decimal vatAmount { get; set; }
        public decimal taxAmount { get; set; }
        public string pickupCode { get; set; }
        public string operatorCode { get; set; }
        public string hangingType { get; set; }
    }

    public class DataModel : OrderModel
    {
        public List<listProduct> lstSohist { get; set; }
        public List<summaryBySuborderType> lstSummary { get; set; }
        public List<lstStockProduct> lstStock { get; set; }
        public List<ExtendLogs> lstLog { get; set; }
    }
    public class KPDModel : DataModel
    {
        public string pickupCode { get; set; }
        public string operatorCode { get; set; }
        public string machineNo { get; set; }
        public string customerType { get; set; }
        public string nationCode { get; set; }
        public string airlineCode { get; set; }
        public string flightNo { get; set; }
        public string flightCode { get; set; }
        public string flightType { get; set; }
        public DateTime flightDate { get; set; }
        public string flightTime { get; set; }
        public string posID { get; set; }
        public string refNo { get; set; }
        public string transType { get; set; }
        public DateTime? transDT { get; set; }
        public List<paymentKPD> lstPayment { get; set; }
        public string userAdd { get; set; }
        public string hangingNo { get; set; }
        public string isPackAtWH { get; set; }
        public string mobileNo { get; set; }
        public bool SAPStatus { get; set; }
        public string orderStatus { get; set; }
        public string lastStatusKpd { get; set; }
    }


    public class NewKPDModel
    {
        [Key]
        public string branchNo { get; set; }
        public string orderStatus { get; set; }
        public string customerName { get; set; }
        [Key]
        public int orderNo { get; set; }
        public DateTime orderDate { get; set; }
        public string packingNo { get; set; }
        public string passportNo { get; set; }
        [Key]
        public string shoppingCard { get; set; }
        public string flight { get; set; }
        public string flightDateTime { get; set; }
        public string remark { get; set; }
        public string orderType { get; set; }
        public DateTime updateDatetime { get; set; }
        public string pickingCheck { get; set; }
        public string airlineCode { get; set; }
        public string flightCode { get; set; }
        public DateTime flightDate { get; set; }
        public string flightTime { get; set; }
        public string customerType { get; set; }
        public string nationCode { get; set; }
        public string flightType { get; set; }
        public string posID { get; set; }
        public string machineNo { get; set; }
        public string operatorCode { get; set; }
        public string pickupCode { get; set; }
        public string refNo { get; set; }
        public DateTime? transDT { get; set; }
        public string userAdd { get; set; }
        public string isPackAtWH { get; set; }
        public string lastStatusKpd { get; set; }
    }

    public class paymentKPD
    {
        [Key]
        public decimal lineNo { get; set; }
        public DateTime paymentDT { get; set; }
        public string paymentCode { get; set; }
        public string paymentShort { get; set; }
        public string paymentName { get; set; }
        public decimal bahtAmount { get; set; }
        public string currencyCode { get; set; }
        public decimal currencyRate { get; set; }
        public decimal currentAmount { get; set; }
        public string creditCardNo { get; set; }
        public string suborderType { get; set; }
    }

    public class ExtendLogs
    {
        [Key]
        public int lineNo { get; set; }
        public string detail { get; set; }
        public string statusCode { get; set; }
        public DateTime dtProcess { get; set; }
        public string userCode { get; set; }
    }

    public class summaryBySuborderType
    {
        [Key]
        public int lineNo { get; set; }
        public string subOrderType { get; set; }
        public string taxAbbNo { get; set; }
        public string cliamCheck { get; set; }
        public string packingNo { get; set; }
        public decimal amount { get; set; }
        public decimal discount { get; set; }
        public decimal net { get; set; }
        public decimal qty { get; set; }
    }

    public class lstShippingUpdate
    {
        public List<lstMaster> lstDetail { get; set; }
        public string jsonUpdate { get; set; }
        public string subbranchCode { get; set; }
        public string userCode { get; set; }
    }

    public class lstMaster
    {
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
    }

    public class lstStock
    {
        public bool isOutofStock { get; set; }
        public List<lstStockProduct> listStock { get; set; }
    }

    public class lstStockProduct
    {
        [Key]
        public int lineNo { get; set; }
        public string articleCode { get; set; }
        public string barcodeScan { get; set; }
        public string barcodeData { get; set; }
        public decimal qty { get; set; }
        public decimal qtyCount { get; set; }
        public bool isFinish { get; set; }
    }

    public class saveStock : lstMaster
    {
        public string valueSave { get; set; }
        public string subBranch { get; set; }
    }

    public class saveTrans : lstMaster
    {
        public string subBranch { get; set; }
        public bool isOutofStock { get; set; }
        public List<lstStockProduct> listStock { get; set; }
        public UserInfo user { get; set; }
        public bool saveKPD { get; set; }
        public bool isSkipCancelKPD { get; set; } = false;
    }

    public class ReportModel
    {
        public int index { get; set; }
        public decimal summaryOrder { get; set; }
        public List<ReportTrans> order { get; set; }
    }

    public class ReportTrans
    {
        public int lineNo { get; set; }
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public string dutypaidArticle { get; set; }
        public string oldArticle { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string cateName { get; set; }
        public string brand { get; set; }
        public string remarks { get; set; }
        public string machine { get; set; }
        public DateTime saleDate { get; set; }
        public decimal qty { get; set; }
        public string orderType { get; set; }
        public decimal amount { get; set; }
        public decimal discount { get; set; }
        public decimal net { get; set; }
        public string orderDate { get; set; }
        public string packingNo { get; set; }
    }

    public class ParamUpdateOrder
    {
        public string subBranch { get; set; }
        public List<updateOrder> lstUpdateOrder { get; set; }
        public UserInfo user { get; set; }
    }

    public class updateOrder
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int orderNo { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }

    public class settings
    {
        public string branchNo { get; set; }
        public string subBranchCode { get; set; }
    }

    public class eComSyncParameter
    {
        public string OrderNo { get; set; }
        public string UserToken { get; set; }
        public string OrderStatus { get; set; }
    }

    public class UpdateOrderStatusKPDReq : UpdateOrderStatusKPDModel
    {
        public string SubBranch { get; set; }
        public string BranchNo { get; set; }
        public int OrderNo { get; set; }
        public string UserID { get; set; }
    }
    public class UpdateOrderStatusKPDModel
    {        
        public string OnlineOrderNo { get; set; }
        public string StatusCode { get; set; }
    }
public class ReturnWsEcom
    {
        public string OrderNo { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public ErrorObj ErrorOBJ { get; set; }
        public string LibraryVersion { get; set; }
    }
    public class ErrorObj
    {
        public string ErrorID { get; set; }
        public string ErrorMessage { get; set; }
    }
}