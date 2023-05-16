using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcMovementType
    {
        public string MvtCode { get; set; }
        public string MvtName { get; set; }
        public short InOutEpurse { get; set; }
        public short InOutAcc { get; set; }
        public short InOutPoint { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? AddDatetime { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string DelFlag { get; set; }
    }
}
