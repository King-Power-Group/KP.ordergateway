using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PromoBranch
    {
        public string PromotionCode { get; set; }
        public string BranchNo { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remark { get; set; }

        public virtual Promotion PromotionCodeNavigation { get; set; }
    }
}
