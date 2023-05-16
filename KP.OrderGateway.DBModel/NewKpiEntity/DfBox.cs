using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfBox
    {
        public string BranchNo { get; set; }
        public string OpaqNo { get; set; }
        public string BoxNo { get; set; }
        public string PickupCode { get; set; }
        public string BoxStaffCode { get; set; }
        public DateTime BoxDate { get; set; }
        public DateTime BoxDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public string HangingNo { get; set; }
        public string PickupStaffCode { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? PickupDatetime { get; set; }
    }
}
