using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ConsTableModify
    {
        public long ModifyKey { get; set; }
        public string TableName { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public DateTime? ModifyDt { get; set; }
        public string ModifyType { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
