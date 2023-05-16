using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CsoTableAttribute
    {
        public long AttributeId { get; set; }
        public string TableName { get; set; }
        public string TableKey { get; set; }
        public string TableKeyValue { get; set; }
        public string AttributeName { get; set; }
        public string ValueType { get; set; }
        public string ValueString { get; set; }
        public decimal? ValueDecimal { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public bool? ValueBoolean { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
