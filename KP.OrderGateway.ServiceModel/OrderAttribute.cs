using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
   public class OrderAttribute
    {
        public string branch_no { get; set; }
        public string shopping_card { get; set; }
        public string order_no { get; set; }
    }


    public class OrderSubBranch
    {
        public string branchNo { get; set; }
        public string subBranchCode { get; set; }
        public string subBranchName { get; set; }
    }
}
