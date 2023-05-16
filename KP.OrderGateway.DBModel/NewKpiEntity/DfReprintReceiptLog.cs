using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfReprintReceiptLog
    {
        public long ReprKey { get; set; }
        public string BranchNo { get; set; }
        public long? RecNo { get; set; }
        public string PackNo { get; set; }
        public string ShoppingCard { get; set; }
        public int? OrderNo { get; set; }
        public string ModuleApp { get; set; }
        public string SourceApp { get; set; }
        public DateTime? AddDatetime { get; set; }
        public string UserCode { get; set; }
        public string MachineNo { get; set; }
        public string MachineIp { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ResultPrinttm { get; set; }
    }
}
