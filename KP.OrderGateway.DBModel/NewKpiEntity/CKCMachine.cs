using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CKCMachine
    {
        [Key]
        public string machineNo { get; set; }
        public string machineIP { get; set; }
        public string machineName { get; set; }
        public bool isCancel { get; set; }
    }
}
