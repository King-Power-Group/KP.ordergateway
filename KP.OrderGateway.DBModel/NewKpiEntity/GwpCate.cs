using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpCate
    {
        public long GwpcateKey { get; set; }
        public string CateCode { get; set; }
        public string GroupCode { get; set; }
        public bool IsExclude { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
