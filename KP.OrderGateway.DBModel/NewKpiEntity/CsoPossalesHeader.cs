using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CsoPossalesHeader
    {
        public long InvoiceId { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string MachineNo { get; set; }
        public string DocNo { get; set; }
        public DateTime? AddDatetime { get; set; }
        public DateTime? SapDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
        public string CustType { get; set; }
    }
}
