using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscConstrainAnd
    {
        public long DiscconstrainAndKey { get; set; }
        public long DiscconstrainValueKey { get; set; }
        public string FilterField { get; set; }
        public long FilterHeaderKey { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
