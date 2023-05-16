using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class OrderManagementModel
    {
        public class OrderTypeModel
        {
            public string branchNo { get; set; }
            public string shoppingCard { get; set; }
            public int orderNo { get; set; } = 0;
            public string orderType { get; set; } = "";
            public actType actType { get; set; }
            public string user { get; set; }
            public string modeSale { get; set; }
        }
        public class CheckScanItemToOrder : OrderTypeModel
        {
            public string articleCode { get; set; }
        }
        public enum actType
        {
            SALE,
            REFUND
        }
        public static class OrderType
        {
            public const string Normal = "N";
            public const string DutyPaidDelivery = "D";
            public const string PreOrder = "P";
            public const string Receive = "R";
            public const string Shipping = "S";

            public const string ReceivePreOrder = Receive;// "RP";
            public const string ShippingDutyPaidDelivery = Shipping;// "SD";


            public const string AirportArrival = "A";
            public const string AirportDeposit = "D";
            public const string AirportAll = " ";
        }


        public class SearchOrderInfoModel
        {
            public string branchNo { get; set; }
            public string subBranch { get; set; }
            public string customerName { get; set; }
            public string passport { get; set; }
            public string packNo { get; set; }
            public string shoppingCard { get; set; }
            public int orderNo { get; set; }
            public string orderStatus { get; set; }
            public List<string> orderType { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public bool? isMorning { get; set; }
            public string status { get; set; }
            public string isSave { get; set; }
            public string timecode { get; set; }
            public string lastStatus { get; set; }
            public DateTime? orderDate { get; set; }
            public string machine { get; set; }
            public bool? isWeb { get; set; } = false;
        }

        public class SearchStockKPD : SearchOrderInfoModel
        {
            public string flightCode { get; set; }
            public DateTime? flightFrom { get; set; }
            public DateTime? flightTo { get; set; }
        }

        public class SearchOrderReport
        {
            public string branchNo { get; set; }
            public string subBranch { get; set; }
            public DateTime? saleDateFrom { get; set; }
            public DateTime? saleDateTo { get; set; }
            public string timeFrom { get; set; }
            public string timeTo { get; set; }
            public string saleType { get; set; }
            public string orderType { get; set; }
            public string category { get; set; }
            public string brand { get; set; }
        }
    }
}
