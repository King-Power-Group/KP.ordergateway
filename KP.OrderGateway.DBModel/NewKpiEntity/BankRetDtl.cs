using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class BankRetDtl
    {
        public long BankRetDtlKey { get; set; }
        public long BankRetHdrKey { get; set; }
        public string RecordType { get; set; }
        public string PaymentCurr { get; set; }
        public decimal PaymentAmt { get; set; }
        public string BeneAccount { get; set; }
        public string BeneName { get; set; }
        public string BeneTax { get; set; }
        public string BeneBankName { get; set; }
        public string BeneBankCode { get; set; }
        public string BeneBranchName { get; set; }
        public string BeneBranchCode { get; set; }
        public string BankRef { get; set; }
        public string ProcessStatus { get; set; }
        public string ProcessRemark { get; set; }
        public decimal NetPayment { get; set; }
        public string ChequeNo { get; set; }
        public string CustRef { get; set; }
        public string WhtNo { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
