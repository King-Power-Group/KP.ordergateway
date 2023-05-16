using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class RunnoMachine
    {
        public string BranchNo { get; set; }
        public string MachineNo { get; set; }
        public double Taxabb { get; set; }
        public double Reciept { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
