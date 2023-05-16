using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrPayhdr
    {
        public string BranchNo { get; set; }
        public string DocGroup { get; set; }
        public string DocNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public string AgentCode { get; set; }
        public string SubagentCode { get; set; }
        public decimal ExtraComm { get; set; }
        public decimal ExtraHead { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? PeriodDt { get; set; }
        public long? TastateHdrKey { get; set; }
        public decimal? WhtRate { get; set; }
        public decimal? WhtAmount { get; set; }
        public decimal? Vat { get; set; }
    }
}
