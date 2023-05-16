using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvappvHist
    {
        public long PvappvHistKey { get; set; }
        public long PvheaderKey { get; set; }
        public int Type { get; set; }
        public string ActionBy { get; set; }
        public DateTime ActionDatetime { get; set; }
        public string DocumentNo { get; set; }
        public string DelFlag { get; set; }
    }
}
