using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfFlight
    {
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public string DelFlag { get; set; }
        public string FlightDesc { get; set; }
        public string DestAirportCode { get; set; }
        public string ArrdepAirportCode { get; set; }
        public string ArrdepTerminal { get; set; }
        public bool? D2 { get; set; }
        public bool? D3 { get; set; }
        public bool? D4 { get; set; }
        public bool? D5 { get; set; }
        public bool? D6 { get; set; }
        public bool? D7 { get; set; }
        public bool? D1 { get; set; }
        public string ArrdepTime { get; set; }
        public bool OpenFlight { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string PickupCode { get; set; }
        public string CharterFlight { get; set; }
        public bool? OnlyLocal { get; set; }
    }
}
