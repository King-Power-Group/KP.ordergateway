using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.KPVirtualStockEntity
{
    public partial class VstRemainAll
    {
        public long id { get; set; }
        public string article_code { get; set; }
        public string site { get; set; }
        public string location { get; set; }
        public decimal qty { get; set; }
        public DateTime date { get; set; }
    }
}
