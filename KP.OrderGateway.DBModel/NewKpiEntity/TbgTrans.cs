using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class TbgTrans
    {
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int OrderNo { get; set; }
        public string SuborderType { get; set; }
        public string TbagNo { get; set; }
        public string TbgconfigCode { get; set; }
        public long TbgrunNo { get; set; }
        public int TbgorderNo { get; set; }
    }
}
