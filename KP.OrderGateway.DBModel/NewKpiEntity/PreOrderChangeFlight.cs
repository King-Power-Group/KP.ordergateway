using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PreOrderChangeFlight
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDt { get; set; }
        public string OrderStatus { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public int ReceiveOrderNo { get; set; }
        public DateTime? PackedDt { get; set; }
    }
}
