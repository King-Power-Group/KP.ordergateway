using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcCoupon
    {
        public long CouponKey { get; set; }
        public long? HeaderKey { get; set; }
        public string CouponCode { get; set; }
        public string CouponStatus { get; set; }
        public string CouponType { get; set; }
        public string IssueCode { get; set; }
        public int? Ncount { get; set; }
        public int? RecourdNo { get; set; }
        public DateTime? Validdate { get; set; }
        public DateTime? Expiredate { get; set; }
        public decimal? Value { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
