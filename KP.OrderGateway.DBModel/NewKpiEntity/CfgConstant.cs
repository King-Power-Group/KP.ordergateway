using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CfgConstant
    {
        public string ConstantCode { get; set; }
        public string ConstantName { get; set; }
        public string ConstantTypeCode { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
