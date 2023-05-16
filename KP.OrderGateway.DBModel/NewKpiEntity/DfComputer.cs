using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfComputer
    {
        public string IpAddress { get; set; }
        public string DelFlag { get; set; }
        public string ComDesc { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserUpdate { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
        public string PickupCode { get; set; }
        public short PrintBarcode { get; set; }
        public short NotifyMinute { get; set; }
        public bool SendDataAot { get; set; }
        public Guid? ConnectionKey { get; set; }
        public bool? Counter { get; set; }
    }
}
