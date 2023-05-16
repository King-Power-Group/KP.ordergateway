using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfGroup
    {
        public string BranchNo { get; set; }
        public string GrpCode { get; set; }
        public string GrpName { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
