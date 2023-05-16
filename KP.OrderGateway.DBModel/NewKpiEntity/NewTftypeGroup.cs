using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewTftypeGroup
    {
        public NewTftypeGroup()
        {
            NewOpaqTftype = new HashSet<NewOpaqTftype>();
        }

        public string TftypeGroupCode { get; set; }
        public string TftypeGroupName { get; set; }

        public virtual ICollection<NewOpaqTftype> NewOpaqTftype { get; set; }
    }
}
