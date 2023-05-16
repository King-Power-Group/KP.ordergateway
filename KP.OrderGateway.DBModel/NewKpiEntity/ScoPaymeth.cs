using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ScoPaymeth
    {
        public string MethodCode { get; set; }
        public bool? IsCancel { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual DfPaymeth MethodCodeNavigation { get; set; }
    }
}
