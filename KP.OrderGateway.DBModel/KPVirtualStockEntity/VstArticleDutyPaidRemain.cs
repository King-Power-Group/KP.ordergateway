using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstArticleDutyPaidRemain
    {
        public long Id { get; set; }
        public string ArticleCode { get; set; }
        public string ArticleCodeDutyPaid { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
