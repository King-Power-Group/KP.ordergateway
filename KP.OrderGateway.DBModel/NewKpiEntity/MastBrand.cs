using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastBrand
    {
        public MastBrand()
        {
            MastArticle = new HashSet<MastArticle>();
        }

        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<MastArticle> MastArticle { get; set; }
    }
}
