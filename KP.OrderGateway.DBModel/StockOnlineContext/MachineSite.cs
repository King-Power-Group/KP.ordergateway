using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.StockOnlineContext
{
    public partial class MachineSite
    {
        public long Key { get; set; }
        public string MachineNo { get; set; }
        public string SiteCode { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
