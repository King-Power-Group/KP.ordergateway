using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscAuthHeader
    {
        public long DiscAuthHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public decimal FromPercent { get; set; }
        public decimal ToPercent { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
