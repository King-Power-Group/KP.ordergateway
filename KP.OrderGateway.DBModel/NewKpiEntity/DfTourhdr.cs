using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfTourhdr
    {
        public string BranchNo { get; set; }
        public string TourCode { get; set; }
        public string TourDesc { get; set; }
        public DateTime TourDate { get; set; }
        public string TourTime { get; set; }
        public string AgentCode { get; set; }
        public string SubagentCode { get; set; }
        public string CountryCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightTime { get; set; }
        public decimal NoPax { get; set; }
        public string TourStatus { get; set; }
        public bool? TourBookStatus { get; set; }
        public string Remark { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string HotelCode { get; set; }
        public string FeeType { get; set; }
        public string CarLicence { get; set; }
        public string TransportCode { get; set; }
    }
}
