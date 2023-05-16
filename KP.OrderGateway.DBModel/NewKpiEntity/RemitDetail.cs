using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RemitDetail
    {
        public long RemitDetailKey { get; set; }
        public long RemitHeaderKey { get; set; }
        public int RemitLineNo { get; set; }
        public bool ActualData { get; set; }
        public string MethodGroup { get; set; }
        public string BankOfEdc { get; set; }
        public string MethodCode { get; set; }
        public string CurrCode { get; set; }
        public decimal CurrRate { get; set; }
        public decimal Qty { get; set; }
        public decimal AmountCurr { get; set; }
        public decimal Amount { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual RemitHeader RemitHeaderKeyNavigation { get; set; }
    }
}
