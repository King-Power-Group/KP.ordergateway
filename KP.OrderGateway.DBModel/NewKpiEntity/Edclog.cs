using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Edclog
    {
        public long EdclogKey { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string CashierMac { get; set; }
        public string CashierCode { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public DateTime AddDt { get; set; }
    }
}
