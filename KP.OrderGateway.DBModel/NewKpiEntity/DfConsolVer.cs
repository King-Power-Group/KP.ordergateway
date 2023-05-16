using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfConsolVer
    {
        public string BranchNo { get; set; }
        public string TbagNo { get; set; }
        public short LineNo { get; set; }
        public string ShoppingCard { get; set; }
        public short OrderNo { get; set; }
        public string MatCode { get; set; }
        public int Quantity { get; set; }
        public int Recieve { get; set; }
        public decimal SellingPrice { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public long? SubSoHdrRecNo { get; set; }
    }
}
