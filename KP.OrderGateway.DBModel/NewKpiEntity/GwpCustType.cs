using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpCustType
    {
        public long GwpcustTypeKey { get; set; }
        public string CustTypeCode { get; set; }
        public string GroupCode { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
