using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CKCMachineSite
    {
        [Key]
        public long key { get; set; }
        public string machineNo { get; set; }
        public string siteCode { get; set; }
    }
}
