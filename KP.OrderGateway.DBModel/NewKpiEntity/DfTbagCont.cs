using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfTbagCont
    {
        public string BranchNo { get; set; }
        public string TbagNo { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime? ProcessTime { get; set; }
        public string FromStaffCode { get; set; }
        public string ToStaffCode { get; set; }
        public string MachineNo { get; set; }
        public DateTime AddDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
