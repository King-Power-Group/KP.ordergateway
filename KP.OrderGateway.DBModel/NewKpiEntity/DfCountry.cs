using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCountry
    {
        public string CountryCode { get; set; }
        public string DelFlag { get; set; }
        public string CountryName { get; set; }
        public string CurrCode { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserUpdate { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
