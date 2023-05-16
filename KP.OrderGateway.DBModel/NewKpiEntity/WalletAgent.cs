using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class WalletAgent
    {
        public long WalletAgentKey { get; set; }
        public string BranchNo { get; set; }
        public string AreaCode { get; set; }
        public string LocCode { get; set; }
        public string MachineNo { get; set; }
        public string WalletType { get; set; }
        public string WalletAgent1 { get; set; }
        public DateTime AddDt { get; set; }
        public DateTime UpdateDt { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public byte[] TimeStamp { get; set; }

        public virtual DfBranch BranchNoNavigation { get; set; }
        public virtual DfArea DfArea { get; set; }
        public virtual DfLocation DfLocation { get; set; }
        public virtual DfMachine DfMachine { get; set; }
        public virtual WalletAgentMaster WalletAgent1Navigation { get; set; }
    }
}
