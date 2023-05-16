using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class OrderInfoModel
    {
        public CustomerInfoModle CustomerInfo { get; set; }
        public FlightInfoModle FlightInfo { get; set; }
        public OrderHeaderInfoModle OrderHeaderInfo { get; set; }
    }

}
