using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvTastatement
    {
        public long PvHeaderKey { get; set; }
        public long TastateHdrKey { get; set; }
        public string BranchNo { get; set; }
        public long AgentConfigKey { get; set; }
        public string ChequeReceiver { get; set; }
        public DateTime PeriodDt { get; set; }
        public string AgentCode { get; set; }
        public decimal? Saleamount { get; set; }
        public int? Pax { get; set; }
        public decimal? Commission { get; set; }
        public decimal? Perhead { get; set; }
        public decimal? Transport { get; set; }
    }
}
