using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfInshopSubtrans
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public short LineNo { get; set; }
        public bool? CancelFlag { get; set; }
        public string CountryCode { get; set; }
        public string TourCode { get; set; }
        public DateTime TourDate { get; set; }
        public string TourTime { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightTime { get; set; }
        public int Pax { get; set; }
    }
}
