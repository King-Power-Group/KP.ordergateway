using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TbgMachine
    {
        public string BranchNo { get; set; }
        public string MachineNo { get; set; }
        public string TbgconfigCode { get; set; }

        public virtual TbgConfig TbgconfigCodeNavigation { get; set; }
    }
}
