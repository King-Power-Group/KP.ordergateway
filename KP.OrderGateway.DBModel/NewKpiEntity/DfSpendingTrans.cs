using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSpendingTrans
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public string CountryCode { get; set; }
        public decimal? Spending { get; set; }
        public decimal? Net { get; set; }
        public int? Pax { get; set; }
        public decimal? CommRate { get; set; }
        public decimal? CommAmount { get; set; }
        public decimal? SpendingReq { get; set; }
        public decimal? SaleamountReq { get; set; }
        public decimal? Perhead { get; set; }
        public decimal? PerheadAmount { get; set; }
        public decimal CommSpendingReq { get; set; }
        public decimal CommSaleamtReq { get; set; }
        public decimal PhSpendingReq { get; set; }
        public decimal PhSaleamtReq { get; set; }
    }
}
