using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingTypeHead
    {
        public PkHangingTypeHead()
        {
            PkHangingTypeItems = new HashSet<PkHangingTypeItems>();
        }

        public long TypeGroupKey { get; set; }
        public string HangingTypeCode { get; set; }
        public string GroupOper { get; set; }
        public long? ParentKey { get; set; }
        public int OrderNo { get; set; }

        public virtual PkHangingType HangingTypeCodeNavigation { get; set; }
        public virtual ICollection<PkHangingTypeItems> PkHangingTypeItems { get; set; }
    }
}
