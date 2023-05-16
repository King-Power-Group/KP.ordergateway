using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrCustType
    {
        public string BranchNo { get; set; }
        public string CustTypeCode { get; set; }
        public string CustTypeDesc { get; set; }
        public bool? CountPax { get; set; }
        public bool? CountAmount { get; set; }
        public bool? FlagAmtAll { get; set; }
    }
}
