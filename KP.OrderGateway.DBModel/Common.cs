using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel
{
    public class Common
    {
    }

    public class DtServer
    {
        [Key]
        public int id { get; set; }
        public DateTime Dbdt { get; set; }
    }
}
