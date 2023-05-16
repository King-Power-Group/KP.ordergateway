using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CmFilter
    {
        public long FilterKey { get; set; }
        public long FilterHeaderKey { get; set; }
        public string Sign { get; set; }
        public string Option { get; set; }
        public string LowString { get; set; }
        public string HighString { get; set; }
        public decimal? LowDecimal { get; set; }
        public decimal? HighDecimal { get; set; }
        public DateTime? LowDt { get; set; }
        public DateTime? HighDt { get; set; }
        public string ValueType { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
