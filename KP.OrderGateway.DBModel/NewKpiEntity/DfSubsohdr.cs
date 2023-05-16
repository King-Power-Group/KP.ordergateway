using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSubsohdr
    {
        public DfSubsohdr()
        {
            DfSubsohdrExt = new HashSet<DfSubsohdrExt>();
            PkBoxDetail = new HashSet<PkBoxDetail>();
            PkHanging = new HashSet<PkHanging>();
            PkPackingNo = new HashSet<PkPackingNo>();
            PkTransfer = new HashSet<PkTransfer>();
        }

        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SuborderType { get; set; }
        public DateTime OrderDate { get; set; }
        public string TaxabbNo { get; set; }
        public string ClaimcheckNo { get; set; }
        public string OpaqNo { get; set; }
        public string BoxNo { get; set; }
        public string TruckNo { get; set; }
        public string TripNo { get; set; }
        public DateTime? TruckDatetime { get; set; }
        public string PickupCode { get; set; }
        public int HangingNo { get; set; }
        public DateTime? MoveHangingDatetime { get; set; }
        public int OldHanging { get; set; }
        public string PickupStaffCode { get; set; }
        public DateTime? PickupDatetime { get; set; }
        public bool? IssuedStatus { get; set; }
        public DateTime? IssuedDatetime { get; set; }
        public string IssuedBy { get; set; }
        public string CashierMac { get; set; }
        public bool? CancelStatus { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserUpdate { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
        public string PackStaffCode { get; set; }
        public string OpaqBy { get; set; }
        public string BoxBy { get; set; }
        public string TruckBy { get; set; }
        public string IssuedType { get; set; }
        public string TransDoc { get; set; }
        public int? TransLine { get; set; }
        public string RefNo { get; set; }
        public long? Frn { get; set; }
        public string NewHangingNo { get; set; }
        public long? OpaqTfkey { get; set; }
        public long RecNo { get; set; }
        public string BoxType { get; set; }
        public bool? ClaimTax { get; set; }

        public virtual NewOpaqTf OpaqTfkeyNavigation { get; set; }
        public virtual PkPackingRunner PkPackingRunner { get; set; }
        public virtual PkTaken PkTaken { get; set; }
        public virtual ICollection<DfSubsohdrExt> DfSubsohdrExt { get; set; }
        public virtual ICollection<PkBoxDetail> PkBoxDetail { get; set; }
        public virtual ICollection<PkHanging> PkHanging { get; set; }
        public virtual ICollection<PkPackingNo> PkPackingNo { get; set; }
        public virtual ICollection<PkTransfer> PkTransfer { get; set; }
    }
}
