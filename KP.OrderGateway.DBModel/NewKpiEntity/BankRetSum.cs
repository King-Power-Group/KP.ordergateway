using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class BankRetSum
    {
        public long BankRetSumKey { get; set; }
        public long BankRetHdrKey { get; set; }
        public string RecordType { get; set; }
        public int NoOfTrans { get; set; }
        public decimal TotalPayment { get; set; }
    }
}
