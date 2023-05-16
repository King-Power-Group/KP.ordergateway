using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHanging
    {
        public PkHanging()
        {
            PkTransferFromHangingKeyNavigation = new HashSet<PkTransfer>();
            PkTransferToHangingKeyNavigation = new HashSet<PkTransfer>();
        }

        public long HangingKey { get; set; }
        public string HangingNo { get; set; }
        public long HangingHeaderKey { get; set; }
        public bool IsActive { get; set; }
        public bool IsInTransit { get; set; }
        public string BranchNo { get; set; }
        public long? SubSohdrRecNo { get; set; }
        public byte[] TimeStamp { get; set; }
        public int? Running { get; set; }

        public virtual DfSubsohdr DfSubsohdr { get; set; }
        public virtual PkHangingHeader HangingHeaderKeyNavigation { get; set; }
        public virtual ICollection<PkTransfer> PkTransferFromHangingKeyNavigation { get; set; }
        public virtual ICollection<PkTransfer> PkTransferToHangingKeyNavigation { get; set; }
    }
}
