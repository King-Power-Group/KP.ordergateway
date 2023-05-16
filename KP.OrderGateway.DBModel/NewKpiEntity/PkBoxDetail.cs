using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkBoxDetail
    {
        public long BoxDetailKey { get; set; }
        public long BoxHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public long SubSoHdrRecNo { get; set; }
        public DateTime? CanceledDt { get; set; }
        public string CanceledUserCode { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual PkBoxHeader BoxHeaderKeyNavigation { get; set; }
        public virtual DfSubsohdr DfSubsohdr { get; set; }
    }
}
