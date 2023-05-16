using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CsoLogUp2Sap
    {
        public long SyncUp2sapId { get; set; }
        public long? LastInvoiceId { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? FinishDt { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
