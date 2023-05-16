using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TastateDtl
    {
        public long TastateDtlKey { get; set; }
        public long TastateHdrKey { get; set; }
        public int? GroupFlag { get; set; }
        public string CountryCode { get; set; }
        public string CateCode { get; set; }
        public string BrandCode { get; set; }
        public int? CheckFrom { get; set; }
        public decimal? Range1 { get; set; }
        public decimal? Range2 { get; set; }
        public decimal? TrCondAmt { get; set; }
        public int? CalcType { get; set; }
        public string Description { get; set; }
        public string AccountCode { get; set; }
        public decimal? SySaleAmount { get; set; }
        public decimal? SyAmount { get; set; }
        public decimal? SaleAmount { get; set; }
        public decimal? Amount { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDateTime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
