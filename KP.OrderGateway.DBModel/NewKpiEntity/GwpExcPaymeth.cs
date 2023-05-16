using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpExcPaymeth
    {
        public long ExPaymethKey { get; set; }
        public string MethodCode { get; set; }
        public string GroupCode { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
