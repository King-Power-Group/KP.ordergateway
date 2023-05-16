using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSubsohdrExt
    {
        public long SubSoHdrExtKey { get; set; }
        public string BranchNo { get; set; }
        public long SubSohdrRecNo { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual DfSubsohdr DfSubsohdr { get; set; }
    }
}
