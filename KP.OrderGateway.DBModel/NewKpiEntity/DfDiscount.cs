using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfDiscount
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public int PluLineNo { get; set; }
        public int DiscLineNo { get; set; }
        public decimal DiscRate { get; set; }
        public decimal DiscPer { get; set; }
        public decimal DiscAmount { get; set; }
        public string PromoCode { get; set; }
        public bool BybillFlag { get; set; }
        public short BybillRunno { get; set; }
        public short DiscType { get; set; }
        public string DelFlag { get; set; }
        public bool CancelStatus { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public Guid? Qrcode { get; set; }
        public string MethodCode { get; set; }
        public decimal? Subsidize { get; set; }
        public decimal? BlockAmount { get; set; }
    }
}
