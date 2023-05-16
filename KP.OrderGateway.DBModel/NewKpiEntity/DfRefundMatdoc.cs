using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfRefundMatdoc
    {
        public DateTime OrderDate { get; set; }
        public string CashierMac { get; set; }
        public string ClaimcheckNo { get; set; }
        public string MatDocNo { get; set; }
        public string DocDate { get; set; }
        public DateTime? DocumentDate { get; set; }
    }
}
