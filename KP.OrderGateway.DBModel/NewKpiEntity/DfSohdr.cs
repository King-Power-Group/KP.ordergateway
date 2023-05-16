using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSohdr
    {
        public DfSohdr()
        {
            DfSohdrExt = new HashSet<DfSohdrExt>();
        }

        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string TourCode { get; set; }
        public string CustTypeCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime? FlightDate { get; set; }
        public string FlightTime { get; set; }
        public string CountryCode { get; set; }
        public string OrderStatus { get; set; }
        public string Posid { get; set; }
        public string CashierMac { get; set; }
        public string CashierCode { get; set; }
        public DateTime? UpdateDateSale { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string LockAddress { get; set; }
        public int CancelToOrder { get; set; }
        public string HotelCode { get; set; }
        public string HotelSource { get; set; }
        public string ShopRef { get; set; }
        public string MachineTax { get; set; }
        public string RefDoc { get; set; }
        public string CardTypeCode { get; set; }
        public string EmBossId { get; set; }
        public string CardTypeId { get; set; }
        public long? LvheaderKey { get; set; }
        public long? AlipaySession { get; set; }
        public Guid? PaidGuid { get; set; }

        public virtual ICollection<DfSohdrExt> DfSohdrExt { get; set; }
    }
}
