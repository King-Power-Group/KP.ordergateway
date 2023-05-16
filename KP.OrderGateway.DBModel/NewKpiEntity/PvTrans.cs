using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvTrans
    {
        public long PvTransKey { get; set; }
        public long PvHeaderKey { get; set; }
        public short DisplayOrder { get; set; }
        public bool? TransType { get; set; }
        public long? AccountTypeKey { get; set; }
        public string AccountName { get; set; }
        public decimal? Amount { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual AccountType AccountTypeKeyNavigation { get; set; }
    }
}
