using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    //public class OrderHangingModel
    //{
    //    public string branchNo { get; set; }
    //    public string shoppingCard { get; set; }
    //    public int orderNo { get; set; }
    //    public string subOrderType { get; set; }
    //    public string userCode { get; set; }
    //}

    public class OrderHangingModel
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SubOrderType { get; set; }
        public string MachineNo { get; set; }
        public string UserCode { get; set; }
        public string PickupCode { get; set; }
    }

}
