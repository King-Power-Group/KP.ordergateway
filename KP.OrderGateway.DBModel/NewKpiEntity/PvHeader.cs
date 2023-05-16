using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvHeader
    {
        public long PvHeaderKey { get; set; }
        public string AgentCode { get; set; }
        public long AgentConfigKey { get; set; }
        public DateTime? PeriodDt { get; set; }
        public DateTime? PrepareDt { get; set; }
        public DateTime? IssueDt { get; set; }
        public string BankCode { get; set; }
        public string Chequereceiver { get; set; }
        public decimal Commission { get; set; }
        public decimal Perhead { get; set; }
        public decimal Transport { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public long Commissiontypekey { get; set; }
        public long Expensetypekey { get; set; }
        public int? CertificateWt { get; set; }
        public string CertificateDoc { get; set; }
        public string TaxOrCardId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string DownloadDoc { get; set; }
        public string AgentName { get; set; }
    }
}
