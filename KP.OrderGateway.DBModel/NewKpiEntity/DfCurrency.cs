using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCurrency
    {
        public string BranchNo { get; set; }
        public string CurrCode { get; set; }
        public string DelFlag { get; set; }
        public string CurrDesc { get; set; }
        public decimal CurrRate { get; set; }
        public string CurrShort { get; set; }
        public string CurrHot { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public byte[] Image { get; set; }
    }
}
