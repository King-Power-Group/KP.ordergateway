using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfCustomer
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public string DelFlag { get; set; }
        public string TourCode { get; set; }
        public int TourRunno { get; set; }
        public string MemberId { get; set; }
        public string CustName { get; set; }
        public string CustTypeCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PassportNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string CountryCode { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightTime { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string HotelCode { get; set; }
        public string HotelSource { get; set; }
        public bool? FastRegister { get; set; }
        public short Mob { get; set; }
        public short Yob { get; set; }
    }
}
