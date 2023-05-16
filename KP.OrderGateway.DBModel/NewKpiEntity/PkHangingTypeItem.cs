using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingTypeItem
    {
        public long HangingTypeItemKey { get; set; }
        public string HangingTypeCode { get; set; }
        public string SearchCode { get; set; }
        public string HangingTypeCfcode { get; set; }
        public string SortOrder { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDateTime { get; set; }
        public DateTime UpdateDatetime { get; set; }

        public virtual PkHangingTypeCf HangingTypeCfcodeNavigation { get; set; }
        public virtual PkHangingType HangingTypeCodeNavigation { get; set; }
    }
}
