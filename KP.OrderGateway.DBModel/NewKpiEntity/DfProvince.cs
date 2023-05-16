using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfProvince
    {
        public string ProvinceCode { get; set; }
        public string DelFlag { get; set; }
        public string ProvinceName { get; set; }
        public string CountryCode { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserUpdate { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
