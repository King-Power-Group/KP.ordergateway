using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfLocation
    {
        public DfLocation()
        {
            WalletAgent = new HashSet<WalletAgent>();
        }

        public string BranchNo { get; set; }
        public string LocCode { get; set; }
        public string AreaCode { get; set; }
        public string LocName { get; set; }
        public string VatCode { get; set; }
        public string CurrCode { get; set; }
        public short Channel { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public string ArrdepTerminal { get; set; }
        public string PriceList { get; set; }
        public string Dchannel { get; set; }

        public virtual ICollection<WalletAgent> WalletAgent { get; set; }
    }
}
