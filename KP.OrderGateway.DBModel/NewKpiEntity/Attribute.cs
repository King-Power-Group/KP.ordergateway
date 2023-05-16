using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Attribute
    {
        public long AttrKey { get; set; }
        public string AttrPrimary { get; set; }
        public string AttrValue { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
