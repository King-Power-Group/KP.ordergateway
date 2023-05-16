using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkPackingNo
    {
        public PkPackingNo()
        {
            InverseCancelToNoNavigation = new HashSet<PkPackingNo>();
        }

        public string PackingNo { get; set; }
        public string BranchNo { get; set; }
        public long SubSohdrRecNo { get; set; }
        public DateTime? CreateDt { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? CancelDt { get; set; }
        public string CancelToNo { get; set; }

        public virtual PkPackingNo CancelToNoNavigation { get; set; }
        public virtual DfSubsohdr DfSubsohdr { get; set; }
        public virtual ICollection<PkPackingNo> InverseCancelToNoNavigation { get; set; }
    }
}
