using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCommRate
    {
        public string BranchNo { get; set; }
        public string AgentCode { get; set; }
        public decimal CommRate { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
