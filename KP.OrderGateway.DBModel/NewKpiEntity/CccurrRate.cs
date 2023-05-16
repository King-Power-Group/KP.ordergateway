using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CccurrRate
    {
        public long CccurrRateKey { get; set; }
        public string BranchNo { get; set; }
        public string CurrCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Rate { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? AddDt { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string BankCode { get; set; }
    }
}
