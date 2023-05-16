using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class NewHangingData
    {
        public NewHangingData()
        {
            NewHanging = new HashSet<NewHanging>();
            NewOpaqTf = new HashSet<NewOpaqTf>();
        }

        public string HangingDataKey { get; set; }
        public long HangingKey { get; set; }
        public string BranchNo { get; set; }
        public string ShoppingCard { get; set; }
        public int? OrderNo { get; set; }
        public string SuborderType { get; set; }
        public string CustomerName { get; set; }
        public string AirlineCode { get; set; }
        public string FlightCode { get; set; }
        public DateTime? FlightDt { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CashierMac { get; set; }
        public string TaxAbbNo { get; set; }
        public string TourCode { get; set; }
        public long? IssuedOpaqTfkey { get; set; }
        public string OpaqNo { get; set; }
        public long HangingDataRunning { get; set; }
        public string RecToPickupUser { get; set; }
        public DateTime? RecToPickupDt { get; set; }
        public string PassportNo { get; set; }
        public string RefDoc { get; set; }
        public string RefNo { get; set; }

        public virtual NewHanging HangingKeyNavigation { get; set; }
        public virtual NewOpaqTf IssuedOpaqTfkeyNavigation { get; set; }
        public virtual ICollection<NewHanging> NewHanging { get; set; }
        public virtual ICollection<NewOpaqTf> NewOpaqTf { get; set; }
    }
}
