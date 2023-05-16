using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfInshopTrans
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public string CountryCode { get; set; }
        public int Pax { get; set; }
        public decimal Rate { get; set; }
        public decimal GuideHead { get; set; }
        public decimal GuidePark { get; set; }
        public decimal DriverPark { get; set; }
        public decimal Total { get; set; }
    }
}
