using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PaysessSession
    {
        public PaysessSession()
        {
            PaysessPaytran = new HashSet<PaysessPaytran>();
            PaysessSessionMovement = new HashSet<PaysessSessionMovement>();
        }

        public long SessionId { get; set; }
        public Guid PaidGuid { get; set; }
        public bool Active { get; set; }
        public int? LastStatus { get; set; }
        public int? CurrentStatus { get; set; }
        public DateTime CreateDatetime { get; set; }
        public DateTime? ModifiedDatetime { get; set; }

        public virtual ICollection<PaysessPaytran> PaysessPaytran { get; set; }
        public virtual ICollection<PaysessSessionMovement> PaysessSessionMovement { get; set; }
    }
}
