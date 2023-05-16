using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcBirthday
    {
        public string BdCode { get; set; }
        public string BdDesc { get; set; }
        public decimal? BdRate { get; set; }
        public string RqBdCode { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime? AddDatetime { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string ValueCode { get; set; }
    }
}
