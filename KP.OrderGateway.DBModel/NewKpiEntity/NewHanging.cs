using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHanging
    {
        public NewHanging()
        {
            NewHangingData = new HashSet<NewHangingData>();
            NewOpaqTfFromHanginKeyNavigation = new HashSet<NewOpaqTf>();
            NewOpaqTfToHangingKeyNavigation = new HashSet<NewOpaqTf>();
        }

        public long HangingKey { get; set; }
        public long HangingHeaderKey { get; set; }
        public string HangingNo { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsInTransit { get; set; }
        public byte[] TimeStamp { get; set; }
        public int? Running { get; set; }
        public string HangingDataKey { get; set; }

        public virtual NewHangingData HangingDataKeyNavigation { get; set; }
        public virtual NewHangingHeader HangingHeaderKeyNavigation { get; set; }
        public virtual ICollection<NewHangingData> NewHangingData { get; set; }
        public virtual ICollection<NewOpaqTf> NewOpaqTfFromHanginKeyNavigation { get; set; }
        public virtual ICollection<NewOpaqTf> NewOpaqTfToHangingKeyNavigation { get; set; }
    }
}
