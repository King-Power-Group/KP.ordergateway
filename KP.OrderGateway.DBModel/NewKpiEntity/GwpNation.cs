using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpNation
    {
        public long GwpnationKey { get; set; }
        public string NationCode { get; set; }
        public string GroupCode { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
