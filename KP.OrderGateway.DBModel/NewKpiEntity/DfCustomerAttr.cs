using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCustomerAttr
    {
        public long CustAttId { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
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
