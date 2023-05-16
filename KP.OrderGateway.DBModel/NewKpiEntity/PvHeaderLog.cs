using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvHeaderLog
    {
        public int PvHeaderLogKey { get; set; }
        public int PvHeaderKey { get; set; }
        public string ChequeReceiver { get; set; }
        public string TaxOrCardId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string UserUpdate { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? IssueDt { get; set; }
    }
}
