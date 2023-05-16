using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class HoldBoxTbag
    {
        public long HoldBoxTbagKey { get; set; }
        public long HoldBoxHeaderKey { get; set; }
        public int GroupNo { get; set; }
        public string BranchNo { get; set; }
        public string TbagCode { get; set; }

        public virtual HoldBoxFlight HoldBoxFlight { get; set; }
        public virtual HoldBoxHeader HoldBoxHeaderKeyNavigation { get; set; }
    }
}
