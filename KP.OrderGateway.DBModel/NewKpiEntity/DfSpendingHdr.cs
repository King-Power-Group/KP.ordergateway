using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSpendingHdr
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public string TourCode { get; set; }
        public string AgentCode { get; set; }
        public string SubagentCode { get; set; }
        public DateTime? DocDate { get; set; }
        public string CancelToDoc { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? AddDatetime { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public string PaidType { get; set; }
        public string ReceiveBy { get; set; }
    }
}
