using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastCurrency
    {
        public MastCurrency()
        {
            MastExchangeRate = new HashSet<MastExchangeRate>();
        }

        public string CurrCode { get; set; }
        public string CurrName { get; set; }
        public string CurrSymbol { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<MastExchangeRate> MastExchangeRate { get; set; }
    }
}
