using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingHeader
    {
        public NewHangingHeader()
        {
            NewHanging = new HashSet<NewHanging>();
            NewHangingAllocateHist = new HashSet<NewHangingAllocateHist>();
        }

        public long HangingHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public string PickupCode { get; set; }
        public string HangingTypeCode { get; set; }
        public int? MaxHanging { get; set; }
        public int? FreeHanging { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? IsCanceled { get; set; }

        public virtual NewHangingType HangingTypeCodeNavigation { get; set; }
        public virtual ICollection<NewHanging> NewHanging { get; set; }
        public virtual ICollection<NewHangingAllocateHist> NewHangingAllocateHist { get; set; }
    }
}
