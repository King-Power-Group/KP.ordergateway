using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfRefundTrans
    {
        public string RunNo { get; set; }
        public int ItemNo { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SuborderType { get; set; }
        public int LineNo { get; set; }
        public string ItemCode { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserAdd { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Net { get; set; }
        public decimal? Vat { get; set; }
        public string MatCode { get; set; }
    }
}
