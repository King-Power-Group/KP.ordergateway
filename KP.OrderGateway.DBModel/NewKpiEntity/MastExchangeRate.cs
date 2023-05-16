using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastExchangeRate
    {
        public string CurrCode { get; set; }
        public string Dchannel { get; set; }
        public DateTime ActivateDt { get; set; }
        public decimal ExRate { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual MastCurrency CurrCodeNavigation { get; set; }
    }
}
