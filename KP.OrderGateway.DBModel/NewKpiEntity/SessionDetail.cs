using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SessionDetail
    {
        public long SessionDetailKey { get; set; }
        public long SessionKey { get; set; }
        public string OpaqNo { get; set; }
        public long HangingKey { get; set; }
        public bool IsChecked { get; set; }
        public string MachineCheck { get; set; }
        public string UserCheck { get; set; }
        public bool IsNew { get; set; }
        public bool IsOver { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
