using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MemberCard
    {
        public string CardTypeCode { get; set; }
        public string MemberId { get; set; }
        public short Runno { get; set; }
        public string EmbossId { get; set; }
        public string EmbossName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ValidTerm { get; set; }
        public DateTime? IssueDate { get; set; }
        public short CardStatus { get; set; }
        public string ReasonId { get; set; }
        public string ShoppingCard { get; set; }
        public string CardTypeId { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
