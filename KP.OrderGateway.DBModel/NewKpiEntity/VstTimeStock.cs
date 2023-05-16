using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public class VstTimeStock
    {
        [Key]
        public long running { get; set; }
        public string timeCode { get; set; }
        public int datediff { get; set; }
        public string timeFrom { get; set; }
        public string timeTo { get; set; }
    }
}
