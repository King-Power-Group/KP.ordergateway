using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CeLov
    {
        public long Lovkey { get; set; }
        public string LovgroupCode { get; set; }
        public string Lovcode { get; set; }
        public string Lovvalue { get; set; }
        public byte[] TimeStamp { get; set; }
        public bool IsCanceled { get; set; }
        public string OrderNo { get; set; }

        public virtual CeLovgroup LovgroupCodeNavigation { get; set; }
    }
}
