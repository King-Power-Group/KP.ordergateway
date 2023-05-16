using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTripHeader
    {
        public PkTripHeader()
        {
            PkTripDetail = new HashSet<PkTripDetail>();
        }

        public long TripHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public string TruckNo { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDt { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<PkTripDetail> PkTripDetail { get; set; }
    }
}
