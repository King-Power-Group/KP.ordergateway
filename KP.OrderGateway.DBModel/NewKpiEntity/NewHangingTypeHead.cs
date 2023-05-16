using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingTypeHead
    {
        public NewHangingTypeHead()
        {
            NewHangingTypeItems = new HashSet<NewHangingTypeItems>();
        }

        public long TypeGroupKey { get; set; }
        public string HangingTypeCode { get; set; }
        public string GroupOper { get; set; }
        public long? ParentKey { get; set; }
        public int OrderNo { get; set; }

        public virtual NewHangingType HangingTypeCodeNavigation { get; set; }
        public virtual ICollection<NewHangingTypeItems> NewHangingTypeItems { get; set; }
    }
}
