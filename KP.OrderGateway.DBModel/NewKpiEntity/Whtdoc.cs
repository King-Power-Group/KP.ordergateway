using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Whtdoc
    {
        public string Wtgroup { get; set; }
        public string WhtdocNo { get; set; }
        public DateTime DataDate { get; set; }
        public string RefDoc { get; set; }
        public string CustName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TaxOrCardId { get; set; }
        public decimal Amount { get; set; }
        public decimal Wht { get; set; }
        public bool? IsPerson { get; set; }
        public string CancelToDoc { get; set; }
        public DateTime? CancelToDate { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDateTime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public string WtCode { get; set; }
        public string WtCust { get; set; }
        public string WtAddress { get; set; }
        public string WtTaxOrCardId { get; set; }
        public string CertificateDoc { get; set; }
    }
}
