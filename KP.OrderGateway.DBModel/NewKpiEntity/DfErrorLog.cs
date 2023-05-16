using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfErrorLog
    {
        public string BranchNo { get; set; }
        public string ModuleCode { get; set; }
        public DateTime ErrDate { get; set; }
        public DateTime ErrTime { get; set; }
        public string ErrSource { get; set; }
        public string ErrMessage { get; set; }
        public string ErrStacktrace { get; set; }
        public string ErrSql { get; set; }
        public string IpAddress { get; set; }
        public string UserCode { get; set; }
        public string Version { get; set; }
        public string Db { get; set; }
        public string Server { get; set; }
    }
}
