using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class StockModels
    {
        public string machineIp { get; set; }
    }

    public class ListSite
    {
        public List<groupSite> lstGroup { get; set; }
        public List<detailSite> lstSite { get; set; }
    }

    public class detailSite
    {
        public string site { get; set; }
        public string siteName { get; set; }
    }

    public class groupSite
    {
        public string grouptype { get; set; }
        public List<department> lstdept { get; set; }
        //public string groupValue { get; set; }
    }

    public class department
    {
        public string deptValue { get; set; }
    }
}
