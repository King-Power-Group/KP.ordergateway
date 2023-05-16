using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ConfigPos
    {
        public long ConfigKey { get; set; }
        public string ConfigCode { get; set; }
        public string ConfigData { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
