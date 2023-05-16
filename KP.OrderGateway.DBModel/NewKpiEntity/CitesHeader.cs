using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CitesHeader
    {
        public long CitesHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string CashierMac { get; set; }
        public string TaxabbNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string ClaimcheckNo { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
        public string PassportNo { get; set; }
        public string CitesAirport { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
