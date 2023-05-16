using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCustType
    {
        public string CustTypeCode { get; set; }
        public string CustTypeDesc { get; set; }
        public decimal CustDiscRate { get; set; }
        public bool? AllowStatusC { get; set; }
        public bool? AllowStatusT { get; set; }
        public bool? AllowStatusV { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? UniquePassport { get; set; }
    }
}
