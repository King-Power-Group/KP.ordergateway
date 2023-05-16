using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfUser
    {
        public string BranchNo { get; set; }
        public string UserCode { get; set; }
        public string OperGrp { get; set; }
        public string DelFlag { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
