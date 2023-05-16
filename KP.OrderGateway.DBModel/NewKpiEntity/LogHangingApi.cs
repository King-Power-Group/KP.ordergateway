using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class LogHangingApi
    {
        public long running { get; set; }
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public string subOrderType { get; set; }
        public string status { get; set; }
        public string hangingNo { get; set; }
        public long recNo { get; set; }
        public string packingNo { get; set; }
        public DateTime addDatetime { get; set; }
    }
}
