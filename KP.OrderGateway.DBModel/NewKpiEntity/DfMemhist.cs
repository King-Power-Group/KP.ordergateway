using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMemhist
    {
        public string MemberId { get; set; }
        public string ShoppingCard { get; set; }
        public DateTime? StartDate { get; set; }
        public int? ValidTerm { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateOfApply { get; set; }
        public int CardStatus { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string Reason { get; set; }
        public DateTime? IssueDate { get; set; }
    }
}
