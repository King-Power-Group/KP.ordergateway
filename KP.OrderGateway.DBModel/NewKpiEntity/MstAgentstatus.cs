using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MstAgentstatus
    {
        public string AgentstatusCode { get; set; }
        public string AgentstatusName { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
    }
}
