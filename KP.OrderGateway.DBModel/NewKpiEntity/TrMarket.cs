using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrMarket
    {
        public int TrMarketKey { get; set; }
        public string DocGroup { get; set; }
        public string DocNo { get; set; }
        public string AgentCode { get; set; }
        public int GroupFlag { get; set; }
        public string CountryCode { get; set; }
        public string CateCode { get; set; }
        public string BrandCode { get; set; }
        public int FlightGroup { get; set; }
        public int PaidType { get; set; }
        public decimal Range1 { get; set; }
        public decimal Range2 { get; set; }
        public decimal Amount { get; set; }
        public int CalcType { get; set; }
        public decimal SalePax { get; set; }
        public decimal CommPerhead { get; set; }
        public DateTime DtPeriod { get; set; }
    }
}
