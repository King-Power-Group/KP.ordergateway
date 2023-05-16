using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTransfer
    {
        public long TransferKey { get; set; }
        public long TransferHeaderKey { get; set; }
        public long? FromHangingKey { get; set; }
        public long? ToHangingKey { get; set; }
        public DateTime? ReceiveDt { get; set; }
        public string ReceiveUser { get; set; }
        public byte[] TimeStamp { get; set; }
        public string BranchNo { get; set; }
        public long SubSoHdrRecNo { get; set; }

        public virtual DfSubsohdr DfSubsohdr { get; set; }
        public virtual PkHanging FromHangingKeyNavigation { get; set; }
        public virtual PkHanging ToHangingKeyNavigation { get; set; }
        public virtual PkTransferHeader TransferHeaderKeyNavigation { get; set; }
    }
}
