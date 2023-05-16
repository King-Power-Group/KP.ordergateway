using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfVatRefundIncentive
    {
        public string BranchNo { get; set; }
        public string RateCode { get; set; }
        public int QtyFrom { get; set; }
        public int QtyTo { get; set; }
        public decimal Rate { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
