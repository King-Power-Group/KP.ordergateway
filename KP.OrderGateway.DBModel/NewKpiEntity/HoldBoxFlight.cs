using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class HoldBoxFlight
    {
        public HoldBoxFlight()
        {
            HoldBoxTbag = new HashSet<HoldBoxTbag>();
        }

        public long HoldBoxHeaderKey { get; set; }
        public int GroupNo { get; set; }
        public string BranchNo { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDt { get; set; }

        public virtual ICollection<HoldBoxTbag> HoldBoxTbag { get; set; }
    }
}
