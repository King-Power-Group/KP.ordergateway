using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpPeriod
    {
        public long PeriodKey { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal NetBuy { get; set; }
        public decimal Gwpqty { get; set; }
        public string GroupCode { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
    }
}
