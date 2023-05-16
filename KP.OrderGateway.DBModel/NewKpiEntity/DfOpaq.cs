using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfOpaq
    {
        public string BranchNo { get; set; }
        public string TbagNo { get; set; }
        public string OpaqNo { get; set; }
        public string OpaqStaffCode { get; set; }
        public DateTime OpaqDate { get; set; }
        public DateTime OpaqDatetime { get; set; }
        public string BoxNo { get; set; }
        public string BoxStaffCode { get; set; }
        public DateTime? BoxDatetime { get; set; }
        public string PickStaffCode { get; set; }
        public DateTime? PickDatetime { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
