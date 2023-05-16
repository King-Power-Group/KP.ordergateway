using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfInv
    {
        public string BranchNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string ClaimcheckNo { get; set; }
        public string MachineNo { get; set; }
        public string TaxabbNo { get; set; }
        public string InvNo { get; set; }
        public string TelephoneNo { get; set; }
        public string CustName { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal VatAmt { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ShoppingCard { get; set; }
        public string TaxNo { get; set; }
        public string Company { get; set; }
        public string Branch { get; set; }
    }
}
