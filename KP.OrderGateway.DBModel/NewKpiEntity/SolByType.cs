using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SolByType
    {
        public string TypeCode { get; set; }
        public DateTime SaleDate { get; set; }
        public string LocCode { get; set; }
        public string MachineNo { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Key4 { get; set; }
        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public string BranchNo { get; set; }
    }
}
