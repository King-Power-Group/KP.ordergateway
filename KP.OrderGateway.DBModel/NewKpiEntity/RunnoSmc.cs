using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoSmc
    {
        public string BranchNo { get; set; }
        public long? Runno { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
