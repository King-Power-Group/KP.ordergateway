using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoPutrans
    {
        public string BranchNo { get; set; }
        public double Runno { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
