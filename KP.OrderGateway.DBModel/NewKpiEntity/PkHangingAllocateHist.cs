using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingAllocateHist
    {
        public long HangingAllocateHistKey { get; set; }
        public long HangingHeaderKey { get; set; }
        public int? OldCount { get; set; }
        public int? NewCount { get; set; }
        public string UserCode { get; set; }
        public DateTime? CreatDt { get; set; }
        public string IpAddress { get; set; }

        public virtual PkHangingHeader HangingHeaderKeyNavigation { get; set; }
    }
}
