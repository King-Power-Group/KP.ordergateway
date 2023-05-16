using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.StockOnlineContext
{
    public partial class Machine
    {
        public string MachineNo { get; set; }
        public string MachineIp { get; set; }
        public string MachineName { get; set; }
        public bool? IsCancel { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
