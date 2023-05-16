using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSpendingRate
    {
        public string BranchNo { get; set; }
        public string CountryCode { get; set; }
        public decimal Spending { get; set; }
        public decimal SaleAmount { get; set; }
        public string DelFlag { get; set; }
        public decimal CommRate { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public decimal Perhead { get; set; }
    }
}
