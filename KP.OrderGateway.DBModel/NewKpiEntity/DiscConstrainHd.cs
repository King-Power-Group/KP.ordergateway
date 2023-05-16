using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscConstrainHd
    {
        public string DiscconstrainHdcode { get; set; }
        public string DiscconstrainHdname { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
