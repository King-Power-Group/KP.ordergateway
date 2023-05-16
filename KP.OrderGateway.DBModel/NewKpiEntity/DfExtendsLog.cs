using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfExtendsLog
    {
        public long running { get; set; }
        public string tableLog { get; set; }
        public long runno { get; set; }
        public string userCode { get; set; }
        public string valueCode { get; set; }
        public DateTime datetime { get; set; }
    }
}
