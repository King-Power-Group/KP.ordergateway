using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PaysessSessionMovement
    {
        public long MovementId { get; set; }
        public long SessionId { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public DateTime CreateDatetime { get; set; }

        public virtual PaysessSession Session { get; set; }
    }
}
