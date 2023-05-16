using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSubpayment
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SuborderType { get; set; }
        public decimal LineNo { get; set; }
        public string MethodCode { get; set; }
        public string CredCardNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountVat { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
