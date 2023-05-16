using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CKCSite
    {
        [Key]
        public string siteCode { get; set; }
        public string siteName { get; set; }
        public long shiftCount { get; set; }
        public string conDType { get; set; }
        public string priceList { get; set; }
        public string dcChannel { get; set; }
        public bool isCancel { get; set; }
    }
}
