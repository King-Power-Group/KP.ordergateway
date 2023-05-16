using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrConditionLog
    {
        public int LogKey { get; set; }
        public DateTime LogDate { get; set; }
        public string BranchNo { get; set; }
        public string AgentCode { get; set; }
        public int GroupFlag { get; set; }
        public string CountryCode { get; set; }
        public string CateCode { get; set; }
        public string BrandCode { get; set; }
        public int FlightGroup { get; set; }
        public int PaidType { get; set; }
        public int CheckFrom { get; set; }
        public decimal Range1 { get; set; }
        public decimal Range2 { get; set; }
        public decimal Amount { get; set; }
        public int CalcType { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string LogBy { get; set; }
        public decimal? SpendingPerPaxByAgent { get; set; }
        public decimal? SpendingPerPaxByTour { get; set; }
    }
}
