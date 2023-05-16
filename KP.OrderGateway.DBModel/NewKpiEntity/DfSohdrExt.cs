using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSohdrExt
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public byte[] TimeStamp { get; set; }
        public long runno { get; set; }

        public virtual DfSohdr DfSohdr { get; set; }
    }
}
