using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TbgConfig
    {
        public TbgConfig()
        {
            TbgMachine = new HashSet<TbgMachine>();
        }

        public string TbgconfigCode { get; set; }
        public string TbgconfigName { get; set; }

        public virtual ICollection<TbgMachine> TbgMachine { get; set; }
    }
}
