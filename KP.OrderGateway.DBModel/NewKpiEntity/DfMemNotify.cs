using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMemNotify
    {
        public string BranchNo { get; set; }
        public DateTime DataDate { get; set; }
        public string DataTime { get; set; }
        public string MemberId { get; set; }
        public string UserAdd { get; set; }
    }
}
