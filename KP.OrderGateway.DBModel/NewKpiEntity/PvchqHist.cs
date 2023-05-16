using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PvchqHist
    {
        public long PvChqHistKey { get; set; }
        public string ProductType { get; set; }
        public string S1refBatch { get; set; }
        public string CustRefBatch { get; set; }
        public string DebitAccount { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime IssueDate { get; set; }
        public int SeqNo { get; set; }
        public string BeneName { get; set; }
        public string CustRefDetail { get; set; }
        public string ChequeNo { get; set; }
        public decimal ChqAmount { get; set; }
        public string DeliveryMode { get; set; }
        public string PickupStatus { get; set; }
        public DateTime? PickupDate { get; set; }
        public string LastStatus { get; set; }
        public DateTime? LastUpdateStatus { get; set; }
        public string Receiver { get; set; }
        public string WhtNo { get; set; }
        public string BankRef { get; set; }
        public long? PvHeaderKey { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
