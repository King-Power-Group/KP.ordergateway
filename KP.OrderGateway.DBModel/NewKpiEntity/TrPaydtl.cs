using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrPaydtl
    {
        public string BranchNo { get; set; }
        public string DocGroup { get; set; }
        public string DocNo { get; set; }
        public string TourCode { get; set; }
        public string CountryCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public decimal PerHead { get; set; }
        public decimal Commission { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
