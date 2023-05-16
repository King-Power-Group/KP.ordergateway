using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RewardHdr
    {
        public RewardHdr()
        {
            RewardDtl = new HashSet<RewardDtl>();
        }

        public long HeaderKey { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PromoCode { get; set; }
        public bool IsCanceled { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<RewardDtl> RewardDtl { get; set; }
    }
}
