using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class MstTableAttribute
    {
        public string TableName { get; set; }
        public string Attribute { get; set; }
        public string Description { get; set; }
        public string Valuetype { get; set; }
    }
}
