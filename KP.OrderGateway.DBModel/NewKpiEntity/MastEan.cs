using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastEan
    {
        public string Eancode { get; set; }
        public string ArticleCode { get; set; }
        public bool IsCancel { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual MastArticle ArticleCodeNavigation { get; set; }
    }
}
