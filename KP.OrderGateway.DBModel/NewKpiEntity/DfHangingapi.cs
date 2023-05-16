using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfHangingapi
    {
        public long running { get; set; }
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public string description { get; set; }
        public string subOrderType { get; set; }
        public DateTime addDatetime { get; set; }
        public string jsonBody { get; set; }
    }
}
