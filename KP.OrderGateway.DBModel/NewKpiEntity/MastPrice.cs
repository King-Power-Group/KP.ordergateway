using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastPrice
    {
        public long MastPriceKey { get; set; }
        public string CondtypeCode { get; set; }
        public string PriceList { get; set; }
        public string Dchannel { get; set; }
        public string ArticleCode { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public decimal? Price { get; set; }
        public decimal? Qty { get; set; }
        public string CurrencyCode { get; set; }
        public byte[] Timestamp { get; set; }
        public bool IsCanceled { get; set; }

        public virtual MastArticle ArticleCodeNavigation { get; set; }
    }
}
