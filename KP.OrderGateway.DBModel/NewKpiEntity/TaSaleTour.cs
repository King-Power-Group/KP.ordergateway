using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TaSaleTour
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string Catecode { get; set; }
        public string Brandcode { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public decimal Netsale { get; set; }
        public decimal Payment { get; set; }
        public string TourCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public string CustTypeCode { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
