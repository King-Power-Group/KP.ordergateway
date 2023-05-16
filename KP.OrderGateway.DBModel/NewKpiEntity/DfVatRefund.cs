using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfVatRefund
    {
        public string BookNo { get; set; }
        public string RunNo { get; set; }
        public bool IsCancel { get; set; }
        public DateTime DataDate { get; set; }
        public string ShoppingCard { get; set; }
        public string CustName { get; set; }
        public string PassportNo { get; set; }
        public decimal Amount { get; set; }
        public decimal Vat { get; set; }
        public decimal? VatRefundable { get; set; }
        public string Remark { get; set; }
        public string AddUser { get; set; }
        public string PrintUser { get; set; }
        public DateTime? AddDt { get; set; }
    }
}
