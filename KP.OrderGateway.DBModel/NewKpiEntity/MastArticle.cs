using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastArticle
    {
        public MastArticle()
        {
            MastEan = new HashSet<MastEan>();
            MastPrice = new HashSet<MastPrice>();
        }

        public string ArticleCode { get; set; }
        public DateTime ActivationDt { get; set; }
        public string Unit { get; set; }
        public string Gtin { get; set; }
        public string Mccode { get; set; }
        public bool IsQtyprohibited { get; set; }
        public bool IsOpenPrice { get; set; }
        public bool IsSaleBlock { get; set; }
        public string ArticleTypeCode { get; set; }
        public string ArticleName { get; set; }
        public string BrandCode { get; set; }
        public string VatCode { get; set; }
        public byte[] Timestamp { get; set; }
        public bool IsCanceled { get; set; }
        public decimal? Volume { get; set; }

        public virtual MastBrand BrandCodeNavigation { get; set; }
        public virtual MastMc MccodeNavigation { get; set; }
        public virtual ICollection<MastEan> MastEan { get; set; }
        public virtual ICollection<MastPrice> MastPrice { get; set; }
    }
}
