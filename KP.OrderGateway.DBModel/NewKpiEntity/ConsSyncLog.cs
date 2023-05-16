using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ConsSyncLog
    {
        public long SyncKey { get; set; }
        public string TableName { get; set; }
        public long StartKey { get; set; }
        public long FinishKey { get; set; }
        public DateTime? SyncDt { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
