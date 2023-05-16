using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Inbound
    {
        public string ArticleCode { get; set; }
        public string ArticleName { get; set; }
        public decimal? Qty { get; set; }
    }
}
