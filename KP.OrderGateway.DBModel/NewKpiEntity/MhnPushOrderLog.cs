using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MhnPushOrderLog
    {
        public string BranchNo { get; set; }
        public long RecNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public string MachineNo { get; set; }
        public string TaxabbNo { get; set; }
        public bool? IsPush { get; set; }
        public DateTime? PushDt { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
