using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CeLovgroup
    {
        public CeLovgroup()
        {
            CeLov = new HashSet<CeLov>();
        }

        public string LovgroupCode { get; set; }
        public string LovgroupName { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<CeLov> CeLov { get; set; }
    }
}
