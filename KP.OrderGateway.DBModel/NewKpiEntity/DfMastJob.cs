using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMastJob
    {
        public string JobName { get; set; }
        public int JobId { get; set; }
        public string JobDesc { get; set; }
        public string Channel { get; set; }
        public string Org { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string UserCreate { get; set; }
        public string Wheremat { get; set; }
        public DateTime? Datadate { get; set; }
        public bool? BlnMat { get; set; }
        public bool? BlnCate { get; set; }
        public bool? BlnBrand { get; set; }
        public string Status { get; set; }
        public string Flag { get; set; }
    }
}
