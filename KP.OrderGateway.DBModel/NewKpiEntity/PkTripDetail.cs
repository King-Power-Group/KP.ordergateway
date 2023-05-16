using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTripDetail
    {
        public long TripDetailKey { get; set; }
        public long TripHeaderKey { get; set; }
        public long BoxHeaderKey { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual PkBoxHeader BoxHeaderKeyNavigation { get; set; }
        public virtual PkTripHeader TripHeaderKeyNavigation { get; set; }
    }
}
