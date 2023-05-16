using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfHotel
    {
        public string HotelCode { get; set; }
        public string HotelName { get; set; }
        public string HotelAdd1 { get; set; }
        public string HotelAdd2 { get; set; }
        public string HotelAdd3 { get; set; }
        public string HotelZip { get; set; }
        public string HotelTel { get; set; }
        public string HotelFax { get; set; }
        public string HotelEmail { get; set; }
        public string HotelWww { get; set; }
        public decimal HotelComm { get; set; }
        public string SourceType { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
