using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TacarRegDtl
    {
        public long TacarRegDtlKey { get; set; }
        public long TacarRegHdrKey { get; set; }
        public string TourCode { get; set; }
        public string CarLicense { get; set; }
        public string ShwLicense { get; set; }
        public string FeeType { get; set; }
        public int Pax { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
