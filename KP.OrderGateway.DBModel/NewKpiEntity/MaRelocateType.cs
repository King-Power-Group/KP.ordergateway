using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MaRelocateType
    {
        public short RelocateType { get; set; }
        public string RelocateName { get; set; }
        public int MaxRunno { get; set; }
        public int? NoshowType { get; set; }
    }
}
