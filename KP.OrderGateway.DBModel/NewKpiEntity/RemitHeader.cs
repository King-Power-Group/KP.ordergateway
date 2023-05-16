using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RemitHeader
    {
        public RemitHeader()
        {
            RemitDetail = new HashSet<RemitDetail>();
        }

        public long RemitHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string CashierCode { get; set; }
        public string Comment { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public string ApproveUser { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual RemitShortOver RemitShortOver { get; set; }
        public virtual ICollection<RemitDetail> RemitDetail { get; set; }
    }
}
