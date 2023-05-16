using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ScoStatus
    {
        public ScoStatus()
        {
            ScoLog = new HashSet<ScoLog>();
        }

        public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<ScoLog> ScoLog { get; set; }
    }
}
