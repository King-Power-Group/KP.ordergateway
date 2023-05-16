using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfUpdateLog
    {
        public string BranchNo { get; set; }
        public string ModuleCode { get; set; }
        public string FrmName { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateTime { get; set; }
        public string IpAddress { get; set; }
        public string KeyCode { get; set; }
        public string UserCode { get; set; }
        public string UpdateMsg { get; set; }
    }
}
