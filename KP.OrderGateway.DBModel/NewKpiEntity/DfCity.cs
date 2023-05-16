using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCity
    {
        public string CityCode { get; set; }
        public string DelFlag { get; set; }
        public string CityName { get; set; }
        public string ProvinceCode { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserUpdate { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
