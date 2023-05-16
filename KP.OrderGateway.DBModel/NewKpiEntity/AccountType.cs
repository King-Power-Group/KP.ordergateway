using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class AccountType
    {
        public AccountType()
        {
            PvTrans = new HashSet<PvTrans>();
        }

        public long AccountTypeKey { get; set; }
        public string AccountName { get; set; }

        public virtual ICollection<PvTrans> PvTrans { get; set; }
    }
}
