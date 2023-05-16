using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class OrderHeaderInfoModle
    {
        public List<OrderTransInfoModle> ListOrderTransInfo { get; set; }
        public OrderPaidInfoModle OrderPaidInfo { get; set; }
    }
}
