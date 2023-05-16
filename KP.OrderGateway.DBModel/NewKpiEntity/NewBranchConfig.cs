using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewBranchConfig
    {
        public string BranchNo { get; set; }
        public bool? IsCanceled { get; set; }
        public bool? IsMainHanging { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RunningPrefix { get; set; }
        public string OfflineHangingType { get; set; }
    }
}
