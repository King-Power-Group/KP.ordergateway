using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvSummary
    {
        public long PvSummaryKey { get; set; }
        public long PvHeaderKey { get; set; }
        public string ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public decimal Total { get; set; }
        public decimal Vat { get; set; }
        public decimal Wt { get; set; }
        public decimal Netpaid { get; set; }
        public string BranchNo { get; set; }
        public long? TastateHdrKey { get; set; }
    }
}
