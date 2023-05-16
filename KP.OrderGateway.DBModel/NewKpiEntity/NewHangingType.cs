using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingType
    {
        public NewHangingType()
        {
            NewHangingHeader = new HashSet<NewHangingHeader>();
            NewHangingTypeHead = new HashSet<NewHangingTypeHead>();
            NewHangingTypeItem = new HashSet<NewHangingTypeItem>();
        }

        public string HangingTypeCode { get; set; }
        public string HangingTypeName { get; set; }
        public bool? IsCanceled { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? AllowTransferIn { get; set; }
        public string SortOrder { get; set; }

        public virtual ICollection<NewHangingHeader> NewHangingHeader { get; set; }
        public virtual ICollection<NewHangingTypeHead> NewHangingTypeHead { get; set; }
        public virtual ICollection<NewHangingTypeItem> NewHangingTypeItem { get; set; }
    }
}
