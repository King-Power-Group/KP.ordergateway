using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfInshopHdr
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public string DocType { get; set; }
        public int Pax { get; set; }
        public decimal Total { get; set; }
        public string FeeType { get; set; }
        public string CarLicence { get; set; }
        public string AgentCode { get; set; }
        public string SubagentCode { get; set; }
        public string CancelToDoc { get; set; }
        public string UserCancel { get; set; }
        public DateTime? CancelDatetime { get; set; }
        public string UserAdd { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserPaid { get; set; }
        public DateTime? PaidDatetime { get; set; }
        public string Remark { get; set; }
        public string TransportCode { get; set; }
        public string BranchGetComm { get; set; }
    }
}
