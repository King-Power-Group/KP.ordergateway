using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TblUi
    {
        public string BranchNo { get; set; }
        public long TrCode { get; set; }
        public string FormName { get; set; }
        public string UserProcess { get; set; }
        public string DebugErrMsg { get; set; }
        public string TableName { get; set; }
        public string TableCode { get; set; }
        public int? TableCodeFlag { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public byte[] Secure { get; set; }
    }
}
