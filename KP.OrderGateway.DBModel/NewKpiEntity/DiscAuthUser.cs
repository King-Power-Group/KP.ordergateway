using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscAuthUser
    {
        public long DiscAuthUserKey { get; set; }
        public long DiscAuthHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public string UserCode { get; set; }
        public string SecureCode { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
