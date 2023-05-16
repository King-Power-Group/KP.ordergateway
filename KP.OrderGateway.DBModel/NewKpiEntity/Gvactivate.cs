using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Gvactivate
    {
        public string Barcode { get; set; }
        public DateTime ValidedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime? UsedDate { get; set; }
        public bool IsCanceled { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime AddDateTime { get; set; }
        public DateTime UpdateDatetime { get; set; }
    }
}
