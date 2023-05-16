using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMultiSaveError
    {
        public string BranchNo { get; set; }
        public string ModuleCode { get; set; }
        public string ScreenBase { get; set; }
        public string CnCode { get; set; }
        public decimal Runno { get; set; }
        public string DelFlag { get; set; }
        public string SqlSelect { get; set; }
        public string SqlUpdate { get; set; }
        public string SqlInsert { get; set; }
        public string SqlDelete { get; set; }
        public string SqlCommand { get; set; }
        public string SqlError { get; set; }
        public DateTime? AddDatetime { get; set; }
    }
}
