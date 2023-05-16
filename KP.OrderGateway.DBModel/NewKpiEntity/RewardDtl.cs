using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RewardDtl
    {
        public long DetailKey { get; set; }
        public long HeaderKey { get; set; }
        public string ArticleCode { get; set; }
        public decimal Point { get; set; }
        public decimal Price { get; set; }
        public decimal Karat { get; set; }
        public bool IsCanceled { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual RewardHdr HeaderKeyNavigation { get; set; }
    }
}
