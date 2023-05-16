using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class InshopExtraRateCfg
    {
        public long InshopExtraRateCfgkey { get; set; }
        public DateTime? ValidFromDt { get; set; }
        public DateTime? VallidToDt { get; set; }
        public decimal? BahtPerHead { get; set; }
        public string TourCountryCode { get; set; }
        public TimeSpan? PaidStartDt { get; set; }
        public TimeSpan? PaidEndDt { get; set; }
    }
}
