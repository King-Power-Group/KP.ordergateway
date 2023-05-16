using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Edcissuer
    {
        public string IssuerId { get; set; }
        public bool IsDcc { get; set; }
        public string MethodCode { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual DfPaymeth MethodCodeNavigation { get; set; }
    }
}
