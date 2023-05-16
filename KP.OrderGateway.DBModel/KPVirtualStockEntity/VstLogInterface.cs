using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstLogInterface
    {
        public long LogInterfId { get; set; }
        public long ParentLogInterfId { get; set; }
        public string LogInterfType { get; set; }
        public string LogInterfStatus { get; set; }
        public string LogInterfStatusDesc { get; set; }
        public DateTime? LogInterfDt { get; set; }
        public string IpAddress { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
