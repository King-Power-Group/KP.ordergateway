using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingType
    {
        public PkHangingType()
        {
            PkHangingHeader = new HashSet<PkHangingHeader>();
            PkHangingTypeHead = new HashSet<PkHangingTypeHead>();
            PkHangingTypeItem = new HashSet<PkHangingTypeItem>();
        }

        public string HangingTypeCode { get; set; }
        public string HangingTypeName { get; set; }
        public bool IsCanceled { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool AllowTransferIn { get; set; }
        public string SortOrder { get; set; }

        public virtual ICollection<PkHangingHeader> PkHangingHeader { get; set; }
        public virtual ICollection<PkHangingTypeHead> PkHangingTypeHead { get; set; }
        public virtual ICollection<PkHangingTypeItem> PkHangingTypeItem { get; set; }
    }
}
