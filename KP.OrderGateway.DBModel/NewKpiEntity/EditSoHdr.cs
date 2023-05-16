using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class EditSoHdr
    {
        public long EditSoHdrKey { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int? OrderNo { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime? FlightDate { get; set; }
        public string FlightTime { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
