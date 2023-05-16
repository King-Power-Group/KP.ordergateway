using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfAppvPvDtl
    {
        public string DocNo { get; set; }
        public int Runno { get; set; }
        public int PvHeaderKey { get; set; }
        public DateTime Issuedt { get; set; }
        public string AgentCode { get; set; }
        public string Chequereceiver { get; set; }
        public string Description { get; set; }
        public string CurrCode { get; set; }
        public decimal AmtCurrency { get; set; }
        public decimal AmtBaht { get; set; }
        public string Remark { get; set; }
    }
}
