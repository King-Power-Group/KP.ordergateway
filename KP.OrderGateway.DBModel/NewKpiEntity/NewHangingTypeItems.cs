using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingTypeItems
    {
        public long ItemKey { get; set; }
        public string HangingTypeCfcode { get; set; }
        public string Operation { get; set; }
        public string SearchCode { get; set; }
        public long TypeGroupKey { get; set; }

        public virtual NewHangingTypeCf HangingTypeCfcodeNavigation { get; set; }
        public virtual NewHangingTypeOper OperationNavigation { get; set; }
        public virtual NewHangingTypeHead TypeGroupKeyNavigation { get; set; }
    }
}
