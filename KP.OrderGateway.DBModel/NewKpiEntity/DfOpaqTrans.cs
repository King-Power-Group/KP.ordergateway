using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfOpaqTrans
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public int LineNo { get; set; }
        public string DocType { get; set; }
        public bool? DocComplete { get; set; }
        public string OpaqNo { get; set; }
        public string FromPu { get; set; }
        public string ToPu { get; set; }
        public string FromStaff { get; set; }
        public string ToStaff { get; set; }
        public DateTime? FromDatetime { get; set; }
        public DateTime? ToDatetime { get; set; }
        public int? FromHanging { get; set; }
        public int? ToHanging { get; set; }
    }
}
