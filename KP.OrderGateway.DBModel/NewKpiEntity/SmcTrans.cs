using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcTrans
    {
        public string MemberId { get; set; }
        public int DocNo { get; set; }
        public int Runno { get; set; }
        public string MvtCode { get; set; }
        public short? ValueType { get; set; }
        public DateTime? ExpDate { get; set; }
        public string FormatVersion { get; set; }
        public int? RecordNo { get; set; }
        public string ValueCode { get; set; }
        public DateTime? ValidDate { get; set; }
        public decimal? ProcessValue { get; set; }
        public decimal? CurValue { get; set; }
        public decimal? BalanceValue { get; set; }
        public bool? ReverseFlag { get; set; }
        public decimal? PointPerBaht { get; set; }
        public decimal? BahtPerPoint { get; set; }
        public DateTime? DocDate { get; set; }
        public long? HeaderKey { get; set; }
        public long TransKey { get; set; }
    }
}
