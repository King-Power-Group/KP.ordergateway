using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoSpending
    {
        public string BranchNo { get; set; }
        public decimal Runno { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
