using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrPaydtlExtend
    {
        public string BranchNo { get; set; }
        public string DocGroup { get; set; }
        public string DocNo { get; set; }
        public string TourCode { get; set; }
        public decimal ExtraHead { get; set; }
        public decimal ExtraComm { get; set; }
    }
}
