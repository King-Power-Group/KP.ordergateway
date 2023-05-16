using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCommDoc
    {
        public string BranchNo { get; set; }
        public string DocNo { get; set; }
        public DateTime DataDatetime { get; set; }
        public string ShoppingCard { get; set; }
        public string AgentCode { get; set; }
        public string TourCode { get; set; }
        public DateTime TourDate { get; set; }
        public string TourTime { get; set; }
        public decimal Amount { get; set; }
        public int? Pax { get; set; }
        public int? Visitor { get; set; }
        public int? Customer { get; set; }
        public decimal? PerHead { get; set; }
        public decimal CommRate { get; set; }
        public decimal Net { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserAdd { get; set; }
        public DateTime? CancelDatetime { get; set; }
        public string UserCancel { get; set; }
        public byte[] TimeStamp { get; set; }
        public string CancelToDoc { get; set; }
        public decimal? WhtRate { get; set; }
        public decimal? WhtAmount { get; set; }
        public decimal? Vat { get; set; }
    }
}
