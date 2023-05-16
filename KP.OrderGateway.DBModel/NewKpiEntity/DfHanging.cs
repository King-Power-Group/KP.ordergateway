using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfHanging
    {
        public string BranchNo { get; set; }
        public string PickupCode { get; set; }
        public int HangingNo { get; set; }
        public string OpaqNo { get; set; }
        public bool? InTransit { get; set; }
    }
}
