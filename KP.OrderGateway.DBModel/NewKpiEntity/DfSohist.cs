using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSohist
    {
        public DfSohist()
        {
            DfSohistExt = new HashSet<DfSohistExt>();
        }

        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SuborderType { get; set; }
        public int LineNo { get; set; }
        public string ItemCode { get; set; }
        public string MatCode { get; set; }
        public string TbagNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal Net { get; set; }
        public decimal Vat { get; set; }
        public string Vatno { get; set; }
        public decimal VatRate { get; set; }
        public string DiscCode { get; set; }
        public decimal DiscRate { get; set; }
        public string PromoCode { get; set; }
        public string StaffCode { get; set; }
        public decimal StaffCommRate { get; set; }
        public bool? ConsolFlag { get; set; }
        public bool? ArrivalFlag { get; set; }
        public bool? CancelStatus { get; set; }
        public bool? PickStatus { get; set; }
        public string MachineNo { get; set; }
        public string CollectStatus { get; set; }
        public bool? TbagIssue { get; set; }
        public DateTime? TbagDatetime { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool? NewTbag { get; set; }
        public bool? LineCancel { get; set; }
        public decimal RecieveQty { get; set; }
        public bool? RecieveFlag { get; set; }
        public string RecieveUser { get; set; }
        public DateTime? RecieveDatetime { get; set; }
        public decimal ConsolQty { get; set; }
        public DateTime? ConsolDatetime { get; set; }
        public string ConsolUser { get; set; }
        public bool? LockDiscount { get; set; }
        public bool? Rewards { get; set; }
        public decimal? RewardsPoint { get; set; }
        public decimal? RewardsPrice { get; set; }
        public decimal? RewardsKarat { get; set; }

        public virtual ICollection<DfSohistExt> DfSohistExt { get; set; }
    }
}
