using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSelectItem
    {
        public string BranchNo { get; set; }
        public string OperGrp { get; set; }
        public string ModuleCode { get; set; }
        public string AuthCode { get; set; }
        public string SelectCode { get; set; }
        public string CtrlName { get; set; }
        public string StrName { get; set; }
        public string TxtSelect { get; set; }
        public int Ctrltype { get; set; }
    }
}
