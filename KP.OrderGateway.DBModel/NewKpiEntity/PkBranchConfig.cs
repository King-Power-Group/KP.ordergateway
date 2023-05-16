using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkBranchConfig
    {
        public string BranchNo { get; set; }
        public bool IsCanceled { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HangNoPrefix { get; set; }
        public byte[] TimeStamp { get; set; }
        public string BranchName { get; set; }
        public bool? IsSortingUsed { get; set; }
    }
}
