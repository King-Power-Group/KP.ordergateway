using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TcPayHdr
    {
        public string DocNo { get; set; }
        public string BranchNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public string AgentCode { get; set; }
        public string SubagentCode { get; set; }
        public int Pax { get; set; }
        public decimal Rate { get; set; }
        public decimal Perhead { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool PrintFlag { get; set; }
        public int NoOfReprint { get; set; }
    }
}
