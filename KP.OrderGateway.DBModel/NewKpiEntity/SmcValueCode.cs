using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcValueCode
    {
        public string ValueCode { get; set; }
        public string ValueDesc { get; set; }
        public string ValueShort { get; set; }
        public string AllowBranch { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? AddDatetime { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string DelFlag { get; set; }
        public bool? IsCorporate { get; set; }
    }
}
