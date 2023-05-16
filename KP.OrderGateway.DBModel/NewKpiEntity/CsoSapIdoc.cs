using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CsoSapIdoc
    {
        public string BranchNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string MachineNo { get; set; }
        public string DocNo { get; set; }
        public string SapIdocNo { get; set; }
        public DateTime? IdocDatetime { get; set; }
    }
}
