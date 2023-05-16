using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstArticleRemainHistory
    {
        public long Id { get; set; }
        public string ArticleCode { get; set; }
        public string StoreSite { get; set; }
        public string StoreLocation { get; set; }
        public decimal RemainQty { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
