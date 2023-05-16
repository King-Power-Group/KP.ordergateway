using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MastMc
    {
        public MastMc()
        {
            InverseMcparentNavigation = new HashSet<MastMc>();
            MastArticle = new HashSet<MastArticle>();
        }

        public string Mccode { get; set; }
        public string Mcname { get; set; }
        public string Mclevel { get; set; }
        public string Mcparent { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual MastMc McparentNavigation { get; set; }
        public virtual MastMcExtend MastMcExtend { get; set; }
        public virtual ICollection<MastMc> InverseMcparentNavigation { get; set; }
        public virtual ICollection<MastArticle> MastArticle { get; set; }
    }
}
