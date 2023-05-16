using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class jsonSessionKey
    {
        public string branchNo { get; set; }
        public string shoppingCard { get; set; }
        public int order { get; set; }
    }

    public class inputSessionkey
    {
        public string session_key { get; set; }
    }
}
