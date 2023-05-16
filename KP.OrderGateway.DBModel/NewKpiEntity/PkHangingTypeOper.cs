using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class PkHangingTypeOper
    {
        public PkHangingTypeOper()
        {
            PkHangingTypeItems = new HashSet<PkHangingTypeItems>();
        }

        public string OperationCode { get; set; }
        public string OperationName { get; set; }

        public virtual ICollection<PkHangingTypeItems> PkHangingTypeItems { get; set; }
    }
}
