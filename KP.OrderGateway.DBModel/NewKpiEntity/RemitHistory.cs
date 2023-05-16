using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RemitHistory
    {
        public string BranchNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string CashierCode { get; set; }
        public int RemitLineNo { get; set; }
        public DateTime UpdateDt { get; set; }
        public string MethodGroup { get; set; }
        public string BankOfEdc { get; set; }
        public string MethodCode { get; set; }
        public string CurrCode { get; set; }
        public decimal CurrRate { get; set; }
        public decimal Qty { get; set; }
        public decimal AmountCurr { get; set; }
        public decimal Amount { get; set; }
        public string UpdateUser { get; set; }
        public string Status { get; set; }
    }
}
