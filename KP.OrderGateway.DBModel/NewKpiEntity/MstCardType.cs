using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MstCardType
    {
        public string CardTypeId { get; set; }
        public string CardTypeCode { get; set; }
        public string Description { get; set; }
        public string Discount { get; set; }
        public bool RequireRef { get; set; }
        public string CardGroupId { get; set; }
        public string StartShopCard { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
