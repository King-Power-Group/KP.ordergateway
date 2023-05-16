using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Delight2014
    {
        public DateTime DataDate { get; set; }
        public string ShoppingCard { get; set; }
        public string MemberName { get; set; }
        public DateTime PaidDt { get; set; }
        public decimal TotalAmt { get; set; }
        public byte[] TimeStamp { get; set; }
        public string BranchNo { get; set; }
    }
}
