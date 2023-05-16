using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class ChangeFlightPreOrderInfoModel
    {
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public List<listCustomer> lstCustomer { get; set; }
        public string subBranchCode { get; set; }
        public string airlineCode { get; set; }
        public string flightCode { get; set; }
        public DateTime flightDateTime { get; set; }
        public string changeBy { get; set; }
        public string remark { get; set; }
    }

    public class listCustomer
    {
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
    }

}
