using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSubagent
    {
        public string BranchNo { get; set; }
        public string SubagentCode { get; set; }
        public string AgentCode { get; set; }
        public string SubagentType { get; set; }
        public string SubagentName { get; set; }
        public decimal? DiscCommRate { get; set; }
        public decimal? NodiscCommRate { get; set; }
        public decimal? PerCust { get; set; }
        public bool? CommPaid { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string LevelCode { get; set; }
        public string GuideLicense { get; set; }
        public string PassportNo { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string Hobby { get; set; }
        public string RefCode01 { get; set; }
        public string RefCode02 { get; set; }
        public string GuideGroupCode { get; set; }
        public string MemRef { get; set; }
        public string GuideIdcode { get; set; }
        public DateTime? ExpireId { get; set; }
        public DateTime? ExpirePass { get; set; }
        public DateTime? ExpireLicense { get; set; }
        public bool? MemcardTaken { get; set; }
        public string Email { get; set; }
        public string Ims { get; set; }
    }
}
