using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfPaymeth
    {
        public DfPaymeth()
        {
            Edcissuer = new HashSet<Edcissuer>();
            WalletPrefix = new HashSet<WalletPrefix>();
        }

        public string MethodCode { get; set; }
        public string MethodDesc { get; set; }
        public string MethodShort { get; set; }
        public string MethodHot { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public byte[] Image { get; set; }
        public string MethodGroup { get; set; }
        public bool CheckVoucher { get; set; }
        public bool IsVoucher { get; set; }
        public bool BarcodeFix { get; set; }
        public bool NotAllowSmc { get; set; }
        public bool InputApprove { get; set; }
        public bool IsCashcard { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCommission { get; set; }
        public bool IsAlipay { get; set; }

        public virtual ScoPaymeth ScoPaymeth { get; set; }
        public virtual ICollection<Edcissuer> Edcissuer { get; set; }
        public virtual ICollection<WalletPrefix> WalletPrefix { get; set; }
    }
}
