using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfSourceType
    {
        public string SourceType { get; set; }
        public string SourceName { get; set; }
        public string DelFlag { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
