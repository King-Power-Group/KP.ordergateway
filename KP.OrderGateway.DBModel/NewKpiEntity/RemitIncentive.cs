using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RemitIncentive
    {
        public string BranchNo { get; set; }
        public string RateCode { get; set; }
        public int StaffLevel { get; set; }
        public string Type { get; set; }
        public decimal FromNo { get; set; }
        public decimal ToNo { get; set; }
        public decimal Rate { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
