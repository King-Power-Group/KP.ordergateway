using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Qrcode
    {
        public Guid Qrcode1 { get; set; }
        public string EanCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SourceCode { get; set; }
        public string PromotionCode { get; set; }
        public bool IsPercentDiscount { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsUsed { get; set; }
        public string LastStatus { get; set; }
        public long RunningNo { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
