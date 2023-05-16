using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfVoucher
    {
        public string VoucherNo { get; set; }
        public string BranchNo { get; set; }
        public DateTime DataDate { get; set; }
        public string MachineNo { get; set; }
        public string DocNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string KeySearch { get; set; }
        public string Flag { get; set; }
        public string MethodCode { get; set; }
    }
}
