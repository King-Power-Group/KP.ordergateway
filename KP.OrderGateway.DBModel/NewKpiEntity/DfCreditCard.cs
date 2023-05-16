using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCreditCard
    {
        public string CardPrefix { get; set; }
        public string CardName { get; set; }
        public short CardLength { get; set; }
        public string CardPrefix2 { get; set; }
        public bool CheckDigit { get; set; }
        public string MethodCode { get; set; }
    }
}
