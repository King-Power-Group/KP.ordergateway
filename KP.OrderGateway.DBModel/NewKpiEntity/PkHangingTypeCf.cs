using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingTypeCf
    {
        public PkHangingTypeCf()
        {
            PkHangingTypeItem = new HashSet<PkHangingTypeItem>();
            PkHangingTypeItems = new HashSet<PkHangingTypeItems>();
        }

        public string HangingTypeCfcode { get; set; }
        public string HangingTypeCfname { get; set; }

        public virtual ICollection<PkHangingTypeItem> PkHangingTypeItem { get; set; }
        public virtual ICollection<PkHangingTypeItems> PkHangingTypeItems { get; set; }
    }
}
