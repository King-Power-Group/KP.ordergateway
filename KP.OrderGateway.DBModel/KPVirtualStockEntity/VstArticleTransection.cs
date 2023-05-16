using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstArticleTransection
    {
        public long TransectionId { get; set; }
        public long SessionId { get; set; }
        public string ArticleCode { get; set; }
        public decimal UseQty { get; set; }
        public string CreateBy { get; set; }
        public string Movement { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeductRemain { get; set; }
    }
}
