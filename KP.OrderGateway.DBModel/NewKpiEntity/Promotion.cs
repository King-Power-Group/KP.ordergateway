using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Promotion
    {
        public Promotion()
        {
            PromoBranch = new HashSet<PromoBranch>();
            PromoSubBranch = new HashSet<PromoSubBranch>();
        }

        public string PromotionCode { get; set; }
        public string PromotionName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IgnoreMaxDisc { get; set; }
        public bool AllowOverwriteDisc { get; set; }
        public bool IsLineDiscount { get; set; }
        public bool IsBillDiscount { get; set; }
        public bool AllowManualKeyIn { get; set; }
        public string DepartmentCode { get; set; }
        public bool NotCheckDuplicate { get; set; }
        public bool NotAllowSmc { get; set; }
        public string PromoMap { get; set; }
        public bool IsCanceled { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public long RecNo { get; set; }
        public string PaymentCode { get; set; }
        public bool? CheckBlockDiscount { get; set; }
        public decimal DiscAmt { get; set; }
        public decimal DiscRate { get; set; }

        public virtual ICollection<PromoBranch> PromoBranch { get; set; }
        public virtual ICollection<PromoSubBranch> PromoSubBranch { get; set; }
    }
}
