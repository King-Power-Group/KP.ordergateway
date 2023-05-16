using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSohistExt
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SuborderType { get; set; }
        public int LineNo { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual DfSohist DfSohist { get; set; }
    }
}
