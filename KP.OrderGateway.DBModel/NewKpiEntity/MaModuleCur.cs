using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MaModuleCur
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleVersion { get; set; }
        public byte[] ModuleExe { get; set; }
        public decimal FileSize { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
