using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpCoupon
    {
        public GwpCoupon()
        {
            GwpCouponTrans = new HashSet<GwpCouponTrans>();
        }

        public long GwpcouponKey { get; set; }
        public string CouponCode { get; set; }
        public string GroupCode { get; set; }
        public string SlipText { get; set; }
        public bool MemberOnly { get; set; }

        public virtual GwpGroup GroupCodeNavigation { get; set; }
        public virtual ICollection<GwpCouponTrans> GwpCouponTrans { get; set; }
    }
}
