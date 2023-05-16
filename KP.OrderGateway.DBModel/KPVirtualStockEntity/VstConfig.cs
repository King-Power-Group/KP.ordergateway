using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstConfig
    {
        public long Id { get; set; }
        public string ConfigGroup { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
    }
}
