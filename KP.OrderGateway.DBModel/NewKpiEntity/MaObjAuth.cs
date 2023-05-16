using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MaObjAuth
    {
        public string ModuleCode { get; set; }
        public string AuthCode { get; set; }
        public string AuthName { get; set; }
        public string AuthType { get; set; }
    }
}
