using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TbgRunNo
    {
        public string TbgconfigCode { get; set; }
        public DateTime OrderDate { get; set; }
        public long RunNo { get; set; }
    }
}
