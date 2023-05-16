using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MainConnectStatus
    {
        public string BranchNo { get; set; }
        public DateTime? LastDisconnectDateTime { get; set; }
        public int SecondReconnect { get; set; }
    }
}
