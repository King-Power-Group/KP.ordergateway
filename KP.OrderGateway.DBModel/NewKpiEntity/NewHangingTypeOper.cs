using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingTypeOper
    {
        public NewHangingTypeOper()
        {
            NewHangingTypeItems = new HashSet<NewHangingTypeItems>();
        }

        public string OperationCode { get; set; }
        public string OperationName { get; set; }

        public virtual ICollection<NewHangingTypeItems> NewHangingTypeItems { get; set; }
    }
}
