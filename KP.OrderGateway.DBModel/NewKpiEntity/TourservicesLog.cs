using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TourservicesLog
    {
        public int LogKey { get; set; }
        public DateTime LogDate { get; set; }
        public string Grouptype { get; set; }
        public string BranchNo { get; set; }
        public string DocGroup { get; set; }
        public string ErrMessage { get; set; }
        public string UserAdd { get; set; }
        public string IpAddress { get; set; }
    }
}
