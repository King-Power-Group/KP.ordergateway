using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMagneticLog
    {
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string MachineNo { get; set; }
        public string MagneticText { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime DateTime { get; set; }
    }
}
