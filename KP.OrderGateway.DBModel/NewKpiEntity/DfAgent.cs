using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfAgent
    {
        public string BranchNo { get; set; }
        public string AgentCode { get; set; }
        public string AgentName { get; set; }
        public decimal? DiscCommRate { get; set; }
        public decimal? NodiscCommRate { get; set; }
        public decimal? PerCust { get; set; }
        public bool CommPaid { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string AgentStatus { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string CountryCode { get; set; }
        public string Tel { get; set; }
        public string TaxId { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Contactname { get; set; }
        public string RefCode01 { get; set; }
        public string RefCode02 { get; set; }
        public string DefaultCustType { get; set; }
    }
}
