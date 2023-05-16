using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TblLog
    {
        public int Running { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int? OrderNo { get; set; }
        public DateTime? AddDatetime { get; set; }
        public string MessageCode { get; set; }
        public string SourcePlatform { get; set; }
        public string NameFunction { get; set; }
    }
}
