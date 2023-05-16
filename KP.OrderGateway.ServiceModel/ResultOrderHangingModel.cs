using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class ResultOrderHangingModel
    {
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public string subOrderType { get; set; }
        public string errorString { get; set; }
    }
}
