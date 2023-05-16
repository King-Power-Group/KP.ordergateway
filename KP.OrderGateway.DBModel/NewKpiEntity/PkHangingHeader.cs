using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingHeader
    {
        public PkHangingHeader()
        {
            PkHanging = new HashSet<PkHanging>();
            PkHangingAllocateHist = new HashSet<PkHangingAllocateHist>();
        }

        public long HangingHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public string PickupCode { get; set; }
        public string HangingTypeCode { get; set; }
        public int? MaxHanging { get; set; }
        public int? FreeHanging { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool IsCanceled { get; set; }

        public virtual PkHangingType HangingTypeCodeNavigation { get; set; }
        public virtual ICollection<PkHanging> PkHanging { get; set; }
        public virtual ICollection<PkHangingAllocateHist> PkHangingAllocateHist { get; set; }
    }
}
