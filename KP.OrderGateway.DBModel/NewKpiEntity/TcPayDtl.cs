using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TcPayDtl
    {
        public string DocNo { get; set; }
        public string BranchNo { get; set; }
        public string TourCode { get; set; }
        public DateTime TourDate { get; set; }
        public string Description { get; set; }
        public int Pax { get; set; }
        public int Customer { get; set; }
        public decimal Netsale { get; set; }
        public decimal Rate { get; set; }
        public decimal Perhead { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
