using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfAuth
    {
        public string BranchNo { get; set; }
        public string UserCode { get; set; }
        public string ModuleCode { get; set; }
        public string AuthCode { get; set; }
        public string ActCode { get; set; }
    }
}
