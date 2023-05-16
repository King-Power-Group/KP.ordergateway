using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CKCMachineSettings
    {
        [Key]
        public long running { get; set; }
        public string machine_no { get; set; }
        public string machine_group { get; set; }
        public string machine_value { get; set; }
    }
}
