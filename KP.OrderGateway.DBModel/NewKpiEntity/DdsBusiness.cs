using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DdsBusiness
    {
        public string BusinessCode { get; set; }
        public string BusinessName { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
