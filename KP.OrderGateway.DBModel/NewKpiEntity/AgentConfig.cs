using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class AgentConfig
    {
        public long AgentConfigKey { get; set; }
        public string BranchNo { get; set; }
        public string AgentCode { get; set; }
        public long CommissionTypeKey { get; set; }
        public string ChequeReceiver { get; set; }
        public long ExpenseTypeKey { get; set; }
        public string TaxOrCardId { get; set; }
        public bool IsCancelled { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public bool? IsAutoPv { get; set; }
        public int Wt { get; set; }
        public DateTime? RegisterVat { get; set; }
        public string BankCode { get; set; }
        public string AccountNo { get; set; }
    }
}
