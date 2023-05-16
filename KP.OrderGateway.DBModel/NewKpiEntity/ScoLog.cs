using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class ScoLog
    {
        public ScoLog()
        {
            ScoSession = new HashSet<ScoSession>();
        }

        public long LogKey { get; set; }
        public string StatusCode { get; set; }
        public string LogBy { get; set; }
        public DateTime? LogDt { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ScoStatus StatusCodeNavigation { get; set; }
        public virtual ICollection<ScoSession> ScoSession { get; set; }
    }
}
