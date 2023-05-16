using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SolByMacCate
    {
        public DateTime SaleDate { get; set; }
        public string LocCode { get; set; }
        public string MachineNo { get; set; }
        public string CateCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Discount { get; set; }
        public string BranchNo { get; set; }
    }
}
