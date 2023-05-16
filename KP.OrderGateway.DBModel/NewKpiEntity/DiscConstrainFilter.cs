using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscConstrainFilter
    {
        public long DiscconstrainFilterKey { get; set; }
        public string DiscconstrainHdcode { get; set; }
        public string FilterField { get; set; }
        public long FilterHeaderKey { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
