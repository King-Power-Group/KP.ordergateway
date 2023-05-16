using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class BankRetHdr
    {
        public long BankRetHdrKey { get; set; }
        public string RecordType { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateTime { get; set; }
        public string FileRef { get; set; }
        public string CompanyId { get; set; }
        public string PaymentType { get; set; }
        public string ChanelId { get; set; }
        public string BatchRef { get; set; }
        public DateTime ValueDate { get; set; }
        public string DelFlag { get; set; }
        public string UploadDoc { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
