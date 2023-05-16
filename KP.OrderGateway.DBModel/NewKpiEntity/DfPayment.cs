using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfPayment
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public int LineNo { get; set; }
        public string MethodCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountRound { get; set; }
        public decimal AmountCurr { get; set; }
        public string CurrCode { get; set; }
        public decimal CurrRate { get; set; }
        public string CashierCode { get; set; }
        public string Posid { get; set; }
        public string CredCardNo { get; set; }
        public string CredCardName { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ApproveCode { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string BankOfEdc { get; set; }
        public string AliBarcode { get; set; }
        public string AliMerchantId { get; set; }
        public string AliTransId { get; set; }
        public bool? AlipayCancel { get; set; }
    }
}
