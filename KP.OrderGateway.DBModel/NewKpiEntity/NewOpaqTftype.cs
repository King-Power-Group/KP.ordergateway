using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewOpaqTftype
    {
        public NewOpaqTftype()
        {
            NewOpaqTfheader = new HashSet<NewOpaqTfheader>();
        }

        public string OpaqTftypeCode { get; set; }
        public string OpaqTftypeName { get; set; }
        public string SortOrder { get; set; }
        public string TftypeGroupCode { get; set; }

        public virtual NewTftypeGroup TftypeGroupCodeNavigation { get; set; }
        public virtual ICollection<NewOpaqTfheader> NewOpaqTfheader { get; set; }
    }
}
