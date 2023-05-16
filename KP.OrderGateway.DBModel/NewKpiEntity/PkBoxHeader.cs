using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkBoxHeader
    {
        public PkBoxHeader()
        {
            PkBoxDetail = new HashSet<PkBoxDetail>();
            PkTripDetail = new HashSet<PkTripDetail>();
        }

        public long BoxHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public string BoxNo { get; set; }
        public string PickupCode { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDt { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool IsHoldBox { get; set; }
        public DateTime? PickupDt { get; set; }
        public string PickupUserCode { get; set; }
        public DateTime? CanceledDt { get; set; }
        public string CanceledUserCode { get; set; }

        public virtual ICollection<PkBoxDetail> PkBoxDetail { get; set; }
        public virtual ICollection<PkTripDetail> PkTripDetail { get; set; }
    }
}
