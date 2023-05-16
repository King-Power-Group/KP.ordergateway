using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PaysessPaytran
    {
        public PaysessPaytran()
        {
            PaysessPaytranMovement = new HashSet<PaysessPaytranMovement>();
        }

        public long TranId { get; set; }
        public long SessionId { get; set; }
        public int? TranGroup { get; set; }
        public string TranType { get; set; }
        public int PaylineNo { get; set; }
        public string PartnerType { get; set; }
        public int? PartnerId { get; set; }
        public long? GatewaySessionKey { get; set; }
        public string MerchantId { get; set; }
        public string CashierNo { get; set; }
        public string MachineTaxNo { get; set; }
        public string MachineNo { get; set; }
        public string IpNo { get; set; }
        public int? LastStatus { get; set; }
        public int CurrentStatus { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDatetime { get; set; }
        public DateTime? ModifiedDatetime { get; set; }
        public string PartnerTransId { get; set; }
        public bool? PrintSlip { get; set; }
        public string GatewayBuyerId { get; set; }
        public int? PartnerGroup { get; set; }
        public string GatewayBarcode { get; set; }
        public int? PaytranNo { get; set; }
        public string MethodCode { get; set; }

        public virtual PaysessSession Session { get; set; }
        public virtual ICollection<PaysessPaytranMovement> PaysessPaytranMovement { get; set; }
    }
}
