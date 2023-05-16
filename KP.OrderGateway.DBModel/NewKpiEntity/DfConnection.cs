using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfConnection
    {
        public string CnCode { get; set; }
        public string CnName { get; set; }
        public string CnServer { get; set; }
        public string CnDatabase { get; set; }
        public string CnUid { get; set; }
        public string CnPwd { get; set; }
        public string CnBranchNo { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public string DelFlag { get; set; }
    }
}
