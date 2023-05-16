using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DdsIdocLog
    {
        public long IdocLogKey { get; set; }
        public string IdocNo { get; set; }
        public string BasicType { get; set; }
        public string MessageType { get; set; }
        public DateTime? DocDt { get; set; }
        public string IdocText { get; set; }
        public string FileName { get; set; }
        public string PathName { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
