using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CitesDetail
    {
        public long CitesDetailKey { get; set; }
        public long CitesHeaderKey { get; set; }
        public string SuborderType { get; set; }
        public int LineNo { get; set; }
        public int PieceNo { get; set; }
        public string ItemCode { get; set; }
        public string MatCode { get; set; }
        public string ArticleName { get; set; }
        public decimal SellingPrice { get; set; }
        public string BookNo { get; set; }
        public string CitesNo { get; set; }
        public string PermitNo { get; set; }
        public DateTime? ValidTo { get; set; }
        public string CitesName { get; set; }
        public string CitesType { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
