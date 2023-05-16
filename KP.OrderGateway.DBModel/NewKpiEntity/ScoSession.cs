using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ScoSession
    {
        public ScoSession()
        {
            ScoSessionDetail = new HashSet<ScoSessionDetail>();
        }

        public long SessionKey { get; set; }
        public string MachineNo { get; set; }
        public string ShoppingCard { get; set; }
        public bool? IsCancel { get; set; }
        public byte[] TimeStamp { get; set; }
        public long LastLogKey { get; set; }

        public virtual ScoLog LastLogKeyNavigation { get; set; }
        public virtual ICollection<ScoSessionDetail> ScoSessionDetail { get; set; }
    }
}
