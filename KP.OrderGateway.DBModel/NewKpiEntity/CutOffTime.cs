using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CutOffTime
    {
        public string BranchNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string KeyCode { get; set; }
        public int KeyType { get; set; }
        public int CotWarningSale { get; set; }
        public int CotWarningSaleMin { get; set; }
        public int CotStopSale { get; set; }
        public int CotStopSaleMin { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
