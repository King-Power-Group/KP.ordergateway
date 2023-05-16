using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrPayCateBrand
    {
        public string BranchNo { get; set; }
        public string DocGroup { get; set; }
        public string DocNo { get; set; }
        public string TourCode { get; set; }
        public string CountryCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public string CateCode { get; set; }
        public string BrandCode { get; set; }
        public string MarketCountry { get; set; }
        public string MarketCategory { get; set; }
        public string MarketBrand { get; set; }
        public decimal Amount { get; set; }
        public decimal Perhead { get; set; }
        public decimal Commission { get; set; }
    }
}
