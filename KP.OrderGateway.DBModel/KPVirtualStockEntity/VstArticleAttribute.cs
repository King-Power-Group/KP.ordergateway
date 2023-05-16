using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstArticleAttribute
    {
        public long Id { get; set; }
        public string ArticleCode { get; set; }
        public string AttrGroup { get; set; }
        public string AttrName { get; set; }
        public string AttrValue { get; set; }
        public DateTime LastModified { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
