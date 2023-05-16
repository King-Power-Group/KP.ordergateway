using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoFrn
    {
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDate { get; set; }
        public long Frn { get; set; }
    }
}
