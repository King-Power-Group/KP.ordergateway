using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewOpaqTfheader
    {
        public NewOpaqTfheader()
        {
            NewOpaqTf = new HashSet<NewOpaqTf>();
        }

        public long OpaqTfheaderKey { get; set; }
        public string DocNo { get; set; }
        public DateTime? CreateDt { get; set; }
        public string UserCreate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string OpaqTftypeCode { get; set; }

        public virtual NewOpaqTftype OpaqTftypeCodeNavigation { get; set; }
        public virtual ICollection<NewOpaqTf> NewOpaqTf { get; set; }
    }
}
