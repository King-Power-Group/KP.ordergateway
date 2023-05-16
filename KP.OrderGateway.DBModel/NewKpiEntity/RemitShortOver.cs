using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RemitShortOver
    {
        public long RemitHeaderKey { get; set; }
        public decimal Diff { get; set; }
        public decimal ShortSystem { get; set; }
        public decimal OverSystem { get; set; }
        public decimal CashShort { get; set; }
        public decimal CashOver { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual RemitHeader RemitHeaderKeyNavigation { get; set; }
    }
}
