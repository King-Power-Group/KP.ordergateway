using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSohdrExtend
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string ECommerceOrderNo { get; set; }
        public bool IsDelivery { get; set; }
        public string PickupTypeCode { get; set; }
        public string PlatformId { get; set; }
        public decimal DeliveryCost { get; set; }
        public string Plant { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
