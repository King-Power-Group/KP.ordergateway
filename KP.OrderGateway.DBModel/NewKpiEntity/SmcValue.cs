using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcValue
    {
        public string MemberId { get; set; }
        public int DocNo { get; set; }
        public int Runno { get; set; }
        public short? ValueType { get; set; }
        public DateTime? ExpDate { get; set; }
        public string FormatVersion { get; set; }
        public int? RecordNo { get; set; }
        public string ValueCode { get; set; }
        public DateTime? ValidDate { get; set; }
        public decimal? BalanceValue { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? DocDate { get; set; }
        public long? HeaderKey { get; set; }
        public long ValueKey { get; set; }
    }
}
