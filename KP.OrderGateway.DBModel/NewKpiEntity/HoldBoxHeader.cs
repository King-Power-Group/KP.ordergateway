using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class HoldBoxHeader
    {
        public HoldBoxHeader()
        {
            HoldBoxTbag = new HashSet<HoldBoxTbag>();
        }

        public long HoldBoxHeaderKey { get; set; }
        public string BranchNo { get; set; }
        public string HoldBoxHeaderCode { get; set; }
        public DateTime? AddDt { get; set; }
        public string AddUser { get; set; }
        public DateTime? UpdateDt { get; set; }
        public string UpdateUser { get; set; }
        public string PickupCode { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual ICollection<HoldBoxTbag> HoldBoxTbag { get; set; }
    }
}
