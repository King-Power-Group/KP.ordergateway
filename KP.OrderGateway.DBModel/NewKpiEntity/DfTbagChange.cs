using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfTbagChange
    {
        public string BranchNo { get; set; }
        public string TbagNo { get; set; }
        public string NewTbagNo { get; set; }
        public int CntLine { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string Userid { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
