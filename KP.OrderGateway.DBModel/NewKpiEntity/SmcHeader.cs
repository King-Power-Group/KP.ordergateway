using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcHeader
    {
        public string MemberId { get; set; }
        public int DocNo { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? AddDatetime { get; set; }
        public decimal? CurEPurse { get; set; }
        public decimal? CurAccPoint { get; set; }
        public decimal? CurAccAmt { get; set; }
        public decimal? ProcessEPurse { get; set; }
        public decimal? ProcessAccPoint { get; set; }
        public decimal? ProcessAccAmt { get; set; }
        public decimal? BalanceEPurse { get; set; }
        public decimal? BalanceAccPoint { get; set; }
        public decimal? BalanceAccAmt { get; set; }
        public string ModuleCode { get; set; }
        public string BranchNo { get; set; }
        public DateTime? SaleDate { get; set; }
        public string LocCode { get; set; }
        public string MachineNo { get; set; }
        public string SaleDoc { get; set; }
        public string ShoppingCard { get; set; }
        public int? OrderNo { get; set; }
        public string KeySearch { get; set; }
        public string UserAdd { get; set; }
        public string SmcId { get; set; }
        public string SessionId { get; set; }
        public string IpAddress { get; set; }
        public string SlipText { get; set; }
        public int? CancelToDoc { get; set; }
        public int? IssuedOrder { get; set; }
        public long CheckPoint { get; set; }
        public string EmbossId { get; set; }
        public long HeaderKey { get; set; }
        public DateTime? CancelToDate { get; set; }
        public long? CancelHeaderKey { get; set; }
    }
}
