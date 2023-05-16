using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunNoRefundNoPur
    {
        public string BranchNo { get; set; }
        public string Plant { get; set; }
        public string PickUpCode { get; set; }
        public double RunNo { get; set; }
        public string Prefix { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
