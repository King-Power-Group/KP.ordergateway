using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfBoxCancel
    {
        public string BranchNo { get; set; }
        public string OpaqNo { get; set; }
        public string BoxNo { get; set; }
        public string BoxStaffCode { get; set; }
        public DateTime BoxDate { get; set; }
        public DateTime BoxDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public string CancelStaffCode { get; set; }
        public DateTime CancelDatetime { get; set; }
    }
}
