using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfPickup
    {
        public string BranchNo { get; set; }
        public string PickupCode { get; set; }
        public string DelFlag { get; set; }
        public string PickupName { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public int MaxHanging { get; set; }
        public int FreeHanging { get; set; }
        public string LockIp { get; set; }
        public DateTime? LockDatetime { get; set; }
        public int LastHanging { get; set; }
        public string PickupGroup { get; set; }
        public bool IsFrn { get; set; }
        public string PuLocation { get; set; }
        public string DefaultPrinter { get; set; }
        public string ConsolLocCode { get; set; }
    }
}
