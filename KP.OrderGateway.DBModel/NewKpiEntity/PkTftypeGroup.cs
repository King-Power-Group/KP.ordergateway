using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTftypeGroup
    {
        public PkTftypeGroup()
        {
            PkTransferType = new HashSet<PkTransferType>();
        }

        public string TftypeGroupCode { get; set; }
        public string TftypeGroupName { get; set; }

        public virtual ICollection<PkTransferType> PkTransferType { get; set; }
    }
}
