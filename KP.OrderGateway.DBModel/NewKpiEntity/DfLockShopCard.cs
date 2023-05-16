using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfLockShopCard
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public string ModuleCode { get; set; }
        public string AuthCode { get; set; }
        public string LockIp { get; set; }
        public string ComName { get; set; }
        public DateTime? LockDatetime { get; set; }
    }
}
