using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MaConfig
    {
        [Key]
        public string Server_eCom { get; set; }
        public string Database_eCom { get; set; }
        public string User_eCom { get; set; }
        public string Pass_eCom { get; set; }
    }
}
