using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstArticleSession
    {
        public long SessionId { get; set; }
        public string SessionKey { get; set; }
        public string SessionStatus { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime? CreateDate { get; set; }
        public string SessionRef { get; set; }
    }
}
