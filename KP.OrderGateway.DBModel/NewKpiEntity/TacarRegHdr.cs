using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TacarRegHdr
    {
        public long TacarRegHdrKey { get; set; }
        public string BranchNo { get; set; }
        public DateTime PeriodDt { get; set; }
        public string AgentCode { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public long? TastateHdrKey { get; set; }
    }
}
