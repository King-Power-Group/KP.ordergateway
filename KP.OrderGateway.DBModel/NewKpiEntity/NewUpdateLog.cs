using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewUpdateLog
    {
        public long UpdateLogKey { get; set; }
        public string ToBranchNo { get; set; }
        public string CommandGroup { get; set; }
        public string UpdateCommand { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
