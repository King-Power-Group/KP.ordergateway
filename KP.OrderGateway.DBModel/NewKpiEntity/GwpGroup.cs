using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class GwpGroup
    {
        public GwpGroup()
        {
            GwpBrand = new HashSet<GwpBrand>();
            GwpCate = new HashSet<GwpCate>();
            GwpCoupon = new HashSet<GwpCoupon>();
            GwpCustType = new HashSet<GwpCustType>();
            GwpExcPaymeth = new HashSet<GwpExcPaymeth>();
            GwpItem = new HashSet<GwpItem>();
            GwpNation = new HashSet<GwpNation>();
            GwpPeriod = new HashSet<GwpPeriod>();
        }

        public string GroupCode { get; set; }
        public string GroupId { get; set; }

        public virtual ICollection<GwpBrand> GwpBrand { get; set; }
        public virtual ICollection<GwpCate> GwpCate { get; set; }
        public virtual ICollection<GwpCoupon> GwpCoupon { get; set; }
        public virtual ICollection<GwpCustType> GwpCustType { get; set; }
        public virtual ICollection<GwpExcPaymeth> GwpExcPaymeth { get; set; }
        public virtual ICollection<GwpItem> GwpItem { get; set; }
        public virtual ICollection<GwpNation> GwpNation { get; set; }
        public virtual ICollection<GwpPeriod> GwpPeriod { get; set; }
    }
}
