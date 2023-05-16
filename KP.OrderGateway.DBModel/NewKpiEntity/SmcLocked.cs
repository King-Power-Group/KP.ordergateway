using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class SmcLocked
    {
        public long LockId { get; set; }
        public string LockCode { get; set; }
        public string LockName { get; set; }
        public string LockMessage { get; set; }
    }
}
