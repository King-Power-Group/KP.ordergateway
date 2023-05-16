using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel
{
    public class Config
    {
        [Key]
        public long ConfigKey { get; set; }
        public string ConfigCode { get; set; }
        public string ConfigData { get; set; }
    }
}
