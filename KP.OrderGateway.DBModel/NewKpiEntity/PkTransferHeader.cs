using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTransferHeader
    {
        public PkTransferHeader()
        {
            PkTransfer = new HashSet<PkTransfer>();
        }

        public long TransferHeaderKey { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UserCreate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string TftypeCode { get; set; }
        public string Remark { get; set; }

        public virtual PkTransferType TftypeCodeNavigation { get; set; }
        public virtual ICollection<PkTransfer> PkTransfer { get; set; }
    }
}
