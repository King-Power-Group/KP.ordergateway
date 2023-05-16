using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class WalletAgentMaster
    {
        public WalletAgentMaster()
        {
            WalletAgentNavigation = new HashSet<WalletAgent>();
        }

        public string WalletAgent { get; set; }
        public int PartnerTypeId { get; set; }
        public string MerChantId { get; set; }
        public string WsUrl { get; set; }
        public string ApiUrl { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<WalletAgent> WalletAgentNavigation { get; set; }
    }
}
