using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class ConfigParam
    {
        public string branchNo { get; set; }
        public string subBranchCode { get; set; }
        public string configCode { get; set; }
        public bool isLike { get; set; }
    }

    public class ConfigData
    {
        public string configCode { get; set; }
        public string configValue { get; set; }
    }
}
