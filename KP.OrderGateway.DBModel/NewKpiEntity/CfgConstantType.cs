using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CfgConstantType
    {
        public string ConstantTypeCode { get; set; }
        public string ConstantTypeName { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
