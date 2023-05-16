using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCommDtl
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public int LineNo { get; set; }
        public string CateCode { get; set; }
        public string BrandCode { get; set; }
        public decimal? CommRate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Net { get; set; }
    }
}
