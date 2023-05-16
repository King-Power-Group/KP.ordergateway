using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingTypeItems
    {
        public long ItemKey { get; set; }
        public string HangingTypeCfcode { get; set; }
        public string Operation { get; set; }
        public string SearchCode { get; set; }
        public long TypeGroupKey { get; set; }

        public virtual PkHangingTypeCf HangingTypeCfcodeNavigation { get; set; }
        public virtual PkHangingTypeOper OperationNavigation { get; set; }
        public virtual PkHangingTypeHead TypeGroupKeyNavigation { get; set; }
    }
}
