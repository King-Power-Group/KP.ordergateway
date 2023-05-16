using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TrPayhdrAttr
    {
        public long PayHdrAttrId { get; set; }
        public string BranchNo { get; set; }
        public string DocGroup { get; set; }
        public string DocNo { get; set; }
        public string Attribute { get; set; }
        public string ValueType { get; set; }
        public string ValueString { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public decimal? ValueDecimal { get; set; }
        public bool? ValueBoolean { get; set; }
        public bool? IsCancel { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
