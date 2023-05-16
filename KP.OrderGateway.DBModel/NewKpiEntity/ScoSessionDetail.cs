using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ScoSessionDetail
    {
        public long SessionDetailKey { get; set; }
        public long SessionKey { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public DateTime? CreateDt { get; set; }
        public bool? IsCancel { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ScoSession SessionKeyNavigation { get; set; }
    }
}
