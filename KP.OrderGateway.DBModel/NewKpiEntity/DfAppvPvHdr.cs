using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfAppvPvHdr
    {
        public string DocNo { get; set; }
        public DateTime DataDate { get; set; }
        public string Title { get; set; }
        public string Attn { get; set; }
        public decimal AmountBaht { get; set; }
        public bool? VpSign { get; set; }
        public bool ChairmanSign { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
