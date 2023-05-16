using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewOpaqTf
    {
        public NewOpaqTf()
        {
            DfSubsohdr = new HashSet<DfSubsohdr>();
            NewHangingData = new HashSet<NewHangingData>();
        }

        public long OpaqTfkey { get; set; }
        public long OpaqTfheaderKey { get; set; }
        public long? FromHanginKey { get; set; }
        public long? ToHangingKey { get; set; }
        public DateTime? ReceiveDt { get; set; }
        public string ReceiveUser { get; set; }
        public byte[] TimeStamp { get; set; }
        public string HangingDataKey { get; set; }

        public virtual NewHanging FromHanginKeyNavigation { get; set; }
        public virtual NewHangingData HangingDataKeyNavigation { get; set; }
        public virtual NewOpaqTfheader OpaqTfheaderKeyNavigation { get; set; }
        public virtual NewHanging ToHangingKeyNavigation { get; set; }
        public virtual ICollection<DfSubsohdr> DfSubsohdr { get; set; }
        public virtual ICollection<NewHangingData> NewHangingData { get; set; }
    }
}
