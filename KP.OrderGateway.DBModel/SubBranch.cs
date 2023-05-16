using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel
{
    public class SubBranch
    {
        public string branchNo { get; set; }
        public string subBranchCode { get; set; }
        public string subBranchName { get; set; }
        public bool isCancel { get; set; }
    }
}
