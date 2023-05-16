using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfRefundDoc
    {
        public string RunNo { get; set; }
        public bool IsCancel { get; set; }
        public DateTime DataDate { get; set; }
        public string ShoppingCard { get; set; }
        public string CustName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string PaidBy { get; set; }
        public string PassportNo { get; set; }
        public decimal Amount { get; set; }
        public decimal Vat { get; set; }
        public string Reasons { get; set; }
        public string Comments { get; set; }
        public string Remark { get; set; }
        public DateTime? PrintDt { get; set; }
        public string ClaimCheck1 { get; set; }
        public string ClaimCheck2 { get; set; }
        public string ClaimCheck { get; set; }
        public string ShortName { get; set; }
        public bool IsNoPurchase { get; set; }
        public int? OrderNo { get; set; }
        public bool? IsTempDoc { get; set; }
    }
}
