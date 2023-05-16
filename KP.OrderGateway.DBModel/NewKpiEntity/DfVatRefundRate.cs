using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfVatRefundRate
    {
        public string BranchNo { get; set; }
        public string RateCode { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }
        public decimal Rate { get; set; }
        public bool IsPercent { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public decimal? ServiceFee { get; set; }
    }
}
