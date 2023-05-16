using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTransferType
    {
        public PkTransferType()
        {
            PkTransferHeader = new HashSet<PkTransferHeader>();
        }

        public string TftypeCode { get; set; }
        public string TftypeName { get; set; }
        public string SortOrder { get; set; }
        public string TftypeGroupCode { get; set; }

        public virtual PkTftypeGroup TftypeGroupCodeNavigation { get; set; }
        public virtual ICollection<PkTransferHeader> PkTransferHeader { get; set; }
    }
}
