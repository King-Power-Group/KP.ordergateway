using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class WalletPrefix
    {
        public long WalletPrefixKey { get; set; }
        public string BarcodePrefix { get; set; }
        public string WalletType { get; set; }
        public string MethodCode { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual DfPaymeth MethodCodeNavigation { get; set; }
    }
}
