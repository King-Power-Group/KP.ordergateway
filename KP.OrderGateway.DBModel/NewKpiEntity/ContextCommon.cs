using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KP.OrderGateway.ServiceModel;
using Microsoft.EntityFrameworkCore;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class KPIMNPOSMAContext
    {
        public virtual DbSet<OrderModel> OrderModels { get; set; }
    }
}
