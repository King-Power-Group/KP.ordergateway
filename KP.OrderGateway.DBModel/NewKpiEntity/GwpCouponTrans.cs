using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpCouponTrans
    {
        public long GwpCouponTransKey { get; set; }
        public string BranchNo { get; set; }
        public DateTime DataDate { get; set; }
        public string MachineNo { get; set; }
        public string DocNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string CouponCode { get; set; }
        public string KeySearch { get; set; }
        public DateTime AddDatetime { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual GwpCoupon CouponCodeNavigation { get; set; }
    }
}
