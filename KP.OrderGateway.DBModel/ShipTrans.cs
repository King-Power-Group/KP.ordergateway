using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel
{
    public class ShipTrans
    {
        public int transID { get; set; }
        public string transSessionID { get; set; }
        public string transSessionValue { get; set; }
        public string userModify { get; set; }
        public DateTime? DatetimeUpdate { get; set; }
        public string ipModify { get; set; }
        public DateTime? addDatetime { get; set; }
    }
}
