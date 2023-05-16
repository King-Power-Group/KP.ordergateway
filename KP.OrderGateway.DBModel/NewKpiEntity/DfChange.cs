using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfChange
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public decimal AmountCurr { get; set; }
        public decimal Amount1 { get; set; }
        public string CurrCode1 { get; set; }
        public decimal Amount2 { get; set; }
        public string CurrCode2 { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
