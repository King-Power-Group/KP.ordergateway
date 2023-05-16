using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastMcExtend
    {
        public string Mccode { get; set; }
        public bool ConsolFlag { get; set; }
        public decimal BuyLimitQty { get; set; }
        public bool CheckStkOnline { get; set; }
        public decimal? CommRate { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual MastMc MccodeNavigation { get; set; }
    }
}
