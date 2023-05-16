using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DispatchTransPack
    {
        public long DispatchTransKey { get; set; }
        public string ShopCard { get; set; }
        public int order_no { get; set; }
    }
}
