using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrHead
    {
        public string BranchNo { get; set; }
        public string TourCode { get; set; }
        public string CountryCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public string AgentCode { get; set; }
        public string SubagentCode { get; set; }
        public string FlightGroup { get; set; }
        public string Description { get; set; }
        public int Pax { get; set; }
        public int Customer { get; set; }
        public decimal Netsales { get; set; }
        public decimal AgentComm { get; set; }
        public decimal AgentHead { get; set; }
        public decimal GuideComm { get; set; }
        public decimal GuideHead { get; set; }
        public bool? PrepostFlag { get; set; }
        public bool? PostFlag { get; set; }
        public bool? GuidePrepost { get; set; }
        public bool? GuidePost { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
