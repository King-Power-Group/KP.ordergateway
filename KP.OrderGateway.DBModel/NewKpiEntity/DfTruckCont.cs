using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfTruckCont
    {
        public string BranchNo { get; set; }
        public string BoxNo { get; set; }
        public string TruckNo { get; set; }
        public string TripNo { get; set; }
        public string TruckStaffCode { get; set; }
        public DateTime TruckDate { get; set; }
        public DateTime TruckDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
