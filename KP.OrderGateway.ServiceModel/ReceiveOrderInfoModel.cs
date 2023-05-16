using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    /// <summary>
    /// ReceiveOrderInfoModel
    /// </summary>
    public class ReceiveOrderInfoModel
    {
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public string posIpAddress { get; set; }
        //public string posId { get; set; }
        //public string cashierMachine { get; set; }
        public string changeBy { get; set; }
        public string cashierCode { get; set; }
        public string remark { get; set; }
        public string cancelOrderMode { get; set; }
    }
}
