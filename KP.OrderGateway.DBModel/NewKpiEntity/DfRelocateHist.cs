using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfRelocateHist
    {
        public string BranchNo { get; set; }
        public string PickupCode { get; set; }
        public DateTime AddDatetime { get; set; }
        public string OpaqNo { get; set; }
        public string ShoppingCard { get; set; }
        public short OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string MachineNo { get; set; }
        public string TaxabbNo { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightTime { get; set; }
        public DateTime ExpireDate { get; set; }
        public int HangingNo { get; set; }
        public int NoshowNo { get; set; }
        public string UserAdd { get; set; }
    }
}
