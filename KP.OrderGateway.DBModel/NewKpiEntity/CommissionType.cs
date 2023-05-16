using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CommissionType
    {
        public long CommissionTypeKey { get; set; }
        public string CommissionTypeName { get; set; }
        public bool? IsPerson { get; set; }
    }
}
