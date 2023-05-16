using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoRefundGrp
    {
        public string BranchNo { get; set; }
        public string Plant { get; set; }
        public string PickupCode { get; set; }
        public double Runno { get; set; }
        public string Prefix { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
