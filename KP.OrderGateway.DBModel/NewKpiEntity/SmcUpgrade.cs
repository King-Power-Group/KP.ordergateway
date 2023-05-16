using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcUpgrade
    {
        public string MemberId { get; set; }
        public int DocNo { get; set; }
        public string OldCardTypeCode { get; set; }
        public string OldDiscount { get; set; }
        public string NewCardTypeCode { get; set; }
        public string NewDiscount { get; set; }
        public DateTime? DocDate { get; set; }
        public long? HeaderKey { get; set; }
        public long UpgradeKey { get; set; }
    }
}
