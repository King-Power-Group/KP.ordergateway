using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpBrand
    {
        public long GwpbrandKey { get; set; }
        public string BrandCode { get; set; }
        public string GroupCode { get; set; }
        public bool IsExclude { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
