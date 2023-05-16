using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfReprintLog
    {
        public string BranchNo { get; set; }
        public string CashierMac { get; set; }
        public string ClaimcheckNo { get; set; }
        public int RunNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string UserPrint { get; set; }
        public string MachineIp { get; set; }
        public DateTime AddDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
