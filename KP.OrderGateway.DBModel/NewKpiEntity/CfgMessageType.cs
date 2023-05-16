using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class CfgMessageType
    {
        public string MessageType { get; set; }
        public string MessageTypeName { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
