using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkTaken
    {
        public string BranchNo { get; set; }
        public long SubSohdrRecNo { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime? FlightDt { get; set; }
        public string CustomerName { get; set; }
        public string PassportNo { get; set; }
        public string CountryCode { get; set; }
        public string Remark { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? CreateDt { get; set; }

        public virtual DfSubsohdr DfSubsohdr { get; set; }
    }
}
