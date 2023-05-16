using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoCertificate
    {
        public string Yearmonth { get; set; }
        public int Isperson { get; set; }
        public int Runno { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
