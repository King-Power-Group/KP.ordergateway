using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingTypeCf
    {
        public NewHangingTypeCf()
        {
            NewHangingTypeItem = new HashSet<NewHangingTypeItem>();
            NewHangingTypeItems = new HashSet<NewHangingTypeItems>();
        }

        public string HangingTypeCfcode { get; set; }
        public string HangingTypeCfname { get; set; }

        public virtual ICollection<NewHangingTypeItem> NewHangingTypeItem { get; set; }
        public virtual ICollection<NewHangingTypeItems> NewHangingTypeItems { get; set; }
    }
}
