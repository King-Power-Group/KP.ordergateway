using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MaModuleHist
    {
        public string ModuleCode { get; set; }
        public string Version { get; set; }
        public string Remark { get; set; }
        public DateTime VerDatetime { get; set; }
        public string VerBy { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
