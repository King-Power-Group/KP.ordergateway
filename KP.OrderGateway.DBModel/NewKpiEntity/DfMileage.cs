using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMileage
    {
        public string BranchNo { get; set; }
        public DateTime DataDate { get; set; }
        public string MachineNo { get; set; }
        public string DocNo { get; set; }
        public string Plant { get; set; }
        public string CardNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Vendor { get; set; }
    }
}
