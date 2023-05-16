using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SessionHeader
    {
        public long SessionKey { get; set; }
        public string SessionName { get; set; }
        public string PickupCode { get; set; }
        public bool IsActivate { get; set; }
        public bool IsClose { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
