using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoNoshow
    {
        public string BranchNo { get; set; }
        public string Code { get; set; }
        public double Runno { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
