using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SolTarget
    {
        public DateTime SaleDate { get; set; }
        public string LocCode { get; set; }
        public string CateCode { get; set; }
        public decimal? TargetAmount { get; set; }
        public string BranchNo { get; set; }
    }
}
