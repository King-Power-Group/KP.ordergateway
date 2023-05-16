using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class LogChangeShipping
    {
        public Int64 id { get; set; }
        public string sessionID { get; set; }
        public string sessionValue { get; set; }
        public string userUpdateBy { get; set; }
        public DateTime userUpdateDatetime { get; set; }
    }
}
