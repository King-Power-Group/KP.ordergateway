using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcUpcardCond
    {
        public string BaseCardTypeCode { get; set; }
        public string UpgradeCardTypeCode { get; set; }
        public decimal Netsales { get; set; }
        public string DiscountCode { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserUpdate { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
