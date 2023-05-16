using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CmFilterHeader
    {
        public long FilterHeaderKey { get; set; }
        public DateTime? CreatedDt { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string Remark { get; set; }
    }
}
