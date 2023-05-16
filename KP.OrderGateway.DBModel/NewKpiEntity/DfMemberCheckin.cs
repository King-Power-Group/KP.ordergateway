using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMemberCheckin
    {
        public string ShoppingCard { get; set; }
        public DateTime RegistDate { get; set; }
        public DateTime? RegistDatetime { get; set; }
        public int? Follower { get; set; }
        public int? Gift { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? UpdateDatetime { get; set; }
    }
}
