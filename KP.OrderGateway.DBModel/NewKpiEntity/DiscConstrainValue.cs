using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscConstrainValue
    {
        public long DiscconstrainValueKey { get; set; }
        public string DiscconstrainHdcode { get; set; }
        public string FilterFiled { get; set; }
        public long FilterHeaderKey { get; set; }
        public decimal MaxPercentDiscount { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
