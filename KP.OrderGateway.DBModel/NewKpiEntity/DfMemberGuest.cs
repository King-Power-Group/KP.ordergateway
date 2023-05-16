using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMemberGuest
    {
        public string ShoppingCard { get; set; }
        public string Name { get; set; }
        public string Tname { get; set; }
        public string GroupType { get; set; }
        public DateTime? AddDatetime { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public string DelFlag { get; set; }
        public string RefNo { get; set; }
    }
}
