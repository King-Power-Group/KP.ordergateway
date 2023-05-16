using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfTruck
    {
        public string BranchNo { get; set; }
        public string TruckNo { get; set; }
        public string DelFlag { get; set; }
        public string TruckName { get; set; }
        public string TruckLicence { get; set; }
        public int MaxBox { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public string LockIp { get; set; }
        public DateTime? LockDatetime { get; set; }
        public DateTime LastTripDatetime { get; set; }
    }
}
