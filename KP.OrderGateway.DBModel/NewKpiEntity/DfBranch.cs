using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfBranch
    {
        public DfBranch()
        {
            WalletAgent = new HashSet<WalletAgent>();
        }

        public string BranchNo { get; set; }
        public string DelFlag { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string Remark { get; set; }
        public string DefaultCustTour { get; set; }
        public string DefaultCustFit { get; set; }
        public int CutOffTime { get; set; }
        public int MaxFlightTime { get; set; }
        public string Plant { get; set; }
        public string CurrCode { get; set; }
        public short Channel { get; set; }
        public short MaxPerTbag { get; set; }
        public short OpaqPerBox { get; set; }
        public int SqlFetch { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string UserAdd { get; set; }
        public string UserUpdate { get; set; }
        public byte[] TimeStamp { get; set; }
        public string PrefixInv { get; set; }
        public bool? AutoTake { get; set; }
        public int CotWarningSale { get; set; }
        public int CotWarningSaleMin { get; set; }
        public int CotStopSale { get; set; }
        public int CotStopSaleMin { get; set; }
        public string HotelSourceType { get; set; }
        public string VatCode { get; set; }
        public string TaxNo { get; set; }
        public string MagnaticChar { get; set; }
        public decimal BuyLimit { get; set; }
        public short BuyLimitHour { get; set; }
        public int MinTruckLimit { get; set; }
        public int BroadcastPort { get; set; }
        public int RecTbagExtDay { get; set; }
        public string UrlStockService { get; set; }
        public bool CheckStkOnline { get; set; }
        public bool StopSale { get; set; }
        public DateTime CurrentOrderDate { get; set; }
        public decimal MaxOpenPrice { get; set; }
        public int? MaxTbagToBack { get; set; }
        public string ExceptBar1stDigit { get; set; }
        public string CustTypeBirthday { get; set; }
        public decimal SmcpointPerBaht { get; set; }
        public decimal SmcbahtPerPoint { get; set; }
        public bool AutoRcvtbag { get; set; }
        public int TakeWarningTimeMin { get; set; }
        public string Sapchannel { get; set; }
        public string Saporg { get; set; }
        public string PriceList { get; set; }
        public string Dchannel { get; set; }
        public int UrgentTbagHour { get; set; }
        public int UrgentTbagMinute { get; set; }
        public string ShortName { get; set; }
        public int UrgentRcvTbagHour { get; set; }
        public int UrgentRcvTbagMinute { get; set; }
        public int HoldTbagDay { get; set; }
        public string BranchLv { get; set; }
        public long StartFrn { get; set; }

        public virtual ICollection<WalletAgent> WalletAgent { get; set; }
    }
}
