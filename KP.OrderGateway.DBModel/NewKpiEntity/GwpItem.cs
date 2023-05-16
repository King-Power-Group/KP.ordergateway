using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpItem
    {
        public long GwpitemKey { get; set; }
        public string MatCode { get; set; }
        public string GroupCode { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
