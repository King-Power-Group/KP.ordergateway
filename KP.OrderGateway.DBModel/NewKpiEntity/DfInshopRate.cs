using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfInshopRate
    {
        public string BranchNo { get; set; }
        public string InshopType { get; set; }
        public string AgentCode { get; set; }
        public string CountryCode { get; set; }
        public string InshopTypeCode { get; set; }
        public int PaxMin { get; set; }
        public int PaxMax { get; set; }
        public decimal Rate { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
