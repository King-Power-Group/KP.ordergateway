using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DiscBlock
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public bool? IsCancel { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
