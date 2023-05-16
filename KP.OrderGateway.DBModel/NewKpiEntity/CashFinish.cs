using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CashFinish
    {
        public long HeaderKey { get; set; }
        public string KeySearch { get; set; }
        public DateTime AddDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
