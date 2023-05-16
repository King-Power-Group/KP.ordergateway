using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfActiveVoucher
    {
        public string VoucherCode { get; set; }
        public long FromNo { get; set; }
        public long ToNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string DepartCode { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
