using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkPackingRunner
    {
        public string BranchNo { get; set; }
        public long SubSohdrRecNo { get; set; }
        public DateTime? CreateDt { get; set; }
        public string FromStaffCode { get; set; }
        public string ToStaffCode { get; set; }
        public string MachineNo { get; set; }
        public byte[] TimeStamp { get; set; }
        public string DollyNo { get; set; }
        public DateTime? SortationSendDt { get; set; }
        public DateTime? SortationFailDt { get; set; }

        public virtual DfSubsohdr DfSubsohdr { get; set; }
    }
}
