using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TastateHdr
    {
        public long TastateHdrKey { get; set; }
        public string BranchNo { get; set; }
        public string AgentCode { get; set; }
        public long AgentConfigKey { get; set; }
        public string ChequeReceiver { get; set; }
        public DateTime PeriodDt { get; set; }
        public int? SyPax { get; set; }
        public decimal? SySaleAmount { get; set; }
        public decimal? SyCommission { get; set; }
        public decimal? SyPerHead { get; set; }
        public decimal? SyTransport { get; set; }
        public int? Pax { get; set; }
        public decimal? SaleAmount { get; set; }
        public decimal? Commission { get; set; }
        public decimal? Perhead { get; set; }
        public decimal? Transport { get; set; }
        public string TaxOrCardId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string RefTrPayHdr { get; set; }
        public int NoOfCopy { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? PaidAmount { get; set; }
        public bool? PrintPv { get; set; }
        public string TastateType { get; set; }
        public string AgentName { get; set; }
    }
}
