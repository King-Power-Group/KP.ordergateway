using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class KPIMNPOSMAContext : DbContext
    {
        public KPIMNPOSMAContext()
        {
        }

        public KPIMNPOSMAContext(DbContextOptions<KPIMNPOSMAContext> options)
            : base(options)
        {
        }
        public virtual DbSet<DfExtendsLog> dfExtendsLog { get; set; }
        public virtual DbSet<Query> query { get; set; }
        public virtual DbSet<VstTimeStock> VstTimeStock { get; set; }
        public DbQuery<vArticleMC> vArticleMC { get; set; }
        //public DbQuery<vwDlvDispatch> vwDlvDispatch { get; set; }
        public virtual DbSet<ServiceModel.listProduct> datlstProduct { get; set; }
        public virtual DbSet<ServiceModel.OrderModel> lstData { get; set; }
        public virtual DbSet<ServiceModel.OrderModelShipping> dataShipping { get; set; }
        public virtual DbSet<ServiceModel.NewKPDModel> lstKpdModel { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<AgentConfig> AgentConfig { get; set; }
        public virtual DbSet<AgentExtend> AgentExtend { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<BankOfEdc> BankOfEdc { get; set; }
        public virtual DbSet<BankRetDtl> BankRetDtl { get; set; }
        public virtual DbSet<BankRetHdr> BankRetHdr { get; set; }
        public virtual DbSet<BankRetSum> BankRetSum { get; set; }
        public virtual DbSet<CancelPriceList> CancelPriceList { get; set; }
        public virtual DbSet<CashFinish> CashFinish { get; set; }
        public virtual DbSet<Ccbank> Ccbank { get; set; }
        public virtual DbSet<Cccurr> Cccurr { get; set; }
        public virtual DbSet<CccurrRate> CccurrRate { get; set; }
        public virtual DbSet<CeLov> CeLov { get; set; }
        public virtual DbSet<CeLovgroup> CeLovgroup { get; set; }
        public virtual DbSet<CfgConstant> CfgConstant { get; set; }
        public virtual DbSet<CfgConstantType> CfgConstantType { get; set; }
        public virtual DbSet<CfgMessageType> CfgMessageType { get; set; }
        public virtual DbSet<CheckInTemp> CheckInTemp { get; set; }
        public virtual DbSet<CitesAirport> CitesAirport { get; set; }
        public virtual DbSet<CitesDetail> CitesDetail { get; set; }
        public virtual DbSet<CitesHeader> CitesHeader { get; set; }
        public virtual DbSet<CitesName> CitesName { get; set; }
        public virtual DbSet<CitesType> CitesType { get; set; }
        public virtual DbSet<CmFilter> CmFilter { get; set; }
        public virtual DbSet<CmFilterHeader> CmFilterHeader { get; set; }
        public virtual DbSet<CommissionType> CommissionType { get; set; }
        public virtual DbSet<ConfigPos> ConfigPos { get; set; }
        public virtual DbSet<ConsSyncLog> ConsSyncLog { get; set; }
        public virtual DbSet<ConsTableModify> ConsTableModify { get; set; }
        public virtual DbSet<CsoLogUp2Sap> CsoLogUp2Sap { get; set; }
        public virtual DbSet<CsoPossalesHeader> CsoPossalesHeader { get; set; }
        public virtual DbSet<CsoSapIdoc> CsoSapIdoc { get; set; }
        public virtual DbSet<CsoSapzposHeader> CsoSapzposHeader { get; set; }
        public virtual DbSet<CsoTableAttribute> CsoTableAttribute { get; set; }
        public virtual DbSet<CutOffTime> CutOffTime { get; set; }
        public virtual DbSet<DdsBusiness> DdsBusiness { get; set; }
        public virtual DbSet<DdsIdocLog> DdsIdocLog { get; set; }
        public virtual DbSet<Delight2014> Delight2014 { get; set; }
        public virtual DbSet<DfActiveVoucher> DfActiveVoucher { get; set; }
        public virtual DbSet<DfAgent> DfAgent { get; set; }
        public virtual DbSet<DfAirline> DfAirline { get; set; }
        public virtual DbSet<DfAirport> DfAirport { get; set; }
        public virtual DbSet<DfAppvPvDtl> DfAppvPvDtl { get; set; }
        public virtual DbSet<DfAppvPvHdr> DfAppvPvHdr { get; set; }
        public virtual DbSet<DfArea> DfArea { get; set; }
        public virtual DbSet<DfAuth> DfAuth { get; set; }
        public virtual DbSet<DfAuthGrp> DfAuthGrp { get; set; }
        public virtual DbSet<DfBank> DfBank { get; set; }
        public virtual DbSet<DfBox> DfBox { get; set; }
        public virtual DbSet<DfBoxCancel> DfBoxCancel { get; set; }
        public virtual DbSet<DfBranch> DfBranch { get; set; }
        public virtual DbSet<DfCardType> DfCardType { get; set; }
        public virtual DbSet<DfChange> DfChange { get; set; }
        public virtual DbSet<DfCity> DfCity { get; set; }
        public virtual DbSet<DfCommDoc> DfCommDoc { get; set; }
        public virtual DbSet<DfCommDtl> DfCommDtl { get; set; }
        public virtual DbSet<DfCommRate> DfCommRate { get; set; }
        public virtual DbSet<DfComputer> DfComputer { get; set; }
        public virtual DbSet<DfConnection> DfConnection { get; set; }
        public virtual DbSet<DfConsolVer> DfConsolVer { get; set; }
        public virtual DbSet<DfCountry> DfCountry { get; set; }
        public virtual DbSet<DfCreditCard> DfCreditCard { get; set; }
        public virtual DbSet<DfCurrency> DfCurrency { get; set; }
        public virtual DbSet<DfCustType> DfCustType { get; set; }
        public virtual DbSet<DfCustomer> DfCustomer { get; set; }
        public virtual DbSet<DfCustomerAttr> DfCustomerAttr { get; set; }
        public virtual DbSet<DfDiscount> DfDiscount { get; set; }
        public virtual DbSet<DfErrorLog> DfErrorLog { get; set; }
        public virtual DbSet<DfFlight> DfFlight { get; set; }
        public virtual DbSet<DfGroup> DfGroup { get; set; }
        public virtual DbSet<DfGuideGroup> DfGuideGroup { get; set; }
        public virtual DbSet<DfHanging> DfHanging { get; set; }
        public virtual DbSet<DfHotel> DfHotel { get; set; }
        public virtual DbSet<DfInshopHdr> DfInshopHdr { get; set; }
        public virtual DbSet<DfInshopRate> DfInshopRate { get; set; }
        public virtual DbSet<DfInshopSubtrans> DfInshopSubtrans { get; set; }
        public virtual DbSet<DfInshopTrans> DfInshopTrans { get; set; }
        public virtual DbSet<DfInshopType> DfInshopType { get; set; }
        public virtual DbSet<DfInv> DfInv { get; set; }
        public virtual DbSet<DfIssuedType> DfIssuedType { get; set; }
        public virtual DbSet<DfLocation> DfLocation { get; set; }
        public virtual DbSet<DfLockShopCard> DfLockShopCard { get; set; }
        public virtual DbSet<DfMachine> DfMachine { get; set; }
        public virtual DbSet<DfMagnetic> DfMagnetic { get; set; }
        public virtual DbSet<DfMagneticLog> DfMagneticLog { get; set; }
        public virtual DbSet<DfMastJob> DfMastJob { get; set; }
        public virtual DbSet<DfMemNotify> DfMemNotify { get; set; }
        public virtual DbSet<DfMemberCheckin> DfMemberCheckin { get; set; }
        public virtual DbSet<DfMemberGuest> DfMemberGuest { get; set; }
        public virtual DbSet<DfMemberLog> DfMemberLog { get; set; }
        public virtual DbSet<DfMemhist> DfMemhist { get; set; }
        public virtual DbSet<DfMileage> DfMileage { get; set; }
        public virtual DbSet<DfMileageVendor> DfMileageVendor { get; set; }
        public virtual DbSet<DfMultiSave> DfMultiSave { get; set; }
        public virtual DbSet<DfMultiSaveError> DfMultiSaveError { get; set; }
        public virtual DbSet<DfOpaq> DfOpaq { get; set; }
        public virtual DbSet<DfOpaqTrans> DfOpaqTrans { get; set; }
        public virtual DbSet<DfOperGrp> DfOperGrp { get; set; }
        public virtual DbSet<DfPayment> DfPayment { get; set; }
        public virtual DbSet<DfPaymeth> DfPaymeth { get; set; }
        public virtual DbSet<DfPaymethGrp> DfPaymethGrp { get; set; }
        public virtual DbSet<DfPickup> DfPickup { get; set; }
        public virtual DbSet<DfPoc> DfPoc { get; set; }
        public virtual DbSet<DfPrize> DfPrize { get; set; }
        public virtual DbSet<DfPromotion> DfPromotion { get; set; }
        public virtual DbSet<DfProvince> DfProvince { get; set; }
        public virtual DbSet<DfPuLocation> DfPuLocation { get; set; }
        public virtual DbSet<DfRcvTbagGrp> DfRcvTbagGrp { get; set; }
        public virtual DbSet<DfRcvTbagMac> DfRcvTbagMac { get; set; }
        public virtual DbSet<DfRefundDoc> DfRefundDoc { get; set; }
        public virtual DbSet<DfRefundMatdoc> DfRefundMatdoc { get; set; }
        public virtual DbSet<DfRefundTrans> DfRefundTrans { get; set; }
        public virtual DbSet<DfRelocateHist> DfRelocateHist { get; set; }
        public virtual DbSet<DfReprintLog> DfReprintLog { get; set; }
        public virtual DbSet<DfReprintReceiptLog> DfReprintReceiptLog { get; set; }
        public virtual DbSet<DfSelectGrp> DfSelectGrp { get; set; }
        public virtual DbSet<DfSelectItem> DfSelectItem { get; set; }
        public virtual DbSet<DfSerialNo> DfSerialNo { get; set; }
        public virtual DbSet<DfSohdr> DfSohdr { get; set; }
        public virtual DbSet<DfSohdrExt> DfSohdrExt { get; set; }
        public virtual DbSet<DfSohdrExtend> DfSohdrExtend { get; set; }
        public virtual DbSet<DfSohist> DfSohist { get; set; }
        public virtual DbSet<DfSohistExt> DfSohistExt { get; set; }
        public virtual DbSet<DfSourceType> DfSourceType { get; set; }
        public virtual DbSet<DfSpendingHdr> DfSpendingHdr { get; set; }
        public virtual DbSet<DfSpendingRate> DfSpendingRate { get; set; }
        public virtual DbSet<DfSpendingTrans> DfSpendingTrans { get; set; }
        public virtual DbSet<DfSubagent> DfSubagent { get; set; }
        public virtual DbSet<DfSuborderType> DfSuborderType { get; set; }
        public virtual DbSet<DfSubpayment> DfSubpayment { get; set; }
        public virtual DbSet<DfSubsohdr> DfSubsohdr { get; set; }
        public virtual DbSet<DfSubsohdrExt> DfSubsohdrExt { get; set; }
        public virtual DbSet<DfTbagChange> DfTbagChange { get; set; }
        public virtual DbSet<DfTbagCont> DfTbagCont { get; set; }
        public virtual DbSet<DfTourExtend> DfTourExtend { get; set; }
        public virtual DbSet<DfTourhdr> DfTourhdr { get; set; }
        public virtual DbSet<DfTransport> DfTransport { get; set; }
        public virtual DbSet<DfTruck> DfTruck { get; set; }
        public virtual DbSet<DfTruckCont> DfTruckCont { get; set; }
        public virtual DbSet<DfUpdateLog> DfUpdateLog { get; set; }
        public virtual DbSet<DfUpdateLogHistory> DfUpdateLogHistory { get; set; }
        public virtual DbSet<DfUser> DfUser { get; set; }
        public virtual DbSet<DfUserGrp> DfUserGrp { get; set; }
        public virtual DbSet<DfVat> DfVat { get; set; }
        public virtual DbSet<DfVatRefund> DfVatRefund { get; set; }
        public virtual DbSet<DfVatRefundAddress> DfVatRefundAddress { get; set; }
        public virtual DbSet<DfVatRefundIncentive> DfVatRefundIncentive { get; set; }
        public virtual DbSet<DfVatRefundRate> DfVatRefundRate { get; set; }
        public virtual DbSet<DfVoucher> DfVoucher { get; set; }
        public virtual DbSet<DfVoucherCancel> DfVoucherCancel { get; set; }
        public virtual DbSet<DiscAuthHeader> DiscAuthHeader { get; set; }
        public virtual DbSet<DiscAuthUser> DiscAuthUser { get; set; }
        public virtual DbSet<DiscBlock> DiscBlock { get; set; }
        public virtual DbSet<DiscConstrainAnd> DiscConstrainAnd { get; set; }
        public virtual DbSet<DiscConstrainFilter> DiscConstrainFilter { get; set; }
        public virtual DbSet<DiscConstrainHd> DiscConstrainHd { get; set; }
        public virtual DbSet<DiscConstrainValue> DiscConstrainValue { get; set; }
        public virtual DbSet<Dtserver> Dtserver { get; set; }
        public virtual DbSet<Edcissuer> Edcissuer { get; set; }
        public virtual DbSet<Edclog> Edclog { get; set; }
        public virtual DbSet<EditSoHdr> EditSoHdr { get; set; }
        public virtual DbSet<ExpenseType> ExpenseType { get; set; }
        public virtual DbSet<Gvactivate> Gvactivate { get; set; }
        public virtual DbSet<GvbarcodeFix> GvbarcodeFix { get; set; }
        public virtual DbSet<GwpBrand> GwpBrand { get; set; }
        public virtual DbSet<GwpCate> GwpCate { get; set; }
        public virtual DbSet<GwpCoupon> GwpCoupon { get; set; }
        public virtual DbSet<GwpCouponTrans> GwpCouponTrans { get; set; }
        public virtual DbSet<GwpCustType> GwpCustType { get; set; }
        public virtual DbSet<GwpExcPaymeth> GwpExcPaymeth { get; set; }
        public virtual DbSet<GwpGroup> GwpGroup { get; set; }
        public virtual DbSet<GwpItem> GwpItem { get; set; }
        public virtual DbSet<GwpMachine> GwpMachine { get; set; }
        public virtual DbSet<GwpNation> GwpNation { get; set; }
        public virtual DbSet<GwpPeriod> GwpPeriod { get; set; }
        public virtual DbSet<HoldBoxFlight> HoldBoxFlight { get; set; }
        public virtual DbSet<HoldBoxHeader> HoldBoxHeader { get; set; }
        public virtual DbSet<HoldBoxTbag> HoldBoxTbag { get; set; }
        public virtual DbSet<Inbound> Inbound { get; set; }
        public virtual DbSet<InshopExtraRateCfg> InshopExtraRateCfg { get; set; }
        public virtual DbSet<MaAction> MaAction { get; set; }
        public virtual DbSet<MaAuthType> MaAuthType { get; set; }
        public virtual DbSet<MaInstall> MaInstall { get; set; }
        public virtual DbSet<MaInstallCur> MaInstallCur { get; set; }
        public virtual DbSet<MaModule> MaModule { get; set; }
        public virtual DbSet<MaModuleCur> MaModuleCur { get; set; }
        public virtual DbSet<MaModuleHist> MaModuleHist { get; set; }
        public virtual DbSet<MaObjAuth> MaObjAuth { get; set; }
        public virtual DbSet<MaRelocateType> MaRelocateType { get; set; }
        public virtual DbSet<MainConnectStatus> MainConnectStatus { get; set; }
        public virtual DbSet<MastArticle> MastArticle { get; set; }
        public virtual DbSet<MastBrand> MastBrand { get; set; }
        public virtual DbSet<MastChequeLocation> MastChequeLocation { get; set; }
        public virtual DbSet<MastCurrency> MastCurrency { get; set; }
        public virtual DbSet<MastEan> MastEan { get; set; }
        public virtual DbSet<MastExchangeRate> MastExchangeRate { get; set; }
        public virtual DbSet<MastMc> MastMc { get; set; }
        public virtual DbSet<MastMcExtend> MastMcExtend { get; set; }
        public virtual DbSet<MastPrice> MastPrice { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberCard> MemberCard { get; set; }
        public virtual DbSet<Memguest> Memguest { get; set; }
        public virtual DbSet<MhnPushOrderLog> MhnPushOrderLog { get; set; }
        public virtual DbSet<MstAgentstatus> MstAgentstatus { get; set; }
        public virtual DbSet<MstCardType> MstCardType { get; set; }
        public virtual DbSet<MstTableAttribute> MstTableAttribute { get; set; }
        public virtual DbSet<NewBranchConfig> NewBranchConfig { get; set; }
        public virtual DbSet<NewHanging> NewHanging { get; set; }
        public virtual DbSet<NewHangingAllocateHist> NewHangingAllocateHist { get; set; }
        public virtual DbSet<NewHangingData> NewHangingData { get; set; }
        public virtual DbSet<NewHangingHeader> NewHangingHeader { get; set; }
        public virtual DbSet<NewHangingType> NewHangingType { get; set; }
        public virtual DbSet<NewHangingTypeCf> NewHangingTypeCf { get; set; }
        public virtual DbSet<NewHangingTypeHead> NewHangingTypeHead { get; set; }
        public virtual DbSet<NewHangingTypeItem> NewHangingTypeItem { get; set; }
        public virtual DbSet<NewHangingTypeItems> NewHangingTypeItems { get; set; }
        public virtual DbSet<NewHangingTypeOper> NewHangingTypeOper { get; set; }
        public virtual DbSet<NewOpaqTf> NewOpaqTf { get; set; }
        public virtual DbSet<NewOpaqTfheader> NewOpaqTfheader { get; set; }
        public virtual DbSet<NewOpaqTftype> NewOpaqTftype { get; set; }
        public virtual DbSet<NewTftypeGroup> NewTftypeGroup { get; set; }
        public virtual DbSet<NewUpdateLog> NewUpdateLog { get; set; }
        public virtual DbSet<OpaqRefNo> OpaqRefNo { get; set; }
        public virtual DbSet<PaysessPaytran> PaysessPaytran { get; set; }
        public virtual DbSet<PaysessPaytranMovement> PaysessPaytranMovement { get; set; }
        public virtual DbSet<PaysessSession> PaysessSession { get; set; }
        public virtual DbSet<PaysessSessionMovement> PaysessSessionMovement { get; set; }
        public virtual DbSet<PkBoxDetail> PkBoxDetail { get; set; }
        public virtual DbSet<PkBoxHeader> PkBoxHeader { get; set; }
        public virtual DbSet<PkBranchConfig> PkBranchConfig { get; set; }
        public virtual DbSet<PkHanging> PkHanging { get; set; }
        public virtual DbSet<PkHangingAllocateHist> PkHangingAllocateHist { get; set; }
        public virtual DbSet<PkHangingHeader> PkHangingHeader { get; set; }
        public virtual DbSet<PkHangingType> PkHangingType { get; set; }
        public virtual DbSet<PkHangingTypeCf> PkHangingTypeCf { get; set; }
        public virtual DbSet<PkHangingTypeHead> PkHangingTypeHead { get; set; }
        public virtual DbSet<PkHangingTypeItem> PkHangingTypeItem { get; set; }
        public virtual DbSet<PkHangingTypeItems> PkHangingTypeItems { get; set; }
        public virtual DbSet<PkHangingTypeOper> PkHangingTypeOper { get; set; }
        public virtual DbSet<PkPackingNo> PkPackingNo { get; set; }
        public virtual DbSet<PkPackingRunner> PkPackingRunner { get; set; }
        public virtual DbSet<PkTaken> PkTaken { get; set; }
        public virtual DbSet<PkTbaq> PkTbaq { get; set; }
        public virtual DbSet<PkTftypeGroup> PkTftypeGroup { get; set; }
        public virtual DbSet<PkTransfer> PkTransfer { get; set; }
        public virtual DbSet<PkTransferHeader> PkTransferHeader { get; set; }
        public virtual DbSet<PkTransferType> PkTransferType { get; set; }
        public virtual DbSet<PkTripDetail> PkTripDetail { get; set; }
        public virtual DbSet<PkTripHeader> PkTripHeader { get; set; }
        public virtual DbSet<PreOrderChangeFlight> PreOrderChangeFlight { get; set; }
        public virtual DbSet<PromoBranch> PromoBranch { get; set; }
        public virtual DbSet<PromoSubBranch> PromoSubBranch { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<PvHeader> PvHeader { get; set; }
        public virtual DbSet<PvHeaderLog> PvHeaderLog { get; set; }
        public virtual DbSet<PvSummary> PvSummary { get; set; }
        public virtual DbSet<PvTastatement> PvTastatement { get; set; }
        public virtual DbSet<PvTrans> PvTrans { get; set; }
        public virtual DbSet<PvappvHist> PvappvHist { get; set; }
        public virtual DbSet<PvchqHist> PvchqHist { get; set; }
        public virtual DbSet<Qrcode> Qrcode { get; set; }
        public virtual DbSet<RemitDetail> RemitDetail { get; set; }
        public virtual DbSet<RemitHeader> RemitHeader { get; set; }
        public virtual DbSet<RemitHistory> RemitHistory { get; set; }
        public virtual DbSet<RemitIncentive> RemitIncentive { get; set; }
        public virtual DbSet<RemitShortOver> RemitShortOver { get; set; }
        public virtual DbSet<RewardDtl> RewardDtl { get; set; }
        public virtual DbSet<RewardHdr> RewardHdr { get; set; }
        public virtual DbSet<RunNoRefundNoPur> RunNoRefundNoPur { get; set; }
        public virtual DbSet<Runno50bis> Runno50bis { get; set; }
        public virtual DbSet<RunnoBox> RunnoBox { get; set; }
        public virtual DbSet<RunnoCertificate> RunnoCertificate { get; set; }
        public virtual DbSet<RunnoComm> RunnoComm { get; set; }
        public virtual DbSet<RunnoFrn> RunnoFrn { get; set; }
        public virtual DbSet<RunnoInshop> RunnoInshop { get; set; }
        public virtual DbSet<RunnoInv> RunnoInv { get; set; }
        public virtual DbSet<RunnoMachine> RunnoMachine { get; set; }
        public virtual DbSet<RunnoNoshow> RunnoNoshow { get; set; }
        public virtual DbSet<RunnoOpaq> RunnoOpaq { get; set; }
        public virtual DbSet<RunnoPutrans> RunnoPutrans { get; set; }
        public virtual DbSet<RunnoRefund> RunnoRefund { get; set; }
        public virtual DbSet<RunnoRefundGrp> RunnoRefundGrp { get; set; }
        public virtual DbSet<RunnoSmc> RunnoSmc { get; set; }
        public virtual DbSet<RunnoSpending> RunnoSpending { get; set; }
        public virtual DbSet<RunnoTbag> RunnoTbag { get; set; }
        public virtual DbSet<RunnoTouragent> RunnoTouragent { get; set; }
        public virtual DbSet<RunnoTourhdr> RunnoTourhdr { get; set; }
        public virtual DbSet<RunnoTrip> RunnoTrip { get; set; }
        public virtual DbSet<RunnoWt> RunnoWt { get; set; }
        public virtual DbSet<RunnoXHanging> RunnoXHanging { get; set; }
        public virtual DbSet<ScoLog> ScoLog { get; set; }
        public virtual DbSet<ScoPaymeth> ScoPaymeth { get; set; }
        public virtual DbSet<ScoSession> ScoSession { get; set; }
        public virtual DbSet<ScoSessionDetail> ScoSessionDetail { get; set; }
        public virtual DbSet<ScoStatus> ScoStatus { get; set; }
        public virtual DbSet<SessionDetail> SessionDetail { get; set; }
        public virtual DbSet<SessionHeader> SessionHeader { get; set; }
        public virtual DbSet<SmcBirthday> SmcBirthday { get; set; }
        public virtual DbSet<SmcCardActive> SmcCardActive { get; set; }
        public virtual DbSet<SmcCoupon> SmcCoupon { get; set; }
        public virtual DbSet<SmcHeader> SmcHeader { get; set; }
        public virtual DbSet<SmcLocked> SmcLocked { get; set; }
        public virtual DbSet<SmcMovementType> SmcMovementType { get; set; }
        public virtual DbSet<SmcPaymethNopoint> SmcPaymethNopoint { get; set; }
        public virtual DbSet<SmcTrans> SmcTrans { get; set; }
        public virtual DbSet<SmcUpcardCond> SmcUpcardCond { get; set; }
        public virtual DbSet<SmcUpgrade> SmcUpgrade { get; set; }
        public virtual DbSet<SmcValue> SmcValue { get; set; }
        public virtual DbSet<SmcValueCode> SmcValueCode { get; set; }
        public virtual DbSet<SmcValueType> SmcValueType { get; set; }
        public virtual DbSet<SolByMacCate> SolByMacCate { get; set; }
        public virtual DbSet<SolByType> SolByType { get; set; }
        public virtual DbSet<SolTarget> SolTarget { get; set; }
        public virtual DbSet<SurrogateKey> SurrogateKey { get; set; }
        public virtual DbSet<TaCondition> TaCondition { get; set; }
        public virtual DbSet<TaSaleTour> TaSaleTour { get; set; }
        public virtual DbSet<TableAttribute> TableAttribute { get; set; }
        public virtual DbSet<TacarRegDtl> TacarRegDtl { get; set; }
        public virtual DbSet<TacarRegHdr> TacarRegHdr { get; set; }
        public virtual DbSet<TastateDtl> TastateDtl { get; set; }
        public virtual DbSet<TastateHdr> TastateHdr { get; set; }
        public virtual DbSet<TastateHdrAttr> TastateHdrAttr { get; set; }
        public virtual DbSet<TastatePax> TastatePax { get; set; }
        public virtual DbSet<TbgConfig> TbgConfig { get; set; }
        public virtual DbSet<TbgMachine> TbgMachine { get; set; }
        public virtual DbSet<TbgRunNo> TbgRunNo { get; set; }
        public virtual DbSet<TbgTrans> TbgTrans { get; set; }
        public virtual DbSet<TblLog> TblLog { get; set; }
        public virtual DbSet<TblUi> TblUi { get; set; }
        public virtual DbSet<TcPayDtl> TcPayDtl { get; set; }
        public virtual DbSet<TcPayHdr> TcPayHdr { get; set; }
        public virtual DbSet<TempMachine> TempMachine { get; set; }
        public virtual DbSet<TourservicesLog> TourservicesLog { get; set; }
        public virtual DbSet<TrCommPerHead> TrCommPerHead { get; set; }
        public virtual DbSet<TrCondition> TrCondition { get; set; }
        public virtual DbSet<TrConditionLog> TrConditionLog { get; set; }
        public virtual DbSet<TrCustType> TrCustType { get; set; }
        public virtual DbSet<TrHead> TrHead { get; set; }
        public virtual DbSet<TrMarket> TrMarket { get; set; }
        public virtual DbSet<TrNonAmount> TrNonAmount { get; set; }
        public virtual DbSet<TrPayCateBrand> TrPayCateBrand { get; set; }
        public virtual DbSet<TrPaydtl> TrPaydtl { get; set; }
        public virtual DbSet<TrPaydtlExtend> TrPaydtlExtend { get; set; }
        public virtual DbSet<TrPayhdr> TrPayhdr { get; set; }
        public virtual DbSet<TrPayhdrAttr> TrPayhdrAttr { get; set; }
        public virtual DbSet<WalletAgent> WalletAgent { get; set; }
        public virtual DbSet<WalletAgentMaster> WalletAgentMaster { get; set; }
        public virtual DbSet<WalletPrefix> WalletPrefix { get; set; }
        public virtual DbSet<Whtdoc> Whtdoc { get; set; }
        public virtual DbSet<DispatchTransPack> DispatchTransPack { get; set; }
        public virtual DbSet<DfHangingapi> DfHangingapis { get; set; }
        public virtual DbSet<LogHangingApi> LogHangingApis { get; set; }
        public virtual DbSet<LogChangeShipping> LogChangeShipping { get; set; }
        public virtual DbSet<ServiceModel.dfSohdrExtTable> DfSohdrExtTables { get; set; }
        public virtual DbSet<CKCMachine> CKCMachine { get; set; }
        public virtual DbSet<CKCMachineSite> CKCMachineSite { get; set; }
        public virtual DbSet<CKCSite> CKCSite { get; set; }
        public virtual DbSet<CKCMachineSettings> CKCMachineSettings { get; set; }
        public virtual DbSet<SAPTransferOrder> SAPTransferOrders { get; set; }
        public virtual DbSet<MaConfig> MaConfig { get; set; }

        // Unable to generate entity type for table 'dbo.ZFlatList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RunNo_Session'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_member'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MAC'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.xxx'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_vat_machine'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_vat_printer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mst_country_group'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.runno_AppvPv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.err_hanging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.err_hang2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.runno_PVRcvInv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.InshopAgentException'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_hanging_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.runno_subagent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RunNo_PreApprove'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RunNo_Approve'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_member_guest_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.runno_download'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.runno_upload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_tmp_customer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_tmp_sohdr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.z_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ServerReport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Runno_TCPayment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_count_stock'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ma_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RValidColection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ChencInTempBackup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SMC_Configuration'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.runno_member'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.errBox'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_member_guest_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AZFlatList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_member_checkin_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.New_HangingError'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.df_cardhist'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer("Server=10.3.0.56;Database=NewKpi;User Id=sa;Password=sql2000;");
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Query<vArticleMC>().ToView("vArticleMC");
            modelBuilder.Entity<ServiceModel.OrderModel>().HasKey(c => new { c.branchNo, c.shoppingCard, c.orderNo });
            modelBuilder.Entity<ServiceModel.OrderModelShipping>().HasKey(c => new { c.branchNo, c.shoppingCard, c.orderNo });
            modelBuilder.Entity<ServiceModel.dfSohdrExtTable>().HasKey(x => new { x.branch_no, x.shopping_card, x.order_no });
            modelBuilder.Entity<ServiceModel.NewKPDModel>().HasKey(x => new { x.branchNo, x.shoppingCard, x.orderNo });
            //modelBuilder.Query<vwDlvDispatch>().ToView("vwDlvDispatch");
            //modelBuilder.Entity<vwDlvDispatch>().HasKey(c => new { c.ShopCard, c.orderNo });


            modelBuilder.Entity<MaConfig>(en => {
                en.ToTable("ma_config");
            });

            modelBuilder.Entity<SAPTransferOrder>(en =>
            {
                en.ToTable("SAP_TransferOrder");
            });

            modelBuilder.Entity<CKCMachine>(entity =>
            {
                entity.ToTable("CKC_Machine");
                entity.Property(e => e.machineNo).HasColumnName("machine_no").ValueGeneratedNever();
                entity.Property(e => e.machineIP).HasColumnName("machine_ip");
                entity.Property(e => e.machineName).HasColumnName("machine_name");
                entity.Property(e => e.isCancel).HasColumnName("is_cancel");
            });


            modelBuilder.Entity<CKCMachineSite>(entity =>
            {
                entity.ToTable("CKC_MachineSite");
                entity.Property(e => e.key).HasColumnName("key").ValueGeneratedOnAdd();
                entity.Property(e => e.machineNo).HasColumnName("machine_no");
                entity.Property(e => e.siteCode).HasColumnName("site_code");
            });

            modelBuilder.Entity<CKCMachineSettings>(entity =>
            {
                entity.ToTable("CKC_MachineSettings");
                entity.Property(e => e.running).HasColumnName("running").ValueGeneratedOnAdd();
                entity.Property(e => e.machine_no).HasColumnName("machineNo");
                entity.Property(e => e.machine_group).HasColumnName("machineGroupCode");
                entity.Property(e => e.machine_value).HasColumnName("machineValue");
            });


            modelBuilder.Entity<CKCSite>(entity =>
            {
                entity.ToTable("CKC_Site");
                entity.Property(e => e.siteCode).HasColumnName("site_code").ValueGeneratedNever();
                entity.Property(e => e.siteName).HasColumnName("site_name");
                entity.Property(e => e.shiftCount).HasColumnName("shift_count");
                entity.Property(e => e.conDType).HasColumnName("cond_type");
                entity.Property(e => e.priceList).HasColumnName("price_list");
                entity.Property(e => e.dcChannel).HasColumnName("dc_channel");
                entity.Property(e => e.isCancel).HasColumnName("is_cancel");

            });


            modelBuilder.Entity<LogChangeShipping>(entity =>
            {
                entity.ToTable("Log_ChangeShipping");
                entity.HasKey("id");
                entity.Property(e => e.id).HasColumnName("id").ValueGeneratedOnAdd();
                entity.Property(e => e.sessionID).HasColumnName("sessionID");
                entity.Property(e => e.sessionValue).HasColumnName("sessionValue");
                entity.Property(e => e.userUpdateBy).HasColumnName("userUpdateBy");
                entity.Property(e => e.userUpdateDatetime).HasColumnName("userUpdateDatetime");
            });

            modelBuilder.Entity<DfExtendsLog>(entity =>
            {
                entity.HasKey(e => e.running);
                entity.ToTable("df_extend_log");
                entity.Property(e => e.running).HasColumnName("running").ValueGeneratedOnAdd();
                entity.Property(e => e.tableLog).HasColumnName("tablelog");
                entity.Property(e => e.runno).HasColumnName("runno");
                entity.Property(e => e.userCode).HasColumnName("userCode");
                entity.Property(e => e.valueCode).HasColumnName("valueCode");
                entity.Property(e => e.datetime).HasColumnName("datetime");
            });

            modelBuilder.Entity<LogHangingApi>(entity =>
            {
                entity.HasKey(e => e.running);
                entity.ToTable("Log_HangingAPI");
                entity.Property(e => e.running).HasColumnName("running").ValueGeneratedOnAdd();
                entity.Property(e => e.branchNo).HasColumnName("branchNo");
                entity.Property(e => e.shoppingCard).HasColumnName("shoppingCard");
                entity.Property(e => e.orderNo).HasColumnName("orderNo");
                entity.Property(e => e.subOrderType).HasColumnName("subOrderType");
                entity.Property(e => e.addDatetime).HasColumnName("addDatetime");
                entity.Property(e => e.status).HasColumnName("status");
                entity.Property(e => e.hangingNo).HasColumnName("hangingNo");
                entity.Property(e => e.recNo).HasColumnName("recno");
                entity.Property(e => e.packingNo).HasColumnName("packingNo");
            });

            modelBuilder.Entity<DfHangingapi>(entity =>
            {
                entity.HasKey(e => e.running);
                entity.ToTable("df_hangingapi");
                entity.Property(e => e.running).HasColumnName("running").ValueGeneratedOnAdd();
                entity.Property(e => e.branchNo).HasColumnName("branchNo");
                entity.Property(e => e.shoppingCard).HasColumnName("shoppingCard");
                entity.Property(e => e.orderNo).HasColumnName("orderNo");
                entity.Property(e => e.description).HasColumnName("description");
                entity.Property(e => e.addDatetime).HasColumnName("addDatetime");
                entity.Property(e => e.jsonBody).HasColumnName("jsonBody");
            });

            modelBuilder.Entity<DispatchTransPack>(entity =>
            {
                entity.HasKey(e => e.DispatchTransKey);
            });

            modelBuilder.Entity<VstTimeStock>(entity =>
            {
                entity.HasKey(e => e.running);
                entity.ToTable("vst_timestock");
                entity.Property(e => e.timeCode).HasColumnName("timecode").IsUnicode(false);
                entity.Property(e => e.timeFrom).HasColumnName("timefrom").IsUnicode(false);
                entity.Property(e => e.timeTo).HasColumnName("timeto").IsUnicode(false);
                entity.Property(e => e.datediff).HasColumnName("datediff");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.AccountTypeKey);

                entity.Property(e => e.AccountTypeKey).ValueGeneratedNever();

                entity.Property(e => e.AccountName).HasMaxLength(50);
            });

            modelBuilder.Entity<AgentConfig>(entity =>
            {
                entity.HasKey(e => e.AgentConfigKey);

                entity.Property(e => e.AccountNo)
                    .HasColumnName("account_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bank_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeReceiver).HasMaxLength(100);

                entity.Property(e => e.IsAutoPv)
                    .IsRequired()
                    .HasColumnName("IsAutoPV")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RegisterVat)
                    .HasColumnName("register_vat")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.TaxOrCardId)
                    .IsRequired()
                    .HasColumnName("TaxOrCardID")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wt).HasColumnName("WT");
            });

            modelBuilder.Entity<AgentExtend>(entity =>
            {
                entity.HasKey(e => e.AgentCode);

                entity.ToTable("Agent_Extend");

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentRef)
                    .IsRequired()
                    .HasColumnName("agent_ref")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.HasKey(e => e.AttrKey);

                entity.HasIndex(e => e.AttrPrimary)
                    .HasName("IX_Attribute");

                entity.Property(e => e.AttrPrimary)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<BankOfEdc>(entity =>
            {
                entity.HasKey(e => e.BankCode);

                entity.ToTable("BankOfEDC");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bank_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("bank_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankRetDtl>(entity =>
            {
                entity.HasKey(e => e.BankRetDtlKey);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("Add_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BankRef)
                    .IsRequired()
                    .HasColumnName("Bank_Ref")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneAccount)
                    .IsRequired()
                    .HasColumnName("Bene_Account")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBankCode)
                    .IsRequired()
                    .HasColumnName("Bene_BankCode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBankName)
                    .IsRequired()
                    .HasColumnName("Bene_BankName")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBranchCode)
                    .IsRequired()
                    .HasColumnName("Bene_BranchCode")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBranchName)
                    .IsRequired()
                    .HasColumnName("Bene_BranchName")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneName)
                    .IsRequired()
                    .HasColumnName("Bene_Name")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneTax)
                    .IsRequired()
                    .HasColumnName("Bene_Tax")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChequeNo)
                    .IsRequired()
                    .HasColumnName("Cheque_No")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustRef)
                    .IsRequired()
                    .HasColumnName("Cust_Ref")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NetPayment)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PaymentAmt)
                    .HasColumnName("Payment_amt")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PaymentCurr)
                    .IsRequired()
                    .HasColumnName("Payment_Curr")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessRemark)
                    .IsRequired()
                    .HasColumnName("Process_Remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessStatus)
                    .IsRequired()
                    .HasColumnName("Process_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhtNo)
                    .IsRequired()
                    .HasColumnName("WHT_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankRetHdr>(entity =>
            {
                entity.HasKey(e => e.BankRetHdrKey);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("Add_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BatchRef)
                    .IsRequired()
                    .HasColumnName("Batch_Ref")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChanelId)
                    .IsRequired()
                    .HasColumnName("chanel_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("company_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CreateTime)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FileRef)
                    .IsRequired()
                    .HasColumnName("File_Ref")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("payment_type")
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UploadDoc)
                    .IsRequired()
                    .HasColumnName("upload_doc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate)
                    .HasColumnName("Value_Date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");
            });

            modelBuilder.Entity<BankRetSum>(entity =>
            {
                entity.HasKey(e => e.BankRetSumKey);

                entity.Property(e => e.NoOfTrans).HasDefaultValueSql("(0)");

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPayment)
                    .HasColumnName("Total_Payment")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<CancelPriceList>(entity =>
            {
                entity.HasKey(e => new { e.ArticleCode, e.Pricelist });

                entity.Property(e => e.ArticleCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pricelist)
                    .HasColumnName("pricelist")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CashFinish>(entity =>
            {
                entity.HasKey(e => e.HeaderKey);

                entity.ToTable("Cash_Finish");

                entity.HasIndex(e => e.KeySearch)
                    .HasName("IX_Cash_Finish")
                    .IsUnique();

                entity.Property(e => e.HeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDatetime).HasColumnType("datetime");

                entity.Property(e => e.KeySearch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<Ccbank>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.BankCode });

                entity.ToTable("CCBank");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasColumnName("bank_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BankDesc)
                    .IsRequired()
                    .HasColumnName("bank_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cccurr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CurrCode });

                entity.ToTable("CCCurr");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CurrDesc)
                    .IsRequired()
                    .HasColumnName("curr_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CccurrRate>(entity =>
            {
                entity.HasKey(e => e.CccurrRateKey);

                entity.ToTable("CCCurrRate");

                entity.HasIndex(e => new { e.BranchNo, e.CurrCode, e.BankCode, e.StartDate })
                    .HasName("IX_CCCurrRate")
                    .IsUnique();

                entity.Property(e => e.CccurrRateKey).HasColumnName("CCCurrRateKey");

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankCode).HasMaxLength(50);

                entity.Property(e => e.BranchNo).HasMaxLength(50);

                entity.Property(e => e.CurrCode).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAdd).HasMaxLength(10);

                entity.Property(e => e.UserUpdate).HasMaxLength(10);
            });

            modelBuilder.Entity<CeLov>(entity =>
            {
                entity.HasKey(e => e.Lovkey);

                entity.ToTable("CE_LOV");

                entity.Property(e => e.Lovkey)
                    .HasColumnName("LOVKey")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lovcode)
                    .IsRequired()
                    .HasColumnName("LOVCode")
                    .HasMaxLength(50);

                entity.Property(e => e.LovgroupCode)
                    .IsRequired()
                    .HasColumnName("LOVGroupCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Lovvalue)
                    .IsRequired()
                    .HasColumnName("LOVValue")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderNo).HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.LovgroupCodeNavigation)
                    .WithMany(p => p.CeLov)
                    .HasForeignKey(d => d.LovgroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CE_LOV_CE_LOVGroup");
            });

            modelBuilder.Entity<CeLovgroup>(entity =>
            {
                entity.HasKey(e => e.LovgroupCode);

                entity.ToTable("CE_LOVGroup");

                entity.Property(e => e.LovgroupCode)
                    .HasColumnName("LOVGroupCode")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.LovgroupName)
                    .IsRequired()
                    .HasColumnName("LOVGroupName")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<CfgConstant>(entity =>
            {
                entity.HasKey(e => e.ConstantCode);

                entity.ToTable("CFG_Constant");

                entity.Property(e => e.ConstantCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConstantName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConstantTypeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<CfgConstantType>(entity =>
            {
                entity.HasKey(e => e.ConstantTypeCode);

                entity.ToTable("CFG_ConstantType");

                entity.Property(e => e.ConstantTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConstantTypeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<CfgMessageType>(entity =>
            {
                entity.HasKey(e => e.MessageType);

                entity.ToTable("CFG_MessageType");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageTypeName).HasMaxLength(255);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<CheckInTemp>(entity =>
            {
                entity.HasKey(e => e.ShoppingCard);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Tname)
                    .HasColumnName("tname")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CitesAirport>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CitesDetail>(entity =>
            {
                entity.HasKey(e => e.CitesDetailKey);

                entity.HasIndex(e => new { e.BookNo, e.CitesNo })
                    .HasName("IX_CitesDetail_1");

                entity.HasIndex(e => new { e.CitesHeaderKey, e.SuborderType, e.LineNo, e.PieceNo })
                    .HasName("IX_CitesDetail");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ArticleName).HasMaxLength(80);

                entity.Property(e => e.BookNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CitesName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitesNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CitesType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasColumnName("item_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasColumnName("mat_code")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PermitNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PieceNo).HasColumnName("piece_no");

                entity.Property(e => e.SellingPrice)
                    .HasColumnName("selling_price")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.SuborderType)
                    .IsRequired()
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<CitesHeader>(entity =>
            {
                entity.HasKey(e => e.CitesHeaderKey);

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate, e.CashierMac, e.TaxabbNo })
                    .HasName("IX_CitesHeader");

                entity.Property(e => e.CitesHeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CashierMac)
                    .IsRequired()
                    .HasColumnName("cashier_mac")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CitesAirport)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimcheckNo)
                    .IsRequired()
                    .HasColumnName("claimcheck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("cust_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TaxabbNo)
                    .IsRequired()
                    .HasColumnName("taxabb_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CitesName>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CommonName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.ScientificName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CitesType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmFilter>(entity =>
            {
                entity.HasKey(e => e.FilterKey);

                entity.ToTable("CM_Filter");

                entity.Property(e => e.HighDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HighDt)
                    .HasColumnName("HighDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.HighString)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LowDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LowDt)
                    .HasColumnName("LowDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LowString)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Option)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sign)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ValueType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmFilterHeader>(entity =>
            {
                entity.HasKey(e => e.FilterHeaderKey);

                entity.ToTable("CM_FilterHeader");

                entity.Property(e => e.CreatedDt)
                    .HasColumnName("CreatedDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CommissionType>(entity =>
            {
                entity.HasKey(e => e.CommissionTypeKey);

                entity.Property(e => e.CommissionTypeKey).ValueGeneratedNever();

                entity.Property(e => e.CommissionTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsPerson)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ConfigPos>(entity =>
            {
                entity.HasKey(e => e.ConfigKey);

                entity.ToTable("ConfigPOS");

                entity.HasIndex(e => e.ConfigCode)
                    .HasName("IX_ConfigPOS")
                    .IsUnique();

                entity.Property(e => e.ConfigCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigData)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<ConsSyncLog>(entity =>
            {
                entity.HasKey(e => e.SyncKey);

                entity.ToTable("CONS_SyncLog");

                entity.Property(e => e.SyncDt)
                    .HasColumnName("SyncDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<ConsTableModify>(entity =>
            {
                entity.HasKey(e => e.ModifyKey);

                entity.ToTable("CONS_TableModify");

                entity.Property(e => e.Key1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Key2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDt)
                    .HasColumnName("ModifyDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<CsoLogUp2Sap>(entity =>
            {
                entity.HasKey(e => e.SyncUp2sapId);

                entity.ToTable("CSO_LogUp2SAP");

                entity.Property(e => e.SyncUp2sapId).HasColumnName("sync_up2sap_id");

                entity.Property(e => e.FinishDt)
                    .HasColumnName("finish_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastInvoiceId).HasColumnName("last_invoice_id");

                entity.Property(e => e.StartDt)
                    .HasColumnName("start_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<CsoPossalesHeader>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("CSO_POSSalesHeader");

                entity.HasIndex(e => new { e.OrderDate, e.MachineNo, e.DocNo })
                    .HasName("IX_CSO_POSSalesHeader");

                entity.HasIndex(e => new { e.InvoiceId, e.BranchNo, e.ShoppingCard, e.OrderNo, e.MachineNo, e.DocNo })
                    .HasName("IX_CSO_POSSalesHeader_INVID");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustType)
                    .HasColumnName("cust_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SapDatetime)
                    .HasColumnName("sap_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<CsoSapIdoc>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OrderDate, e.MachineNo, e.DocNo });

                entity.ToTable("CSO_SapIdoc");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdocDatetime)
                    .HasColumnName("idoc_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SapIdocNo)
                    .HasColumnName("sap_idoc_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsoSapzposHeader>(entity =>
            {
                entity.HasKey(e => new { e.Werks, e.Budat, e.CashNo, e.InvoiceNo });

                entity.ToTable("CSO_SAPZPOS_HEADER");

                entity.Property(e => e.Werks)
                    .HasColumnName("WERKS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Budat)
                    .HasColumnName("BUDAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CashNo)
                    .HasColumnName("CASH_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bukrs)
                    .HasColumnName("BUKRS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CancelBudat)
                    .HasColumnName("CANCEL_BUDAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CancelCashNo)
                    .HasColumnName("CANCEL_CASH_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CancelInvoice)
                    .HasColumnName("CANCEL_INVOICE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cashier)
                    .HasColumnName("CASHIER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custgroup)
                    .HasColumnName("CUSTGROUP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custname)
                    .HasColumnName("CUSTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Custtype)
                    .HasColumnName("CUSTTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Flcode)
                    .HasColumnName("FLCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fldate)
                    .HasColumnName("FLDATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fltime)
                    .HasColumnName("FLTIME")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderKey).HasColumnName("HEADER_KEY");

                entity.Property(e => e.Lastyname)
                    .HasColumnName("LASTYNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Mandt)
                    .HasColumnName("MANDT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MemCardType)
                    .HasColumnName("MEM_CARD_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Member)
                    .HasColumnName("MEMBER")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MemberType)
                    .HasColumnName("MEMBER_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MileageNo)
                    .HasColumnName("MILEAGE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MileageVendor)
                    .HasColumnName("MILEAGE_VENDOR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nation)
                    .HasColumnName("NATION")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Passport)
                    .HasColumnName("PASSPORT")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .HasColumnName("PICKUP_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PosId)
                    .HasColumnName("POS_ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RcvBudat)
                    .HasColumnName("RCV_BUDAT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RcvCashNo)
                    .HasColumnName("RCV_CASH_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RcvInvoiceNo)
                    .HasColumnName("RCV_INVOICE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RcvWerks)
                    .HasColumnName("RCV_WERKS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Runno)
                    .HasColumnName("RUNNO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftNo).HasColumnName("SHIFT_NO");

                entity.Property(e => e.ShopRef)
                    .HasColumnName("SHOP_REF")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Shopcard)
                    .HasColumnName("SHOPCARD")
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("TOUR_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate)
                    .HasColumnName("TRANS_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransTime)
                    .HasColumnName("TRANS_TIME")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Vorgangart)
                    .HasColumnName("VORGANGART")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CsoTableAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("CSO_TableAttribute");

                entity.HasIndex(e => new { e.TableName, e.TableKey, e.TableKeyValue, e.AttributeName })
                    .HasName("IX_CSO_TableAttribute");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableKeyValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CutOffTime>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OrderDate, e.KeyCode, e.KeyType });

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.KeyCode)
                    .HasColumnName("key_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KeyType).HasColumnName("key_type");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CotStopSale)
                    .HasColumnName("cot_stop_sale")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.CotStopSaleMin).HasColumnName("cot_stop_sale_min");

                entity.Property(e => e.CotWarningSale)
                    .HasColumnName("cot_warning_sale")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.CotWarningSaleMin).HasColumnName("cot_warning_sale_min");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DdsBusiness>(entity =>
            {
                entity.HasKey(e => e.BusinessCode);

                entity.ToTable("DDS_Business");

                entity.Property(e => e.BusinessCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessName).HasMaxLength(50);

                entity.Property(e => e.Timestamp).IsRowVersion();
            });

            modelBuilder.Entity<DdsIdocLog>(entity =>
            {
                entity.HasKey(e => e.IdocLogKey);

                entity.ToTable("DDS_IDocLog");

                entity.Property(e => e.IdocLogKey).HasColumnName("IDocLogKey");

                entity.Property(e => e.BasicType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DocDt)
                    .HasColumnName("DocDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.IdocNo)
                    .HasColumnName("IDocNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IdocText)
                    .HasColumnName("IDocText")
                    .HasColumnType("text");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PathName).HasMaxLength(255);

                entity.Property(e => e.Timestamp).IsRowVersion();
            });

            modelBuilder.Entity<Delight2014>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.ShoppingCard })
                    .HasName("PK_Delight2014_1");

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("date");

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidDt)
                    .HasColumnName("PaidDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DfActiveVoucher>(entity =>
            {
                entity.HasKey(e => new { e.VoucherCode, e.FromNo });

                entity.ToTable("df_active_voucher");

                entity.Property(e => e.VoucherCode)
                    .HasColumnName("voucher_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromNo).HasColumnName("from_no");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasColumnName("active_flag")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DepartCode)
                    .IsRequired()
                    .HasColumnName("depart_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ToNo).HasColumnName("to_no");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfAgent>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.AgentCode });

                entity.ToTable("df_agent");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .IsRequired()
                    .HasColumnName("agent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentStatus)
                    .HasColumnName("agent_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CommPaid).HasColumnName("comm_paid");

                entity.Property(e => e.Contactname)
                    .HasColumnName("contactname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCustType)
                    .IsRequired()
                    .HasColumnName("default_cust_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DiscCommRate)
                    .HasColumnName("disc_comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NodiscCommRate)
                    .HasColumnName("nodisc_comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PerCust)
                    .HasColumnName("per_cust")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RefCode01)
                    .HasColumnName("ref_code01")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefCode02)
                    .HasColumnName("ref_code02")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TaxId)
                    .HasColumnName("tax_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfAirline>(entity =>
            {
                entity.HasKey(e => e.AirlineCode);

                entity.ToTable("df_airline");

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AirlineDesc)
                    .IsRequired()
                    .HasColumnName("airline_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfAirport>(entity =>
            {
                entity.HasKey(e => e.AirportCode);

                entity.ToTable("df_airport");

                entity.Property(e => e.AirportCode)
                    .HasColumnName("airport_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AirportDesc)
                    .IsRequired()
                    .HasColumnName("airport_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfAppvPvDtl>(entity =>
            {
                entity.HasKey(e => new { e.DocNo, e.Runno });

                entity.ToTable("df_AppvPvDtl");

                entity.HasIndex(e => e.PvHeaderKey)
                    .HasName("IX_df_AppvPvDtl");

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10);

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10);

                entity.Property(e => e.AmtBaht)
                    .HasColumnName("amt_baht")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmtCurrency)
                    .HasColumnName("amt_currency")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Chequereceiver)
                    .IsRequired()
                    .HasColumnName("chequereceiver")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Issuedt)
                    .HasColumnName("issuedt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PvHeaderKey).HasColumnName("pvHeaderKey");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<DfAppvPvHdr>(entity =>
            {
                entity.HasKey(e => e.DocNo);

                entity.ToTable("df_AppvPvHdr");

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AmountBaht)
                    .HasColumnName("amount_baht")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Attn)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChairmanSign).HasColumnName("chairman_sign");

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10);

                entity.Property(e => e.VpSign)
                    .IsRequired()
                    .HasColumnName("vp_sign")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DfArea>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.AreaCode });

                entity.ToTable("df_area");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .HasColumnName("area_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("area_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dchannel)
                    .IsRequired()
                    .HasColumnName("DChannel")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatCode)
                    .IsRequired()
                    .HasColumnName("vat_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfAuth>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ModuleCode, e.AuthCode, e.UserCode });

                entity.ToTable("df_auth");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasColumnName("auth_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActCode)
                    .IsRequired()
                    .HasColumnName("act_code")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfAuthGrp>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.GrpCode, e.ModuleCode, e.AuthCode });

                entity.ToTable("df_auth_grp");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GrpCode)
                    .HasColumnName("grp_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasColumnName("auth_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActId)
                    .IsRequired()
                    .HasColumnName("act_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfBank>(entity =>
            {
                entity.HasKey(e => e.BankCode);

                entity.ToTable("df_bank");

                entity.Property(e => e.BankCode)
                    .HasColumnName("bank_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("bank_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnName("branch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnName("short_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfBox>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OpaqNo });

                entity.ToTable("df_box");

                entity.HasIndex(e => new { e.BranchNo, e.BoxDate })
                    .HasName("IX_df_box_date");

                entity.HasIndex(e => new { e.BranchNo, e.BoxNo })
                    .HasName("IX_df_box");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OpaqNo)
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BoxDate)
                    .HasColumnName("box_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.BoxDatetime)
                    .HasColumnName("box_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BoxNo)
                    .IsRequired()
                    .HasColumnName("box_no")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoxStaffCode)
                    .IsRequired()
                    .HasColumnName("box_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HangingNo)
                    .IsRequired()
                    .HasColumnName("hanging_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickupDate)
                    .HasColumnName("pickup_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PickupDatetime)
                    .HasColumnName("pickup_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PickupStaffCode)
                    .IsRequired()
                    .HasColumnName("pickup_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<DfBoxCancel>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OpaqNo, e.BoxNo });

                entity.ToTable("df_box_cancel");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OpaqNo)
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BoxNo)
                    .HasColumnName("box_no")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoxDate)
                    .HasColumnName("box_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BoxDatetime)
                    .HasColumnName("box_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BoxStaffCode)
                    .IsRequired()
                    .HasColumnName("box_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CancelDatetime)
                    .HasColumnName("cancel_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CancelStaffCode)
                    .IsRequired()
                    .HasColumnName("cancel_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<DfBranch>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("df_branch");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasColumnName("address3")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AutoRcvtbag).HasColumnName("AutoRCVTbag");

                entity.Property(e => e.AutoTake)
                    .IsRequired()
                    .HasColumnName("auto_take")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BranchLv)
                    .IsRequired()
                    .HasColumnName("BranchLV")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BroadcastPort)
                    .HasColumnName("broadcast_port")
                    .HasDefaultValueSql("((11000))");

                entity.Property(e => e.BuyLimit)
                    .HasColumnName("buy_limit")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BuyLimitHour).HasColumnName("buy_limit_hour");

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.CheckStkOnline).HasColumnName("check_stk_online");

                entity.Property(e => e.CotStopSale)
                    .HasColumnName("cot_stop_sale")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.CotStopSaleMin).HasColumnName("cot_stop_sale_min");

                entity.Property(e => e.CotWarningSale)
                    .HasColumnName("cot_warning_sale")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.CotWarningSaleMin).HasColumnName("cot_warning_sale_min");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrentOrderDate)
                    .HasColumnName("current_order_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.CustTypeBirthday)
                    .IsRequired()
                    .HasColumnName("cust_type_birthday")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CutOffTime).HasColumnName("cut_off_time");

                entity.Property(e => e.Dchannel)
                    .IsRequired()
                    .HasColumnName("DChannel")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefaultCustFit)
                    .IsRequired()
                    .HasColumnName("default_cust_fit")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCustTour)
                    .IsRequired()
                    .HasColumnName("default_cust_tour")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.ExceptBar1stDigit)
                    .IsRequired()
                    .HasColumnName("except_bar_1st_digit")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasColumnName("fax_no")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HotelSourceType)
                    .IsRequired()
                    .HasColumnName("hotel_source_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MagnaticChar)
                    .IsRequired()
                    .HasColumnName("magnatic_char")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MaxFlightTime).HasColumnName("max_flight_time");

                entity.Property(e => e.MaxOpenPrice)
                    .HasColumnName("max_open_price")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((100000))");

                entity.Property(e => e.MaxPerTbag).HasColumnName("max_per_tbag");

                entity.Property(e => e.MaxTbagToBack)
                    .HasColumnName("max_tbag_to_back")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinTruckLimit).HasColumnName("min_truck_limit");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpaqPerBox).HasColumnName("opaq_per_box");

                entity.Property(e => e.Plant)
                    .IsRequired()
                    .HasColumnName("plant")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrefixInv)
                    .IsRequired()
                    .HasColumnName("prefix_inv")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecTbagExtDay).HasColumnName("rec_tbag_ext_day");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.Sapchannel)
                    .IsRequired()
                    .HasColumnName("SAPChannel")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Saporg)
                    .IsRequired()
                    .HasColumnName("SAPOrg")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SmcbahtPerPoint)
                    .HasColumnName("SMCBahtPerPoint")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SmcpointPerBaht)
                    .HasColumnName("SMCPointPerBaht")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlFetch)
                    .HasColumnName("sql_fetch")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.StartFrn)
                    .HasColumnName("StartFRN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StopSale).HasColumnName("stop_sale");

                entity.Property(e => e.TakeWarningTimeMin)
                    .HasColumnName("take_warning_time_min")
                    .HasDefaultValueSql("((30))");

                entity.Property(e => e.TaxNo)
                    .IsRequired()
                    .HasColumnName("tax_no")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .IsRequired()
                    .HasColumnName("tel_no")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UrlStockService)
                    .IsRequired()
                    .HasColumnName("url_stock_service")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatCode)
                    .IsRequired()
                    .HasColumnName("vat_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCardType>(entity =>
            {
                entity.HasKey(e => e.CardTypeId);

                entity.ToTable("df_card_type");

                entity.Property(e => e.CardTypeId)
                    .HasColumnName("card_type_id")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CardGroupId)
                    .IsRequired()
                    .HasColumnName("card_group_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .IsRequired()
                    .HasColumnName("card_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemCondition)
                    .HasColumnName("mem_condition")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MemType).HasColumnName("mem_type");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfChange>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo });

                entity.ToTable("df_change");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount1)
                    .HasColumnName("amount1")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Amount2)
                    .HasColumnName("amount2")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountCurr)
                    .HasColumnName("amount_curr")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CurrCode1)
                    .IsRequired()
                    .HasColumnName("curr_code1")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrCode2)
                    .IsRequired()
                    .HasColumnName("curr_code2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCity>(entity =>
            {
                entity.HasKey(e => e.CityCode);

                entity.ToTable("df_city");

                entity.Property(e => e.CityCode)
                    .HasColumnName("city_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("city_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasColumnName("province_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCommDoc>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo });

                entity.ToTable("df_comm_doc");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode })
                    .HasName("IX_df_comm_doc");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CancelDatetime)
                    .HasColumnName("cancel_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelToDoc)
                    .IsRequired()
                    .HasColumnName("cancel_to_doc")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommRate)
                    .HasColumnName("comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DataDatetime)
                    .HasColumnName("data_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Net)
                    .HasColumnName("net")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pax)
                    .HasColumnName("pax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PerHead)
                    .HasColumnName("per_head")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TourDate)
                    .HasColumnName("tour_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.TourTime)
                    .IsRequired()
                    .HasColumnName("tour_time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCancel)
                    .IsRequired()
                    .HasColumnName("user_cancel")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Visitor)
                    .HasColumnName("visitor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.WhtAmount)
                    .HasColumnName("wht_amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate)
                    .HasColumnName("wht_rate")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DfCommDtl>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo, e.LineNo });

                entity.ToTable("df_comm_dtl");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasColumnName("brand_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .IsRequired()
                    .HasColumnName("cate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CommRate)
                    .HasColumnName("comm_rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Net)
                    .HasColumnName("net")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DfCommRate>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.AgentCode });

                entity.ToTable("df_comm_rate");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CommRate)
                    .HasColumnName("comm_rate")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfComputer>(entity =>
            {
                entity.HasKey(e => e.IpAddress);

                entity.ToTable("df_computer");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ComDesc)
                    .IsRequired()
                    .HasColumnName("com_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionKey).HasColumnName("connection_key");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.NotifyMinute)
                    .HasColumnName("notify_minute")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrintBarcode)
                    .HasColumnName("print_barcode")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.SendDataAot).HasColumnName("SendDataAOT");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfConnection>(entity =>
            {
                entity.HasKey(e => e.CnCode);

                entity.ToTable("df_connection");

                entity.Property(e => e.CnCode)
                    .HasColumnName("cn_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CnBranchNo)
                    .IsRequired()
                    .HasColumnName("cn_branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CnDatabase)
                    .IsRequired()
                    .HasColumnName("cn_database")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CnName)
                    .IsRequired()
                    .HasColumnName("cn_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnPwd)
                    .IsRequired()
                    .HasColumnName("cn_pwd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CnServer)
                    .IsRequired()
                    .HasColumnName("cn_server")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CnUid)
                    .IsRequired()
                    .HasColumnName("cn_uid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");
            });

            modelBuilder.Entity<DfConsolVer>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TbagNo, e.LineNo });

                entity.ToTable("df_consol_ver");

                entity.HasIndex(e => new { e.BranchNo, e.SubSoHdrRecNo })
                    .HasName("IX_df_consol_ver");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TbagNo)
                    .HasColumnName("tbag_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasColumnName("mat_code")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Recieve).HasColumnName("recieve");

                entity.Property(e => e.SellingPrice)
                    .HasColumnName("selling_price")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfCountry>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("df_country");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCreditCard>(entity =>
            {
                entity.HasKey(e => e.CardPrefix);

                entity.ToTable("df_credit_card");

                entity.Property(e => e.CardPrefix)
                    .HasColumnName("card_prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CardLength).HasColumnName("card_length");

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasColumnName("card_name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardPrefix2)
                    .IsRequired()
                    .HasColumnName("card_prefix2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDigit).HasColumnName("check_digit");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCurrency>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CurrCode });

                entity.ToTable("df_currency");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CurrDesc)
                    .HasColumnName("curr_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrHot)
                    .IsRequired()
                    .HasColumnName("curr_hot")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CurrRate)
                    .HasColumnName("curr_rate")
                    .HasColumnType("decimal(9, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CurrShort)
                    .IsRequired()
                    .HasColumnName("curr_short")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCustType>(entity =>
            {
                entity.HasKey(e => e.CustTypeCode);

                entity.ToTable("df_cust_type");

                entity.Property(e => e.CustTypeCode)
                    .HasColumnName("cust_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AllowStatusC)
                    .IsRequired()
                    .HasColumnName("allow_status_c")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AllowStatusT)
                    .IsRequired()
                    .HasColumnName("allow_status_t")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AllowStatusV)
                    .IsRequired()
                    .HasColumnName("allow_status_v")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CustDiscRate)
                    .HasColumnName("cust_disc_rate")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CustTypeDesc)
                    .IsRequired()
                    .HasColumnName("cust_type_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UniquePassport)
                    .IsRequired()
                    .HasColumnName("unique_passport")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfCustomer>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard });

                entity.ToTable("df_customer");

                entity.HasIndex(e => new { e.BranchNo, e.PassportNo })
                    .HasName("IX_df_customer_passport");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode })
                    .HasName("IX_df_customer");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.CustName })
                    .HasName("IX_df_customer_1");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.PassportNo })
                    .HasName("df_customer3");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("cust_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustTypeCode)
                    .IsRequired()
                    .HasColumnName("cust_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FastRegister)
                    .IsRequired()
                    .HasColumnName("fast_register")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlightTime)
                    .IsRequired()
                    .HasColumnName("flight_time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HotelCode)
                    .IsRequired()
                    .HasColumnName("hotel_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HotelSource)
                    .IsRequired()
                    .HasColumnName("hotel_source")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mob)
                    .HasColumnName("mob")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TourRunno)
                    .HasColumnName("tour_runno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Yob)
                    .HasColumnName("yob")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DfCustomerAttr>(entity =>
            {
                entity.HasKey(e => e.CustAttId);

                entity.ToTable("df_customer_attr");

                entity.HasIndex(e => new { e.BranchNo, e.Attribute })
                    .HasName("IX_df_customer_attr_1");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard })
                    .HasName("IX_df_customer_attr");

                entity.Property(e => e.CustAttId).HasColumnName("CustAttID");

                entity.Property(e => e.Attribute)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValueString).HasMaxLength(400);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfDiscount>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.PluLineNo, e.DiscLineNo })
                    .HasName("PK_df_pdiscount");

                entity.ToTable("df_discount");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.PluLineNo).HasColumnName("plu_line_no");

                entity.Property(e => e.DiscLineNo).HasColumnName("disc_line_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BlockAmount)
                    .HasColumnName("blockAmount")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BybillFlag).HasColumnName("bybill_flag");

                entity.Property(e => e.BybillRunno).HasColumnName("bybill_runno");

                entity.Property(e => e.CancelStatus).HasColumnName("cancel_status");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DiscAmount)
                    .HasColumnName("disc_amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.DiscPer)
                    .HasColumnName("disc_per")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.DiscRate)
                    .HasColumnName("disc_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DiscType).HasColumnName("disc_type");

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasColumnName("promo_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

                entity.Property(e => e.Subsidize)
                    .HasColumnName("subsidize")
                    .HasColumnType("decimal(14, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfErrorLog>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ModuleCode, e.ErrDate, e.ErrTime });

                entity.ToTable("df_error_log");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErrDate)
                    .HasColumnName("err_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ErrTime)
                    .HasColumnName("err_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Db)
                    .IsRequired()
                    .HasColumnName("db")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ErrMessage)
                    .HasColumnName("err_message")
                    .HasColumnType("text");

                entity.Property(e => e.ErrSource)
                    .HasColumnName("err_source")
                    .HasColumnType("text");

                entity.Property(e => e.ErrSql)
                    .HasColumnName("err_sql")
                    .HasColumnType("text");

                entity.Property(e => e.ErrStacktrace)
                    .HasColumnName("err_stacktrace")
                    .HasColumnType("text");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasColumnName("server")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfFlight>(entity =>
            {
                entity.HasKey(e => new { e.AirlineCode, e.FlightCode });

                entity.ToTable("df_flight");

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ArrdepAirportCode)
                    .IsRequired()
                    .HasColumnName("arrdep_airport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrdepTerminal)
                    .IsRequired()
                    .HasColumnName("arrdep_terminal")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ArrdepTime)
                    .IsRequired()
                    .HasColumnName("arrdep_time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CharterFlight)
                    .IsRequired()
                    .HasColumnName("charter_flight")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D1)
                    .IsRequired()
                    .HasColumnName("d1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.D2)
                    .IsRequired()
                    .HasColumnName("d2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.D3)
                    .IsRequired()
                    .HasColumnName("d3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.D4)
                    .IsRequired()
                    .HasColumnName("d4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.D5)
                    .IsRequired()
                    .HasColumnName("d5")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.D6)
                    .IsRequired()
                    .HasColumnName("d6")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.D7)
                    .IsRequired()
                    .HasColumnName("d7")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DestAirportCode)
                    .IsRequired()
                    .HasColumnName("dest_airport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDesc)
                    .IsRequired()
                    .HasColumnName("flight_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnlyLocal)
                    .IsRequired()
                    .HasColumnName("only_local")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OpenFlight).HasColumnName("open_flight");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfGroup>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.GrpCode });

                entity.ToTable("df_group");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GrpCode)
                    .HasColumnName("grp_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.GrpName)
                    .IsRequired()
                    .HasColumnName("grp_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfGuideGroup>(entity =>
            {
                entity.HasKey(e => e.GuideGroupCode)
                    .HasName("PK_df_guide_group_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("df_guide_group");

                entity.HasIndex(e => e.GuideGroupCode)
                    .HasName("PK_df_guide_group")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.GuideGroupCode)
                    .HasColumnName("guide_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfHanging>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.PickupCode, e.HangingNo });

                entity.ToTable("df_hanging");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HangingNo).HasColumnName("hanging_no");

                entity.Property(e => e.InTransit)
                    .HasColumnName("in_transit")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OpaqNo)
                    .IsRequired()
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfHotel>(entity =>
            {
                entity.HasKey(e => e.HotelCode);

                entity.ToTable("df_hotel");

                entity.Property(e => e.HotelCode)
                    .HasColumnName("hotel_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.HotelAdd1)
                    .IsRequired()
                    .HasColumnName("hotel_add1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelAdd2)
                    .IsRequired()
                    .HasColumnName("hotel_add2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelAdd3)
                    .IsRequired()
                    .HasColumnName("hotel_add3")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelComm)
                    .HasColumnName("hotel_comm")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.HotelEmail)
                    .IsRequired()
                    .HasColumnName("hotel_email")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelFax)
                    .IsRequired()
                    .HasColumnName("hotel_fax")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasColumnName("hotel_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelTel)
                    .IsRequired()
                    .HasColumnName("hotel_tel")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelWww)
                    .IsRequired()
                    .HasColumnName("hotel_www")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.HotelZip)
                    .IsRequired()
                    .HasColumnName("hotel_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnName("source_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfInshopHdr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo })
                    .HasName("PK_df_inshop_doc_hdr");

                entity.ToTable("df_inshop_hdr");

                entity.HasIndex(e => new { e.BranchNo, e.DocDate })
                    .HasName("IX_df_inshop_hdr");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchGetComm)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CancelDatetime)
                    .HasColumnName("cancel_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CancelToDoc)
                    .IsRequired()
                    .HasColumnName("cancel_to_doc")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CarLicence)
                    .IsRequired()
                    .HasColumnName("car_licence")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocDate)
                    .HasColumnName("doc_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasColumnName("doc_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeeType)
                    .IsRequired()
                    .HasColumnName("fee_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaidDatetime)
                    .HasColumnName("paid_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Pax)
                    .HasColumnName("pax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubagentCode)
                    .IsRequired()
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TransportCode)
                    .HasColumnName("transport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCancel)
                    .IsRequired()
                    .HasColumnName("user_cancel")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserPaid)
                    .IsRequired()
                    .HasColumnName("user_paid")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfInshopRate>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.InshopType, e.AgentCode, e.CountryCode, e.InshopTypeCode, e.PaxMin });

                entity.ToTable("df_inshop_rate");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InshopType)
                    .HasColumnName("inshop_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InshopTypeCode)
                    .HasColumnName("inshop_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaxMin).HasColumnName("pax_min");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PaxMax)
                    .HasColumnName("pax_max")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfInshopSubtrans>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo, e.LineNo });

                entity.ToTable("df_inshop_subtrans");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode })
                    .HasName("IX_df_inshop_subtrans");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CancelFlag)
                    .IsRequired()
                    .HasColumnName("cancel_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlightTime)
                    .IsRequired()
                    .HasColumnName("flight_time")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pax)
                    .HasColumnName("pax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TourDate)
                    .HasColumnName("tour_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TourTime)
                    .IsRequired()
                    .HasColumnName("tour_time")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfInshopTrans>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo, e.CountryCode });

                entity.ToTable("df_inshop_trans");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DriverPark)
                    .HasColumnName("driver_park")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GuideHead)
                    .HasColumnName("guide_head")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GuidePark)
                    .HasColumnName("guide_park")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pax)
                    .HasColumnName("pax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DfInshopType>(entity =>
            {
                entity.HasKey(e => e.InshopTypeCode);

                entity.ToTable("df_inshop_type");

                entity.Property(e => e.InshopTypeCode)
                    .HasColumnName("inshop_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.InshopTypeName)
                    .IsRequired()
                    .HasColumnName("inshop_type_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfInv>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OrderDate, e.ClaimcheckNo, e.MachineNo });

                entity.ToTable("df_inv");

                entity.HasIndex(e => e.TelephoneNo)
                    .HasName("IX_telephone_no");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ClaimcheckNo)
                    .HasColumnName("claimcheck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Add1)
                    .IsRequired()
                    .HasColumnName("add1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Add2)
                    .IsRequired()
                    .HasColumnName("add2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Add3)
                    .IsRequired()
                    .HasColumnName("add3")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("cust_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.InvNo)
                    .IsRequired()
                    .HasColumnName("inv_no")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxNo)
                    .HasColumnName("tax_no")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TaxabbNo)
                    .IsRequired()
                    .HasColumnName("taxabb_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelephoneNo)
                    .IsRequired()
                    .HasColumnName("telephone_no")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VatAmt)
                    .HasColumnName("vat_amt")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DfIssuedType>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.IssuedType });

                entity.ToTable("df_issued_type");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedType)
                    .HasColumnName("issued_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedTypeName)
                    .IsRequired()
                    .HasColumnName("issued_type_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfLocation>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.LocCode });

                entity.ToTable("df_location");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocCode)
                    .HasColumnName("loc_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasColumnName("area_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrdepTerminal)
                    .HasColumnName("arrdep_terminal")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dchannel)
                    .IsRequired()
                    .HasColumnName("DChannel")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocName)
                    .IsRequired()
                    .HasColumnName("loc_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VatCode)
                    .IsRequired()
                    .HasColumnName("vat_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfLockShopCard>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.ModuleCode, e.AuthCode });

                entity.ToTable("df_lock_shop_card");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasColumnName("auth_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComName)
                    .IsRequired()
                    .HasColumnName("com_name")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LockDatetime)
                    .HasColumnName("lock_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.LockIp)
                    .IsRequired()
                    .HasColumnName("lock_ip")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfMachine>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.MachineNo });

                entity.ToTable("df_machine");

                entity.HasIndex(e => new { e.BranchNo, e.MachineIp })
                    .HasName("IX_df_machine");

                entity.HasIndex(e => new { e.MachineTax, e.LocCode })
                    .HasName("IX_df_machine_1");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AllowRcv).HasColumnName("allow_rcv");

                entity.Property(e => e.ArrdepTerminal)
                    .HasColumnName("arrdep_terminal")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AutoRegister).HasColumnName("auto_register");

                entity.Property(e => e.AutoTake)
                    .IsRequired()
                    .HasColumnName("auto_take")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.ConsolFlag).HasColumnName("consol_flag");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.D3).HasColumnName("d3");

                entity.Property(e => e.D4).HasColumnName("d4");

                entity.Property(e => e.D5).HasColumnName("d5");

                entity.Property(e => e.D6).HasColumnName("d6");

                entity.Property(e => e.D7).HasColumnName("d7");

                entity.Property(e => e.DateRemove).HasColumnName("date_remove");

                entity.Property(e => e.Dchannel)
                    .IsRequired()
                    .HasColumnName("DChannel")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.ECommerceDelivery).HasColumnName("eCommerceDelivery");

                entity.Property(e => e.ECommerceFlag).HasColumnName("eCommerceFlag");

                entity.Property(e => e.IsSelfCheckout)
                    .HasColumnName("is_self_checkout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocCode)
                    .IsRequired()
                    .HasColumnName("loc_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MacStatus)
                    .IsRequired()
                    .HasColumnName("mac_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineIp)
                    .IsRequired()
                    .HasColumnName("machine_ip")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasColumnName("machine_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MachineTax)
                    .IsRequired()
                    .HasColumnName("machine_tax")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaxShift).HasColumnName("max_shift");

                entity.Property(e => e.NaChangeQty).HasColumnName("na_change_qty");

                entity.Property(e => e.NaDelete).HasColumnName("na_delete");

                entity.Property(e => e.NaEsc).HasColumnName("na_esc");

                entity.Property(e => e.OdbcCenter)
                    .IsRequired()
                    .HasColumnName("odbc_center")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformId)
                    .IsRequired()
                    .HasColumnName("PlatformID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PosType)
                    .HasColumnName("pos_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Preorder).HasColumnName("preorder");

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrintBarcode).HasColumnName("print_barcode");

                entity.Property(e => e.PrintInvoice).HasColumnName("print_invoice");

                entity.Property(e => e.PrintSlip).HasColumnName("print_slip");

                entity.Property(e => e.PrintTbag)
                    .IsRequired()
                    .HasColumnName("PrintTBag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RefundMachine).HasColumnName("refund_machine");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.SwitchLoc)
                    .IsRequired()
                    .HasColumnName("switch_loc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TbagMachine).HasColumnName("tbag_machine");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatCode)
                    .IsRequired()
                    .HasColumnName("vat_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatRate)
                    .HasColumnName("vat_rate")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.VatrefundMachineNo)
                    .HasColumnName("vatrefund_machine_no")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DfMagnetic>(entity =>
            {
                entity.HasKey(e => e.MagCode);

                entity.ToTable("df_magnetic");

                entity.Property(e => e.MagCode)
                    .HasColumnName("mag_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.MagLenght).HasColumnName("mag_lenght");

                entity.Property(e => e.MagStart).HasColumnName("mag_start");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfMagneticLog>(entity =>
            {
                entity.HasKey(e => new { e.ShoppingCard, e.OrderNo, e.MachineNo });

                entity.ToTable("df_magnetic_log");

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnName("error_message")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MagneticText)
                    .IsRequired()
                    .HasColumnName("magnetic_text")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<DfMastJob>(entity =>
            {
                entity.HasKey(e => e.JobName);

                entity.ToTable("df_mast_job");

                entity.Property(e => e.JobName)
                    .HasColumnName("job_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BlnBrand)
                    .IsRequired()
                    .HasColumnName("blnBrand")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BlnCate)
                    .IsRequired()
                    .HasColumnName("blnCate")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BlnMat)
                    .IsRequired()
                    .HasColumnName("blnMat")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasColumnName("channel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datadate)
                    .HasColumnName("datadate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.JobDesc)
                    .IsRequired()
                    .HasColumnName("job_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Org)
                    .IsRequired()
                    .HasColumnName("org")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDatetime)
                    .HasColumnName("start_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasColumnName("user_create")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Wheremat)
                    .IsRequired()
                    .HasColumnName("wheremat")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfMemNotify>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DataDate, e.DataTime, e.MemberId });

                entity.ToTable("df_mem_notify");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.DataTime)
                    .HasColumnName("data_time")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfMemberCheckin>(entity =>
            {
                entity.HasKey(e => new { e.ShoppingCard, e.RegistDate });

                entity.ToTable("df_member_checkin");

                entity.HasIndex(e => e.RegistDate);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistDate)
                    .HasColumnName("regist_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Follower).HasColumnName("follower");

                entity.Property(e => e.Gift).HasColumnName("gift");

                entity.Property(e => e.RegistDatetime)
                    .HasColumnName("regist_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfMemberGuest>(entity =>
            {
                entity.HasKey(e => e.ShoppingCard);

                entity.ToTable("df_member_guest");

                entity.HasIndex(e => e.RefNo)
                    .HasName("IX_df_member_guest");

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.GroupType)
                    .HasColumnName("group_type")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.Tname)
                    .HasColumnName("tname")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('K')");

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('K')");
            });

            modelBuilder.Entity<DfMemberLog>(entity =>
            {
                entity.HasKey(e => e.Logno);

                entity.ToTable("df_member_log");

                entity.Property(e => e.Logno)
                    .HasColumnName("logno")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ApplyDate)
                    .HasColumnName("apply_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BussinessId)
                    .IsRequired()
                    .HasColumnName("bussiness_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrBldg)
                    .IsRequired()
                    .HasColumnName("caddr_bldg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrCity)
                    .IsRequired()
                    .HasColumnName("caddr_city")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrDept)
                    .IsRequired()
                    .HasColumnName("caddr_dept")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrDistrict)
                    .IsRequired()
                    .HasColumnName("caddr_district")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrFax)
                    .IsRequired()
                    .HasColumnName("caddr_fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrFloor)
                    .IsRequired()
                    .HasColumnName("caddr_floor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrNumber)
                    .IsRequired()
                    .HasColumnName("caddr_number")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrRoad)
                    .IsRequired()
                    .HasColumnName("caddr_road")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrSoi)
                    .IsRequired()
                    .HasColumnName("caddr_soi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrSubdistrict)
                    .IsRequired()
                    .HasColumnName("caddr_subdistrict")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrTel)
                    .IsRequired()
                    .HasColumnName("caddr_tel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrTelext)
                    .IsRequired()
                    .HasColumnName("caddr_telext")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CaddrZipCode)
                    .IsRequired()
                    .HasColumnName("caddr_zip_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeId)
                    .HasColumnName("card_type_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("company_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CondfId)
                    .IsRequired()
                    .HasColumnName("condf_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditKpg)
                    .IsRequired()
                    .HasColumnName("credit_kpg")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasColumnName("discount")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmbossId)
                    .IsRequired()
                    .HasColumnName("emboss_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EmbossName)
                    .IsRequired()
                    .HasColumnName("emboss_name")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasColumnName("ename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FlagNoSms).HasColumnName("FlagNoSMS");

                entity.Property(e => e.HaddrBldg)
                    .IsRequired()
                    .HasColumnName("haddr_bldg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrCity)
                    .IsRequired()
                    .HasColumnName("haddr_city")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrDistrict)
                    .IsRequired()
                    .HasColumnName("haddr_district")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrFax)
                    .IsRequired()
                    .HasColumnName("haddr_fax")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrMoo)
                    .IsRequired()
                    .HasColumnName("haddr_moo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrNumber)
                    .IsRequired()
                    .HasColumnName("haddr_number")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrPct)
                    .IsRequired()
                    .HasColumnName("haddr_pct")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrPctExt)
                    .IsRequired()
                    .HasColumnName("haddr_pct_ext")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrRoad)
                    .IsRequired()
                    .HasColumnName("haddr_road")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrSoi)
                    .IsRequired()
                    .HasColumnName("haddr_soi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrSubdistrict)
                    .IsRequired()
                    .HasColumnName("haddr_subdistrict")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrTel1)
                    .IsRequired()
                    .HasColumnName("haddr_tel1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrTel1Ext)
                    .IsRequired()
                    .HasColumnName("haddr_tel1_ext")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrTel2)
                    .IsRequired()
                    .HasColumnName("haddr_tel2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrTel2Ext)
                    .IsRequired()
                    .HasColumnName("haddr_tel2_ext")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HaddrZipCode)
                    .IsRequired()
                    .HasColumnName("haddr_zip_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard)
                    .IsRequired()
                    .HasColumnName("id_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.MaillingAddr).HasColumnName("mailling_addr");

                entity.Property(e => e.MainId)
                    .IsRequired()
                    .HasColumnName("main_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MemGroupId)
                    .IsRequired()
                    .HasColumnName("mem_group_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MemberRef)
                    .IsRequired()
                    .HasColumnName("member_ref")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile1)
                    .IsRequired()
                    .HasColumnName("mobile1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile2)
                    .IsRequired()
                    .HasColumnName("mobile2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramId)
                    .IsRequired()
                    .HasColumnName("program_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RefproId)
                    .IsRequired()
                    .HasColumnName("refpro_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.RenewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReprintEmboss).HasColumnName("reprint_emboss");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.StaffSource)
                    .HasColumnName("staff_source")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StepNo).HasColumnName("step_no");

                entity.Property(e => e.SubprogramId)
                    .HasColumnName("subprogram_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SupVerified).HasColumnName("sup_verified");

                entity.Property(e => e.TempCard)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TitleId)
                    .IsRequired()
                    .HasColumnName("title_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasColumnName("tname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WPosition)
                    .IsRequired()
                    .HasColumnName("w_position")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfMemhist>(entity =>
            {
                entity.HasKey(e => new { e.MemberId, e.ShoppingCard });

                entity.ToTable("df_memhist");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CardStatus).HasColumnName("card_status");

                entity.Property(e => e.DateOfApply)
                    .HasColumnName("date_of_apply")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTerm).HasColumnName("valid_term");
            });

            modelBuilder.Entity<DfMileage>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DataDate, e.MachineNo, e.DocNo });

                entity.ToTable("df_mileage");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("card_no")
                    .HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Plant)
                    .IsRequired()
                    .HasColumnName("plant")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasColumnName("vendor")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfMileageVendor>(entity =>
            {
                entity.HasKey(e => e.VendorCode);

                entity.ToTable("df_mileage_vendor");

                entity.Property(e => e.VendorCode)
                    .HasColumnName("vendor_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasColumnName("vendor_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfMultiSave>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ModuleCode, e.ScreenBase, e.CnCode });

                entity.ToTable("df_multi_save");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenBase)
                    .HasColumnName("screen_base")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CnCode)
                    .HasColumnName("cn_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");
            });

            modelBuilder.Entity<DfMultiSaveError>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ModuleCode, e.ScreenBase, e.CnCode, e.Runno });

                entity.ToTable("df_multi_save_error");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenBase)
                    .HasColumnName("screen_base")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CnCode)
                    .HasColumnName("cn_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Runno)
                    .HasColumnName("runno")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SqlCommand)
                    .IsRequired()
                    .HasColumnName("sql_command")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.SqlDelete)
                    .IsRequired()
                    .HasColumnName("sql_delete")
                    .HasColumnType("text")
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SqlError)
                    .IsRequired()
                    .HasColumnName("sql_error")
                    .HasColumnType("text")
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SqlInsert)
                    .IsRequired()
                    .HasColumnName("sql_insert")
                    .HasColumnType("text")
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SqlSelect)
                    .IsRequired()
                    .HasColumnName("sql_select")
                    .HasColumnType("text")
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SqlUpdate)
                    .IsRequired()
                    .HasColumnName("sql_update")
                    .HasColumnType("text")
                    .HasDefaultValueSql("create default [blank] as ' '");
            });

            modelBuilder.Entity<DfOpaq>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TbagNo });

                entity.ToTable("df_opaq");

                entity.HasIndex(e => new { e.BranchNo, e.OpaqNo })
                    .HasName("IX_df_opaq");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TbagNo)
                    .HasColumnName("tbag_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BoxDatetime)
                    .HasColumnName("box_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BoxNo)
                    .IsRequired()
                    .HasColumnName("box_no")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoxStaffCode)
                    .IsRequired()
                    .HasColumnName("box_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpaqDate)
                    .HasColumnName("opaq_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.OpaqDatetime)
                    .HasColumnName("opaq_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.OpaqNo)
                    .IsRequired()
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpaqStaffCode)
                    .IsRequired()
                    .HasColumnName("opaq_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickDatetime)
                    .HasColumnName("pick_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PickStaffCode)
                    .IsRequired()
                    .HasColumnName("pick_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<DfOpaqTrans>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo, e.LineNo })
                    .HasName("PK_df_oqaq_trans");

                entity.ToTable("df_opaq_trans");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.DocComplete)
                    .IsRequired()
                    .HasColumnName("doc_complete")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FromDatetime)
                    .HasColumnName("from_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromHanging).HasColumnName("from_hanging");

                entity.Property(e => e.FromPu)
                    .HasColumnName("from_pu")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromStaff)
                    .HasColumnName("from_staff")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpaqNo)
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToDatetime)
                    .HasColumnName("to_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToHanging).HasColumnName("to_hanging");

                entity.Property(e => e.ToPu)
                    .HasColumnName("to_pu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToStaff)
                    .HasColumnName("to_staff")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfOperGrp>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OperGrp });

                entity.ToTable("df_oper_grp");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OperGrp)
                    .HasColumnName("oper_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.OperDesc)
                    .IsRequired()
                    .HasColumnName("oper_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfPayment>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.LineNo });

                entity.ToTable("df_payment");

                entity.HasIndex(e => e.CashierCode);

                entity.HasIndex(e => e.Posid);

                entity.HasIndex(e => new { e.BranchNo, e.CashierCode, e.PaymentDate })
                    .HasName("IX_df_payment");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AliBarcode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AliMerchantId)
                    .HasColumnName("AliMerchantID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AliTransId)
                    .HasColumnName("AliTransID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlipayCancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AmountCurr)
                    .HasColumnName("amount_curr")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AmountRound)
                    .HasColumnName("amount_round")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ApproveCode)
                    .IsRequired()
                    .HasColumnName("approve_code")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankOfEdc)
                    .HasColumnName("BankOfEDC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CashierCode)
                    .IsRequired()
                    .HasColumnName("cashier_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CredCardName)
                    .IsRequired()
                    .HasColumnName("cred_card_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CredCardNo)
                    .IsRequired()
                    .HasColumnName("cred_card_no")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrRate)
                    .HasColumnName("curr_rate")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("expiry_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Posid)
                    .IsRequired()
                    .HasColumnName("posid")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfPaymeth>(entity =>
            {
                entity.HasKey(e => e.MethodCode);

                entity.ToTable("df_paymeth");

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BarcodeFix).HasColumnName("barcode_fix");

                entity.Property(e => e.CheckVoucher).HasColumnName("check_voucher");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('2078/12/31')");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.InputApprove).HasColumnName("input_approve");

                entity.Property(e => e.IsCashcard).HasColumnName("is_cashcard");

                entity.Property(e => e.IsCommission).HasColumnName("is_commission");

                entity.Property(e => e.IsVoucher).HasColumnName("is_voucher");

                entity.Property(e => e.MethodDesc)
                    .HasColumnName("method_desc")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MethodGroup)
                    .IsRequired()
                    .HasColumnName("method_group")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MethodHot)
                    .HasColumnName("method_hot")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MethodShort)
                    .HasColumnName("method_short")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NotAllowSmc).HasColumnName("not_allow_smc");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('2014/07/01')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfPaymethGrp>(entity =>
            {
                entity.HasKey(e => e.MethodGroup);

                entity.ToTable("df_paymeth_grp");

                entity.Property(e => e.MethodGroup)
                    .HasColumnName("method_group")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DescMethodGrp)
                    .HasColumnName("desc_method_grp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfPickup>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.PickupCode });

                entity.ToTable("df_pickup");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ConsolLocCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DefaultPrinter)
                    .HasColumnName("default_printer")
                    .HasMaxLength(100);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FreeHanging).HasColumnName("free_hanging");

                entity.Property(e => e.IsFrn).HasColumnName("is_FRN");

                entity.Property(e => e.LastHanging).HasColumnName("last_hanging");

                entity.Property(e => e.LockDatetime)
                    .HasColumnName("lock_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LockIp)
                    .IsRequired()
                    .HasColumnName("lock_ip")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxHanging).HasColumnName("max_hanging");

                entity.Property(e => e.PickupGroup)
                    .IsRequired()
                    .HasColumnName("pickup_group")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickupName)
                    .IsRequired()
                    .HasColumnName("pickup_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PuLocation)
                    .HasColumnName("PU_Location")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfPoc>(entity =>
            {
                entity.HasKey(e => e.PocNo);

                entity.ToTable("df_poc");

                entity.Property(e => e.PocNo)
                    .HasColumnName("poc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.HotelCode)
                    .IsRequired()
                    .HasColumnName("hotel_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfPrize>(entity =>
            {
                entity.HasKey(e => e.PrizeId);

                entity.ToTable("df_prize");

                entity.Property(e => e.PrizeId).HasColumnName("prize_id");

                entity.Property(e => e.PrizeName)
                    .IsRequired()
                    .HasColumnName("prize_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfPromotion>(entity =>
            {
                entity.HasKey(e => new { e.PromoCode, e.StartDate, e.EndDate });

                entity.ToTable("df_promotion");

                entity.Property(e => e.PromoCode)
                    .HasColumnName("promo_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.NotAllowSmc)
                    .IsRequired()
                    .HasColumnName("not_allow_smc")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PromoDesc)
                    .IsRequired()
                    .HasColumnName("promo_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromoMap)
                    .IsRequired()
                    .HasColumnName("promo_map")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfProvince>(entity =>
            {
                entity.HasKey(e => e.ProvinceCode);

                entity.ToTable("df_province");

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasColumnName("province_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfPuLocation>(entity =>
            {
                entity.HasKey(e => e.PuLocation);

                entity.ToTable("df_pu_location");

                entity.Property(e => e.PuLocation)
                    .HasColumnName("PU_Location")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfRcvTbagGrp>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.RcvTbagGrp });

                entity.ToTable("df_rcv_tbag_grp");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RcvTbagGrp)
                    .HasColumnName("rcv_tbag_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RcvEveryMac).HasColumnName("rcv_every_mac");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfRcvTbagMac>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.MachineNo });

                entity.ToTable("df_rcv_tbag_mac");

                entity.HasIndex(e => new { e.BranchNo, e.RcvTbagGrp, e.MachineNo })
                    .HasName("IX_df_rcv_tbag_mac");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.RcvTbagGrp)
                    .IsRequired()
                    .HasColumnName("rcv_tbag_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfRefundDoc>(entity =>
            {
                entity.HasKey(e => e.RunNo);

                entity.ToTable("df_refund_doc");

                entity.HasIndex(e => e.DataDate)
                    .HasName("IX_df_refund_doc");

                entity.Property(e => e.RunNo)
                    .HasColumnName("run_no")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ClaimCheck).HasMaxLength(150);

                entity.Property(e => e.ClaimCheck1)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ClaimCheck2)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("cust_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PaidBy).HasMaxLength(150);

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrintDt)
                    .HasColumnName("PrintDT")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Reasons)
                    .IsRequired()
                    .HasColumnName("reasons")
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShortName).HasMaxLength(100);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasColumnName("telephone")
                    .HasMaxLength(50);

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<DfRefundMatdoc>(entity =>
            {
                entity.HasKey(e => new { e.OrderDate, e.CashierMac, e.ClaimcheckNo });

                entity.ToTable("df_refund_matdoc");

                entity.HasIndex(e => e.DocumentDate)
                    .HasName("IX_df_refund_matdoc");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CashierMac)
                    .HasColumnName("cashier_mac")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimcheckNo)
                    .HasColumnName("claimcheck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocDate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.MatDocNo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DfRefundTrans>(entity =>
            {
                entity.HasKey(e => new { e.RunNo, e.ItemNo });

                entity.ToTable("df_refund_trans");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType, e.LineNo })
                    .HasName("IX_df_refund_trans");

                entity.Property(e => e.RunNo)
                    .HasColumnName("run_no")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo).HasColumnName("item_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasColumnName("item_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Net)
                    .HasColumnName("net")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SuborderType)
                    .IsRequired()
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<DfRelocateHist>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.PickupCode, e.AddDatetime, e.OpaqNo });

                entity.ToTable("df_relocate_hist");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpaqNo)
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlightTime)
                    .IsRequired()
                    .HasColumnName("flight_time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HangingNo)
                    .HasColumnName("hanging_no")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoshowNo)
                    .HasColumnName("noshow_no")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxabbNo)
                    .IsRequired()
                    .HasColumnName("taxabb_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfReprintLog>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CashierMac, e.ClaimcheckNo, e.RunNo });

                entity.ToTable("df_reprint_log");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CashierMac)
                    .HasColumnName("cashier_mac")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimcheckNo)
                    .HasColumnName("claimcheck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RunNo)
                    .HasColumnName("run_no")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.MachineIp)
                    .IsRequired()
                    .HasColumnName("machine_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UserPrint)
                    .IsRequired()
                    .HasColumnName("user_print")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfReprintReceiptLog>(entity =>
            {
                entity.HasKey(e => e.ReprKey);

                entity.ToTable("df_reprint_receipt_log");

                entity.Property(e => e.ReprKey).HasColumnName("repr_key");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MachineIp)
                    .HasColumnName("machine_ip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleApp)
                    .HasColumnName("module_app")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.PackNo)
                    .HasColumnName("pack_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecNo).HasColumnName("rec_no");

                entity.Property(e => e.ResultPrinttm)
                    .HasColumnName("result_printtm")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SourceApp)
                    .HasColumnName("source_app")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UserCode)
                    .HasColumnName("user_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfSelectGrp>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OperGrp, e.ModuleCode, e.AuthCode, e.SelectCode });

                entity.ToTable("df_select_grp");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OperGrp)
                    .HasColumnName("oper_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasColumnName("auth_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectCode)
                    .HasColumnName("select_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectDesc)
                    .IsRequired()
                    .HasColumnName("select_desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfSelectItem>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OperGrp, e.ModuleCode, e.AuthCode, e.SelectCode, e.CtrlName });

                entity.ToTable("df_select_item");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OperGrp)
                    .HasColumnName("oper_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasColumnName("auth_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SelectCode)
                    .HasColumnName("select_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CtrlName)
                    .HasColumnName("ctrl_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ctrltype).HasColumnName("ctrltype");

                entity.Property(e => e.StrName)
                    .IsRequired()
                    .HasColumnName("str_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TxtSelect)
                    .HasColumnName("txtSelect")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<DfSerialNo>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.LineNo })
                    .HasName("PK_df_serial_no_1");

                entity.ToTable("df_serial_no");

                entity.HasIndex(e => e.SerialNo)
                    .HasName("IX_df_serial_no");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasColumnName("serial_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfSohdr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo });

                entity.ToTable("df_sohdr");

                entity.HasIndex(e => new { e.BranchNo, e.AddDatetime })
                    .HasName("df_sohdr_AddDateTime");

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate })
                    .HasName("IX_df_sohdr");

                entity.HasIndex(e => new { e.BranchNo, e.RefDoc })
                    .HasName("IX_df_sohdr_1");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode })
                    .HasName("IX_df_sohdr_tourcode");

                entity.HasIndex(e => new { e.BranchNo, e.AirlineCode, e.FlightCode, e.FlightDate })
                    .HasName("IX_df_sohdr_flight");

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate, e.ShoppingCard, e.OrderNo, e.TourCode, e.OrderStatus })
                    .HasName("df_sohdr26");

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate, e.ShoppingCard, e.OrderNo, e.AirlineCode, e.FlightCode, e.FlightDate, e.FlightTime, e.OrderStatus })
                    .HasName("df_sohdr23");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CancelToOrder).HasColumnName("cancel_to_order");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CardTypeId)
                    .HasColumnName("CardTypeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CashierCode)
                    .IsRequired()
                    .HasColumnName("cashier_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CashierMac)
                    .IsRequired()
                    .HasColumnName("cashier_mac")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustTypeCode)
                    .IsRequired()
                    .HasColumnName("cust_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmBossId)
                    .HasColumnName("EmBossID")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlightTime)
                    .IsRequired()
                    .HasColumnName("flight_time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [str_time] as '00:00'");

                entity.Property(e => e.HotelCode)
                    .IsRequired()
                    .HasColumnName("hotel_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HotelSource)
                    .IsRequired()
                    .HasColumnName("hotel_source")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LockAddress)
                    .HasColumnName("lock_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LvheaderKey).HasColumnName("LVHeaderKey");

                entity.Property(e => e.MachineTax)
                    .IsRequired()
                    .HasColumnName("machine_tax")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("order_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaidGuid).HasColumnName("paid_guid");

                entity.Property(e => e.Posid)
                    .IsRequired()
                    .HasColumnName("posid")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RefDoc)
                    .HasColumnName("ref_doc")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShopRef)
                    .IsRequired()
                    .HasColumnName("shop_ref")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDateSale)
                    .HasColumnName("update_date_sale")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfSohdrExt>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.Code });

                entity.ToTable("df_sohdr_ext");

                entity.HasIndex(e => new { e.Code, e.BranchNo, e.ShoppingCard, e.OrderNo })
                    .HasName("IX_df_sohdr_ext");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.runno).HasColumnName("runno").ValueGeneratedOnAdd();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.DfSohdr)
                    .WithMany(p => p.DfSohdrExt)
                    .HasForeignKey(d => new { d.BranchNo, d.ShoppingCard, d.OrderNo })
                    .HasConstraintName("FK_df_sohdr_ext_df_sohdr");
            });

            modelBuilder.Entity<DfSohdrExtend>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo });

                entity.ToTable("df_sohdr_extend");

                entity.HasIndex(e => e.ECommerceOrderNo)
                    .HasName("IX_df_sohdr_extend");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryCost).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ECommerceOrderNo)
                    .IsRequired()
                    .HasColumnName("eCommerceOrderNo")
                    .HasMaxLength(50);

                entity.Property(e => e.PickupTypeCode).HasMaxLength(10);

                entity.Property(e => e.Plant)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlatformId)
                    .IsRequired()
                    .HasColumnName("PlatformID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfSohist>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType, e.LineNo });

                entity.ToTable("df_sohist");

                entity.HasIndex(e => e.ItemCode)
                    .HasName("IX_df_sohist_item");

                entity.HasIndex(e => e.MatCode)
                    .HasName("IX_df_sohist_mat");

                entity.HasIndex(e => new { e.BranchNo, e.AddDatetime })
                    .HasName("IX_df_sohist_add_datetime");

                entity.HasIndex(e => new { e.BranchNo, e.TbagNo })
                    .HasName("IX_df_sohist");

                entity.HasIndex(e => new { e.BranchNo, e.MachineNo, e.TbagDatetime })
                    .HasName("IX_df_sohist_1");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SuborderType)
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ArrivalFlag)
                    .IsRequired()
                    .HasColumnName("arrival_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CancelStatus)
                    .IsRequired()
                    .HasColumnName("cancel_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CollectStatus)
                    .IsRequired()
                    .HasColumnName("collect_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ConsolDatetime)
                    .HasColumnName("consol_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ConsolFlag)
                    .IsRequired()
                    .HasColumnName("consol_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsolQty)
                    .HasColumnName("consol_qty")
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsolUser)
                    .IsRequired()
                    .HasColumnName("consol_user")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiscCode)
                    .IsRequired()
                    .HasColumnName("disc_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiscRate)
                    .HasColumnName("disc_rate")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasColumnName("item_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LineCancel)
                    .IsRequired()
                    .HasColumnName("line_cancel")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LockDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasColumnName("mat_code")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Net)
                    .HasColumnName("net")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NewTbag)
                    .IsRequired()
                    .HasColumnName("new_tbag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PickStatus)
                    .IsRequired()
                    .HasColumnName("pick_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasColumnName("promo_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.RecieveDatetime)
                    .HasColumnName("recieve_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RecieveFlag)
                    .IsRequired()
                    .HasColumnName("recieve_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RecieveQty)
                    .HasColumnName("recieve_qty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RecieveUser)
                    .IsRequired()
                    .HasColumnName("recieve_user")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rewards).HasDefaultValueSql("((0))");

                entity.Property(e => e.RewardsKarat)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RewardsPoint)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.RewardsPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.SellingPrice)
                    .HasColumnName("selling_price")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StaffCode)
                    .IsRequired()
                    .HasColumnName("staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaffCommRate)
                    .HasColumnName("staff_comm_rate")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TbagDatetime)
                    .HasColumnName("tbag_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TbagIssue)
                    .IsRequired()
                    .HasColumnName("tbag_issue")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TbagNo)
                    .IsRequired()
                    .HasColumnName("tbag_no")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VatRate)
                    .HasColumnName("vat_rate")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Vatno)
                    .IsRequired()
                    .HasColumnName("vatno")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfSohistExt>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType, e.LineNo, e.Code });

                entity.ToTable("df_sohist_ext");

                entity.HasIndex(e => new { e.Code, e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType, e.LineNo })
                    .HasName("IX_df_sohist_ext");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SuborderType)
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("line_no");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DfSohist)
                    .WithMany(p => p.DfSohistExt)
                    .HasForeignKey(d => new { d.BranchNo, d.ShoppingCard, d.OrderNo, d.SuborderType, d.LineNo })
                    .HasConstraintName("FK_df_sohist_ext_df_sohist");
            });

            modelBuilder.Entity<DfSourceType>(entity =>
            {
                entity.HasKey(e => e.SourceType);

                entity.ToTable("df_source_type");

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasColumnName("source_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfSpendingHdr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo });

                entity.ToTable("df_spending_hdr");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode })
                    .HasName("IX_df_spending_hdr_tour_code");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CancelToDoc)
                    .HasColumnName("cancel_to_doc")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DocDate)
                    .HasColumnName("doc_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidType)
                    .HasColumnName("paid_type")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiveBy)
                    .IsRequired()
                    .HasColumnName("Receive_By")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubagentCode)
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfSpendingRate>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CountryCode, e.Spending, e.SaleAmount });

                entity.ToTable("df_spending_rate");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Spending)
                    .HasColumnName("spending")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleAmount)
                    .HasColumnName("sale_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CommRate)
                    .HasColumnName("comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfSpendingTrans>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocNo, e.CountryCode });

                entity.ToTable("df_spending_trans");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CommAmount)
                    .HasColumnName("comm_amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommRate)
                    .HasColumnName("comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.CommSaleamtReq)
                    .HasColumnName("comm_saleamt_req")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CommSpendingReq)
                    .HasColumnName("comm_spending_req")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Net)
                    .HasColumnName("net")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pax).HasColumnName("pax");

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerheadAmount)
                    .HasColumnName("perhead_amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PhSaleamtReq)
                    .HasColumnName("ph_saleamt_req")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PhSpendingReq)
                    .HasColumnName("ph_spending_req")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleamountReq)
                    .HasColumnName("saleamount_req")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Spending)
                    .HasColumnName("spending")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpendingReq)
                    .HasColumnName("spending_req")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DfSubagent>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.SubagentCode });

                entity.ToTable("df_subagent");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SubagentCode)
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("address2")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasColumnName("address3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.CommPaid)
                    .IsRequired()
                    .HasColumnName("comm_paid")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DiscCommRate)
                    .HasColumnName("disc_comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpireId)
                    .HasColumnName("expire_id")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpireLicense)
                    .HasColumnName("expire_license")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExpirePass)
                    .HasColumnName("expire_pass")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.GuideGroupCode)
                    .IsRequired()
                    .HasColumnName("guide_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GuideIdcode)
                    .IsRequired()
                    .HasColumnName("guide_idcode")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuideLicense)
                    .IsRequired()
                    .HasColumnName("guide_license")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Hobby)
                    .IsRequired()
                    .HasColumnName("hobby")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ims)
                    .HasColumnName("ims")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LevelCode)
                    .IsRequired()
                    .HasColumnName("level_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MemRef)
                    .IsRequired()
                    .HasColumnName("mem_ref")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.MemcardTaken)
                    .IsRequired()
                    .HasColumnName("memcard_taken")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasColumnName("nick_name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NodiscCommRate)
                    .HasColumnName("nodisc_comm_rate")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PerCust)
                    .HasColumnName("per_cust")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RefCode01)
                    .IsRequired()
                    .HasColumnName("ref_code01")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RefCode02)
                    .IsRequired()
                    .HasColumnName("ref_code02")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.SubagentName)
                    .IsRequired()
                    .HasColumnName("subagent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SubagentType)
                    .IsRequired()
                    .HasColumnName("subagent_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasColumnName("zip_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<DfSuborderType>(entity =>
            {
                entity.HasKey(e => e.SuborderType);

                entity.ToTable("df_suborder_type");

                entity.Property(e => e.SuborderType)
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.SuborderDesc)
                    .IsRequired()
                    .HasColumnName("suborder_desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfSubpayment>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType, e.LineNo });

                entity.ToTable("df_subpayment");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SuborderType)
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo)
                    .HasColumnName("line_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AmountVat)
                    .HasColumnName("amount_vat")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CredCardNo)
                    .IsRequired()
                    .HasColumnName("cred_card_no")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfSubsohdr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType });

                entity.ToTable("df_subsohdr");

                entity.HasIndex(e => e.TruckDatetime)
                    .HasName("IX_df_subsohdr_4");

                entity.HasIndex(e => new { e.BranchNo, e.BoxNo })
                    .HasName("IX_df_subsohdr_1");

                entity.HasIndex(e => new { e.BranchNo, e.OpaqNo })
                    .HasName("IX_df_subsohdr");

                entity.HasIndex(e => new { e.BranchNo, e.RecNo })
                    .HasName("IX_Df_subsohdr_RecNo")
                    .IsUnique();

                entity.HasIndex(e => new { e.BoxNo, e.CancelStatus, e.BranchNo, e.OpaqNo })
                    .HasName("IX_df_subsohdr_3");

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate, e.CashierMac, e.TaxabbNo })
                    .HasName("IX_df_subsohdr_2");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SuborderType)
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BoxBy)
                    .IsRequired()
                    .HasColumnName("box_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoxNo)
                    .IsRequired()
                    .HasColumnName("box_no")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoxType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CancelStatus)
                    .IsRequired()
                    .HasColumnName("cancel_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CashierMac)
                    .IsRequired()
                    .HasColumnName("cashier_mac")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaimTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClaimcheckNo)
                    .IsRequired()
                    .HasColumnName("claimcheck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Frn).HasColumnName("FRN");

                entity.Property(e => e.HangingNo)
                    .HasColumnName("hanging_no")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IssuedBy)
                    .IsRequired()
                    .HasColumnName("issued_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssuedDatetime)
                    .HasColumnName("issued_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IssuedStatus)
                    .IsRequired()
                    .HasColumnName("issued_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IssuedType)
                    .IsRequired()
                    .HasColumnName("issued_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MoveHangingDatetime)
                    .HasColumnName("move_hanging_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NewHangingNo).HasMaxLength(10);

                entity.Property(e => e.OldHanging)
                    .HasColumnName("old_hanging")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OpaqBy)
                    .IsRequired()
                    .HasColumnName("opaq_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpaqNo)
                    .IsRequired()
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpaqTfkey).HasColumnName("OpaqTFKey");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.PackStaffCode)
                    .IsRequired()
                    .HasColumnName("pack_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PickupDatetime)
                    .HasColumnName("pickup_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PickupStaffCode)
                    .IsRequired()
                    .HasColumnName("pickup_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecNo).ValueGeneratedOnAdd();

                entity.Property(e => e.RefNo)
                    .HasColumnName("ref_no")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxabbNo)
                    .IsRequired()
                    .HasColumnName("taxabb_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TransDoc)
                    .HasColumnName("trans_doc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransLine).HasColumnName("trans_line");

                entity.Property(e => e.TripNo)
                    .IsRequired()
                    .HasColumnName("trip_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TruckBy)
                    .IsRequired()
                    .HasColumnName("truck_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TruckDatetime)
                    .HasColumnName("truck_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TruckNo)
                    .IsRequired()
                    .HasColumnName("truck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.OpaqTfkeyNavigation)
                    .WithMany(p => p.DfSubsohdr)
                    .HasForeignKey(d => d.OpaqTfkey)
                    .HasConstraintName("FK_df_subsohdr_New_OpaqTF");
            });

            modelBuilder.Entity<DfSubsohdrExt>(entity =>
            {
                entity.HasKey(e => e.SubSoHdrExtKey);

                entity.ToTable("df_subsohdr_ext");

                entity.HasIndex(e => new { e.BranchNo, e.SubSohdrRecNo, e.Code })
                    .HasName("IX_df_subsohdr_ext");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.DfSubsohdr)
                    .WithMany(p => p.DfSubsohdrExt)
                    .HasPrincipalKey(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey(d => new { d.BranchNo, d.SubSohdrRecNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_df_subsohdr_ext_df_subsohdr");
            });

            modelBuilder.Entity<DfTbagChange>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TbagNo });

                entity.ToTable("df_tbag_change");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TbagNo)
                    .HasColumnName("tbag_no")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CntLine)
                    .HasColumnName("cnt_line")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NewTbagNo)
                    .IsRequired()
                    .HasColumnName("new_tbag_no")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfTbagCont>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TbagNo });

                entity.ToTable("df_tbag_cont");

                entity.HasIndex(e => new { e.BranchNo, e.AddDate, e.ToStaffCode })
                    .HasName("IX_df_tbag_cont");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TbagNo)
                    .HasColumnName("tbag_no")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate)
                    .HasColumnName("add_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.FromStaffCode)
                    .IsRequired()
                    .HasColumnName("from_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessTime)
                    .HasColumnName("process_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.ToStaffCode)
                    .IsRequired()
                    .HasColumnName("to_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfTourExtend>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TourCode });

                entity.ToTable("df_tour_extend");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityCode)
                    .HasColumnName("city_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Inputform)
                    .HasColumnName("inputform")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("mobile_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfTourhdr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TourCode });

                entity.ToTable("df_tourhdr");

                entity.HasIndex(e => new { e.BranchNo, e.TourDate, e.SubagentCode })
                    .HasName("IX_df_tourhdr");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode, e.TourDate, e.AgentCode, e.SubagentCode, e.CountryCode })
                    .HasName("IX_df_tourhdr_2");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode, e.TourDate, e.AgentCode, e.SubagentCode, e.TourDesc })
                    .HasName("IX_df_tourhdr_1");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CarLicence)
                    .HasColumnName("car_licence")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FeeType)
                    .HasColumnName("fee_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FlightTime)
                    .IsRequired()
                    .HasColumnName("flight_time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HotelCode)
                    .IsRequired()
                    .HasColumnName("hotel_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoPax)
                    .HasColumnName("no_pax")
                    .HasColumnType("decimal(10, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.SubagentCode)
                    .IsRequired()
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TourBookStatus)
                    .IsRequired()
                    .HasColumnName("tour_book_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TourDate)
                    .HasColumnName("tour_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TourDesc)
                    .IsRequired()
                    .HasColumnName("tour_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TourStatus)
                    .IsRequired()
                    .HasColumnName("tour_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TourTime)
                    .IsRequired()
                    .HasColumnName("tour_time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransportCode)
                    .HasColumnName("transport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfTransport>(entity =>
            {
                entity.HasKey(e => e.TransportCode);

                entity.ToTable("df_transport");

                entity.Property(e => e.TransportCode)
                    .HasColumnName("transport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TransportName)
                    .IsRequired()
                    .HasColumnName("transport_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfTruck>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TruckNo });

                entity.ToTable("df_truck");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.TruckNo)
                    .HasColumnName("truck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.LastTripDatetime)
                    .HasColumnName("last_trip_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.LockDatetime)
                    .HasColumnName("lock_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LockIp)
                    .IsRequired()
                    .HasColumnName("lock_ip")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxBox)
                    .HasColumnName("max_box")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TruckLicence)
                    .IsRequired()
                    .HasColumnName("truck_licence")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TruckName)
                    .IsRequired()
                    .HasColumnName("truck_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfTruckCont>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.BoxNo });

                entity.ToTable("df_truck_cont");

                entity.HasIndex(e => new { e.BranchNo, e.TripNo })
                    .HasName("IX_df_truck_cont_trip_no");

                entity.HasIndex(e => new { e.BranchNo, e.TruckNo })
                    .HasName("IX_df_truck_cont");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BoxNo)
                    .HasColumnName("box_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TripNo)
                    .IsRequired()
                    .HasColumnName("trip_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TruckDate)
                    .HasColumnName("truck_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.TruckDatetime)
                    .HasColumnName("truck_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.TruckNo)
                    .IsRequired()
                    .HasColumnName("truck_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TruckStaffCode)
                    .IsRequired()
                    .HasColumnName("truck_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfUpdateLog>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ModuleCode, e.FrmName, e.UpdateDate, e.UpdateTime, e.IpAddress, e.KeyCode });

                entity.ToTable("df_update_log");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FrmName)
                    .HasColumnName("frm_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [date_only] as CONVERT(char(12), GETDATE(), 112)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyCode)
                    .HasColumnName("key_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateMsg)
                    .IsRequired()
                    .HasColumnName("update_msg")
                    .HasColumnType("text");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfUpdateLogHistory>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ModuleCode, e.FrmName, e.UpdateDate, e.UpdateTime, e.IpAddress, e.KeyCode });

                entity.ToTable("df_update_log_History");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FrmName)
                    .HasColumnName("frm_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyCode)
                    .HasColumnName("key_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateMsg)
                    .IsRequired()
                    .HasColumnName("update_msg")
                    .HasColumnType("text");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfUser>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.UserCode });

                entity.ToTable("df_user");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.OperGrp)
                    .HasColumnName("oper_grp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasColumnName("user_pwd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfUserGrp>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.UserCode, e.GrpCode });

                entity.ToTable("df_user_grp");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpCode)
                    .HasColumnName("grp_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfVat>(entity =>
            {
                entity.HasKey(e => e.VatCode);

                entity.ToTable("df_vat");

                entity.Property(e => e.VatCode)
                    .HasColumnName("vat_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VatDesc)
                    .IsRequired()
                    .HasColumnName("vat_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VatRate)
                    .HasColumnName("vat_rate")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DfVatRefund>(entity =>
            {
                entity.HasKey(e => new { e.BookNo, e.RunNo });

                entity.ToTable("df_vat_refund");

                entity.HasIndex(e => e.DataDate)
                    .HasName("IX_df_vat_refund");

                entity.HasIndex(e => new { e.DataDate, e.AddUser })
                    .HasName("IX_df_vat_refund_1");

                entity.HasIndex(e => new { e.BookNo, e.RunNo, e.ShoppingCard, e.PassportNo })
                    .HasName("IX_df_vat_refund_all");

                entity.Property(e => e.BookNo)
                    .HasColumnName("book_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RunNo)
                    .HasColumnName("run_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddUser)
                    .HasColumnName("add_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("cust_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrintUser)
                    .HasColumnName("print_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.VatRefundable)
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("((0.0))");
            });

            modelBuilder.Entity<DfVatRefundAddress>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("df_vat_refund_address");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxBranchNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TaxId1)
                    .IsRequired()
                    .HasColumnName("TaxID1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId13)
                    .HasColumnName("TaxID13")
                    .HasMaxLength(13);

                entity.Property(e => e.TaxId2)
                    .IsRequired()
                    .HasColumnName("TaxID2")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxId3)
                    .IsRequired()
                    .HasColumnName("TaxID3")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxId4)
                    .IsRequired()
                    .HasColumnName("TaxID4")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfVatRefundIncentive>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.RateCode });

                entity.ToTable("df_vat_refund_incentive");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RateCode)
                    .HasColumnName("rate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.QtyFrom).HasColumnName("qty_from");

                entity.Property(e => e.QtyTo).HasColumnName("qty_to");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfVatRefundRate>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.RateCode });

                entity.ToTable("df_vat_refund_rate");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RateCode)
                    .HasColumnName("rate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AmountFrom)
                    .HasColumnName("amount_from")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AmountTo)
                    .HasColumnName("amount_to")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.IsPercent).HasColumnName("is_percent");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ServiceFee).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DfVoucher>(entity =>
            {
                entity.HasKey(e => e.VoucherNo);

                entity.ToTable("df_voucher");

                entity.HasIndex(e => e.KeySearch)
                    .HasName("IX_df_voucher_2");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.VoucherNo })
                    .HasName("IX_df_voucher_1");

                entity.HasIndex(e => new { e.BranchNo, e.DataDate, e.MachineNo, e.DocNo, e.VoucherNo })
                    .HasName("IX_df_voucher");

                entity.Property(e => e.VoucherNo)
                    .HasColumnName("voucher_no")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('U')");

                entity.Property(e => e.KeySearch)
                    .IsRequired()
                    .HasColumnName("key_search")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DfVoucherCancel>(entity =>
            {
                entity.HasKey(e => e.VoucherNo);

                entity.ToTable("df_voucher_cancel");

                entity.Property(e => e.VoucherNo)
                    .HasColumnName("voucher_no")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasColumnType("text");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiscAuthHeader>(entity =>
            {
                entity.HasKey(e => e.DiscAuthHeaderKey);

                entity.Property(e => e.DiscAuthHeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FromPercent).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.ToPercent).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiscAuthUser>(entity =>
            {
                entity.HasKey(e => e.DiscAuthUserKey);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SecureCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasColumnName("user_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiscBlock>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Code });

                entity.ToTable("DISC_Block");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<DiscConstrainAnd>(entity =>
            {
                entity.HasKey(e => e.DiscconstrainAndKey);

                entity.ToTable("DISC_ConstrainAnd");

                entity.Property(e => e.DiscconstrainAndKey).HasColumnName("DISCConstrainAndKey");

                entity.Property(e => e.DiscconstrainValueKey).HasColumnName("DISCConstrainValueKey");

                entity.Property(e => e.FilterField)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<DiscConstrainFilter>(entity =>
            {
                entity.HasKey(e => e.DiscconstrainFilterKey);

                entity.ToTable("DISC_ConstrainFilter");

                entity.Property(e => e.DiscconstrainFilterKey).HasColumnName("DISCConstrainFilterKey");

                entity.Property(e => e.DiscconstrainHdcode)
                    .IsRequired()
                    .HasColumnName("DISCConstrainHDCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilterField)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<DiscConstrainHd>(entity =>
            {
                entity.HasKey(e => e.DiscconstrainHdcode);

                entity.ToTable("DISC_ConstrainHD");

                entity.Property(e => e.DiscconstrainHdcode)
                    .HasColumnName("DISCConstrainHDCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiscconstrainHdname)
                    .HasColumnName("DISCConstrainHDName")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<DiscConstrainValue>(entity =>
            {
                entity.HasKey(e => e.DiscconstrainValueKey);

                entity.ToTable("DISC_ConstrainValue");

                entity.Property(e => e.DiscconstrainValueKey).HasColumnName("DISCConstrainValueKey");

                entity.Property(e => e.DiscconstrainHdcode)
                    .IsRequired()
                    .HasColumnName("DISCConstrainHDCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilterFiled)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxPercentDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<Dtserver>(entity =>
            {
                entity.ToTable("DTServer");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DbDt)
                    .HasColumnName("dbDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Edcissuer>(entity =>
            {
                entity.HasKey(e => new { e.IssuerId, e.IsDcc });

                entity.ToTable("EDCIssuer");

                entity.Property(e => e.IssuerId)
                    .HasColumnName("issuer_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsDcc).HasColumnName("IsDCC");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MethodCodeNavigation)
                    .WithMany(p => p.Edcissuer)
                    .HasForeignKey(d => d.MethodCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDCIssuer_df_paymeth");
            });

            modelBuilder.Entity<Edclog>(entity =>
            {
                entity.HasKey(e => e.EdclogKey);

                entity.ToTable("EDCLog");

                entity.HasIndex(e => e.AddDt)
                    .HasName("IX_EDCLog_1");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo })
                    .HasName("IX_EDCLog");

                entity.Property(e => e.EdclogKey).HasColumnName("EDCLogKey");

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CashierCode)
                    .IsRequired()
                    .HasColumnName("cashier_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CashierMac)
                    .IsRequired()
                    .HasColumnName("cashier_mac")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasMaxLength(150);
            });

            modelBuilder.Entity<EditSoHdr>(entity =>
            {
                entity.HasKey(e => e.EditSoHdrKey)
                    .HasName("PK_EditSoHrd");

                entity.HasIndex(e => new { e.EditSoHdrKey, e.BranchNo, e.ShoppingCard, e.OrderNo, e.FlightDate })
                    .HasName("IX_EditSoHdr_All");

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(10);

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2);

                entity.Property(e => e.FlightCode)
                    .HasColumnName("flight_code")
                    .HasMaxLength(10);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightTime)
                    .HasColumnName("flight_time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [str_time] as '00:00'");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExpenseType>(entity =>
            {
                entity.HasKey(e => e.ExpenseTypeKey);

                entity.Property(e => e.ExpenseTypeKey).ValueGeneratedNever();

                entity.Property(e => e.ExpenseTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Gvactivate>(entity =>
            {
                entity.HasKey(e => e.Barcode);

                entity.ToTable("GVActivate");

                entity.HasIndex(e => e.ExpiredDate)
                    .HasName("IX_GVActivate_2");

                entity.HasIndex(e => e.UsedDate)
                    .HasName("IX_GVActivate");

                entity.HasIndex(e => e.ValidedDate)
                    .HasName("IX_GVActivate_1");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.ExpiredDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UsedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ValidedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<GvbarcodeFix>(entity =>
            {
                entity.HasKey(e => e.MethodCode);

                entity.ToTable("GVBarcodeFix");

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<GwpBrand>(entity =>
            {
                entity.HasKey(e => e.GwpbrandKey);

                entity.ToTable("GWP_Brand");

                entity.HasIndex(e => new { e.GroupCode, e.BrandCode })
                    .HasName("IX_GWP_Brand");

                entity.Property(e => e.GwpbrandKey).HasColumnName("GWPBrandKey");

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpBrand)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_Brand_GWP_Group");
            });

            modelBuilder.Entity<GwpCate>(entity =>
            {
                entity.HasKey(e => e.GwpcateKey);

                entity.ToTable("GWP_Cate");

                entity.HasIndex(e => new { e.GroupCode, e.CateCode })
                    .HasName("IX_GWP_Cate")
                    .IsUnique();

                entity.Property(e => e.GwpcateKey).HasColumnName("GWPCateKey");

                entity.Property(e => e.CateCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpCate)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_Cate_GWP_Group");
            });

            modelBuilder.Entity<GwpCoupon>(entity =>
            {
                entity.HasKey(e => e.GwpcouponKey);

                entity.ToTable("GWP_Coupon");

                entity.HasIndex(e => e.CouponCode)
                    .HasName("IX_GWP_Coupon")
                    .IsUnique();

                entity.Property(e => e.GwpcouponKey).HasColumnName("GWPCouponKey");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SlipText)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpCoupon)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_Coupon_GWP_Group");
            });

            modelBuilder.Entity<GwpCouponTrans>(entity =>
            {
                entity.HasKey(e => e.GwpCouponTransKey);

                entity.ToTable("GWP_CouponTrans");

                entity.HasIndex(e => e.CouponCode)
                    .HasName("IX_GWP_CouponTrans_2");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.CouponCode })
                    .HasName("IX_GWP_CouponTrans_1");

                entity.HasIndex(e => new { e.BranchNo, e.DataDate, e.MachineNo, e.DocNo, e.CouponCode })
                    .HasName("IX_GWP_CouponTrans");

                entity.Property(e => e.GwpCouponTransKey).HasColumnName("GWP_CouponTransKey");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataDate)
                    .HasColumnName("data_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeySearch)
                    .IsRequired()
                    .HasColumnName("key_search")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CouponCodeNavigation)
                    .WithMany(p => p.GwpCouponTrans)
                    .HasPrincipalKey(p => p.CouponCode)
                    .HasForeignKey(d => d.CouponCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_CouponTrans_GWP_Coupon");
            });

            modelBuilder.Entity<GwpCustType>(entity =>
            {
                entity.HasKey(e => e.GwpcustTypeKey);

                entity.ToTable("GWP_CustType");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("IX_GWPCustType1");

                entity.Property(e => e.GwpcustTypeKey).HasColumnName("GWPCustTypeKey");

                entity.Property(e => e.CustTypeCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpCustType)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_CustType_GWP_Group");
            });

            modelBuilder.Entity<GwpExcPaymeth>(entity =>
            {
                entity.HasKey(e => e.ExPaymethKey);

                entity.ToTable("GWP_ExcPaymeth");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("IX_GWP_ExcPaymeth");

                entity.HasIndex(e => new { e.GroupCode, e.MethodCode })
                    .HasName("IX_GWP_ExcPaymeth_1")
                    .IsUnique();

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpExcPaymeth)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_ExcPaymeth_GWP_Group");
            });

            modelBuilder.Entity<GwpGroup>(entity =>
            {
                entity.HasKey(e => e.GroupCode);

                entity.ToTable("GWP_Group");

                entity.HasIndex(e => new { e.GroupId, e.GroupCode })
                    .HasName("IX_GWP_Group");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnName("GroupID")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GwpItem>(entity =>
            {
                entity.HasKey(e => e.GwpitemKey);

                entity.ToTable("GWP_Item");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("IX_GWP_Item_1");

                entity.HasIndex(e => e.MatCode)
                    .HasName("IX_GWP_Item")
                    .IsUnique();

                entity.HasIndex(e => new { e.GroupCode, e.MatCode })
                    .HasName("IX_GWP_Item_2")
                    .IsUnique();

                entity.Property(e => e.GwpitemKey).HasColumnName("GWPItemKey");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatCode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpItem)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_Item_GWP_Group");
            });

            modelBuilder.Entity<GwpMachine>(entity =>
            {
                entity.HasKey(e => e.GwpmacKey);

                entity.ToTable("GWP_Machine");

                entity.Property(e => e.GwpmacKey).HasColumnName("GWPMacKey");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GwpNation>(entity =>
            {
                entity.HasKey(e => e.GwpnationKey);

                entity.ToTable("GWP_Nation");

                entity.HasIndex(e => e.GroupCode)
                    .HasName("IX_GWPNation1");

                entity.Property(e => e.GwpnationKey).HasColumnName("GWPNationKey");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NationCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpNation)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_Nation_GWP_Group");
            });

            modelBuilder.Entity<GwpPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodKey);

                entity.ToTable("GWP_Period");

                entity.HasIndex(e => new { e.StartDate, e.EndDate, e.GroupCode })
                    .HasName("IX_GWP_Period");

                entity.HasIndex(e => new { e.StartDate, e.EndDate, e.NetBuy, e.GroupCode })
                    .HasName("IX_GWP_Period_NetBuy");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gwpqty)
                    .HasColumnName("GWPQty")
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NetBuy)
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("((30000))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GwpPeriod)
                    .HasForeignKey(d => d.GroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GWP_Period_GWP_Group");
            });

            modelBuilder.Entity<HoldBoxFlight>(entity =>
            {
                entity.HasKey(e => new { e.HoldBoxHeaderKey, e.GroupNo });

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDt)
                    .HasColumnName("FlightDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<HoldBoxHeader>(entity =>
            {
                entity.HasKey(e => e.HoldBoxHeaderKey);

                entity.HasIndex(e => new { e.BranchNo, e.HoldBoxHeaderCode })
                    .HasName("IX_HoldBoxHeader");

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate })
                    .HasName("IX_HoldBoxHeader_1");

                entity.Property(e => e.HoldBoxHeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HoldBoxHeaderCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HoldBoxTbag>(entity =>
            {
                entity.HasKey(e => e.HoldBoxTbagKey);

                entity.HasIndex(e => e.TbagCode)
                    .HasName("IX_HoldBoxTbag");

                entity.HasIndex(e => new { e.HoldBoxHeaderKey, e.TbagCode })
                    .HasName("IX_HoldBoxHeaderKey");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TbagCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HoldBoxHeaderKeyNavigation)
                    .WithMany(p => p.HoldBoxTbag)
                    .HasForeignKey(d => d.HoldBoxHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoldBoxTbag_HoldBoxHeader");

                entity.HasOne(d => d.HoldBoxFlight)
                    .WithMany(p => p.HoldBoxTbag)
                    .HasForeignKey(d => new { d.HoldBoxHeaderKey, d.GroupNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoldBoxTbag_HoldBoxFlight");
            });

            modelBuilder.Entity<Inbound>(entity =>
            {
                entity.HasKey(e => e.ArticleCode);

                entity.ToTable("inbound");

                entity.Property(e => e.ArticleCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleName).HasMaxLength(80);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<InshopExtraRateCfg>(entity =>
            {
                entity.HasKey(e => e.InshopExtraRateCfgkey);

                entity.ToTable("InshopExtraRateCFG");

                entity.Property(e => e.InshopExtraRateCfgkey).HasColumnName("InshopExtraRateCFGKey");

                entity.Property(e => e.BahtPerHead).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidEndDt).HasColumnName("PaidEndDT");

                entity.Property(e => e.PaidStartDt).HasColumnName("PaidStartDT");

                entity.Property(e => e.TourCountryCode).HasMaxLength(10);

                entity.Property(e => e.ValidFromDt)
                    .HasColumnName("ValidFromDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VallidToDt)
                    .HasColumnName("VallidToDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MaAction>(entity =>
            {
                entity.HasKey(e => e.ActCode);

                entity.ToTable("ma_action");

                entity.Property(e => e.ActCode)
                    .HasColumnName("act_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActName)
                    .IsRequired()
                    .HasColumnName("act_name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MaAuthType>(entity =>
            {
                entity.HasKey(e => e.AuthType);

                entity.ToTable("ma_auth_type");

                entity.Property(e => e.AuthType)
                    .HasColumnName("auth_type")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActId)
                    .IsRequired()
                    .HasColumnName("act_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthName)
                    .IsRequired()
                    .HasColumnName("auth_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaInstall>(entity =>
            {
                entity.HasKey(e => e.FileName)
                    .HasName("PK_ma_install_new");

                entity.ToTable("ma_install");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FileBinary)
                    .HasColumnName("file_binary")
                    .HasColumnType("image");

                entity.Property(e => e.FileDatetime)
                    .HasColumnName("file_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileRelease)
                    .HasColumnName("file_release")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FileVersion)
                    .IsRequired()
                    .HasColumnName("file_version")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaInstallCur>(entity =>
            {
                entity.HasKey(e => e.FileName)
                    .HasName("PK_ma_install_old");

                entity.ToTable("ma_install_cur");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FileBinary)
                    .HasColumnName("file_binary")
                    .HasColumnType("image");

                entity.Property(e => e.FileDatetime)
                    .HasColumnName("file_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileRelease)
                    .HasColumnName("file_release")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FileVersion)
                    .IsRequired()
                    .HasColumnName("file_version")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaModule>(entity =>
            {
                entity.HasKey(e => e.ModuleCode)
                    .HasName("PK_ma_module_new");

                entity.ToTable("ma_module");

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleExe)
                    .HasColumnName("module_exe")
                    .HasColumnType("image");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasColumnName("module_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleVersion)
                    .IsRequired()
                    .HasColumnName("module_version")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MaModuleCur>(entity =>
            {
                entity.HasKey(e => e.ModuleCode)
                    .HasName("PK_ma_module");

                entity.ToTable("ma_module_cur");

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FileSize)
                    .HasColumnName("file_size")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleExe)
                    .HasColumnName("module_exe")
                    .HasColumnType("image");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasColumnName("module_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleVersion)
                    .IsRequired()
                    .HasColumnName("module_version")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MaModuleHist>(entity =>
            {
                entity.HasKey(e => new { e.ModuleCode, e.Version });

                entity.ToTable("ma_module_hist");

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerBy)
                    .IsRequired()
                    .HasColumnName("ver_by")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerDatetime)
                    .HasColumnName("ver_datetime")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MaObjAuth>(entity =>
            {
                entity.HasKey(e => new { e.ModuleCode, e.AuthCode });

                entity.ToTable("ma_obj_auth");

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasColumnName("auth_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthName)
                    .IsRequired()
                    .HasColumnName("auth_name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthType)
                    .IsRequired()
                    .HasColumnName("auth_type")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MaRelocateType>(entity =>
            {
                entity.HasKey(e => e.RelocateType);

                entity.ToTable("ma_relocate_type");

                entity.Property(e => e.RelocateType)
                    .HasColumnName("relocate_type")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxRunno).HasColumnName("max_runno");

                entity.Property(e => e.NoshowType).HasColumnName("noshow_type");

                entity.Property(e => e.RelocateName)
                    .IsRequired()
                    .HasColumnName("relocate_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MainConnectStatus>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastDisconnectDateTime).HasColumnType("datetime");

                entity.Property(e => e.SecondReconnect).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<MastArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleCode);

                entity.ToTable("MAST_Article");

                entity.HasIndex(e => new { e.ArticleCode, e.Mccode, e.IsCanceled })
                    .HasName("IX_MAST_Article_Cancel");

                entity.Property(e => e.ArticleCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivationDt)
                    .HasColumnName("ActivationDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2012-01-01')");

                entity.Property(e => e.ArticleName).HasMaxLength(80);

                entity.Property(e => e.ArticleTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gtin)
                    .HasColumnName("GTIN")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsQtyprohibited).HasColumnName("IsQTYProhibited");

                entity.Property(e => e.Mccode)
                    .IsRequired()
                    .HasColumnName("MCCode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('EA')");

                entity.Property(e => e.VatCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.Volume)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.HasOne(d => d.BrandCodeNavigation)
                    .WithMany(p => p.MastArticle)
                    .HasForeignKey(d => d.BrandCode)
                    .HasConstraintName("FK_MAST_Article_MAST_Brand");

                entity.HasOne(d => d.MccodeNavigation)
                    .WithMany(p => p.MastArticle)
                    .HasForeignKey(d => d.Mccode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAST_Article_MAST_MC");
            });

            modelBuilder.Entity<MastBrand>(entity =>
            {
                entity.HasKey(e => e.BrandCode);

                entity.ToTable("MAST_Brand");

                entity.Property(e => e.BrandCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).IsRowVersion();
            });

            modelBuilder.Entity<MastChequeLocation>(entity =>
            {
                entity.HasKey(e => e.ChequeLocKey);

                entity.ToTable("Mast_ChequeLocation");

                entity.Property(e => e.ChequeLocKey)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ChequeLocDesc)
                    .IsRequired()
                    .HasColumnName("ChequeLoc_Desc")
                    .HasMaxLength(50);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MastCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrCode)
                    .HasName("PK_MAST_Currency_1");

                entity.ToTable("MAST_Currency");

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrSymbol)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).IsRowVersion();
            });

            modelBuilder.Entity<MastEan>(entity =>
            {
                entity.HasKey(e => e.Eancode);

                entity.ToTable("MAST_EAN");

                entity.HasIndex(e => new { e.ArticleCode, e.Eancode, e.IsCancel })
                    .HasName("IX_MAST_EAN_Article");

                entity.Property(e => e.Eancode)
                    .HasColumnName("EANCode")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.ArticleCodeNavigation)
                    .WithMany(p => p.MastEan)
                    .HasForeignKey(d => d.ArticleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAST_EAN_MAST_Article");
            });

            modelBuilder.Entity<MastExchangeRate>(entity =>
            {
                entity.HasKey(e => new { e.CurrCode, e.Dchannel, e.ActivateDt });

                entity.ToTable("MAST_ExchangeRate");

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dchannel)
                    .HasColumnName("DChannel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActivateDt)
                    .HasColumnName("ActivateDT")
                    .HasColumnType("date");

                entity.Property(e => e.ExRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.HasOne(d => d.CurrCodeNavigation)
                    .WithMany(p => p.MastExchangeRate)
                    .HasForeignKey(d => d.CurrCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAST_ExchangeRate_MAST_Currency");
            });

            modelBuilder.Entity<MastMc>(entity =>
            {
                entity.HasKey(e => e.Mccode);

                entity.ToTable("MAST_MC");

                entity.HasIndex(e => new { e.Mccode, e.Mcparent })
                    .HasName("IX_Mast_MC_McParent");

                entity.Property(e => e.Mccode)
                    .HasColumnName("MCCode")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Mclevel)
                    .HasColumnName("MCLevel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mcname)
                    .HasColumnName("MCName")
                    .HasMaxLength(45);

                entity.Property(e => e.Mcparent)
                    .HasColumnName("MCParent")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.HasOne(d => d.McparentNavigation)
                    .WithMany(p => p.InverseMcparentNavigation)
                    .HasForeignKey(d => d.Mcparent)
                    .HasConstraintName("FK_MAST_MC_MAST_MC");
            });

            modelBuilder.Entity<MastMcExtend>(entity =>
            {
                entity.HasKey(e => e.Mccode);

                entity.ToTable("MAST_MC_Extend");

                entity.Property(e => e.Mccode)
                    .HasColumnName("MCCode")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyLimitQty).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CommRate)
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.HasOne(d => d.MccodeNavigation)
                    .WithOne(p => p.MastMcExtend)
                    .HasForeignKey<MastMcExtend>(d => d.Mccode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAST_MC_Extend_MAST_MC");
            });

            modelBuilder.Entity<MastPrice>(entity =>
            {
                entity.HasKey(e => e.MastPriceKey)
                    .HasName("PK_MAST_Price_1");

                entity.ToTable("MAST_Price");

                entity.HasIndex(e => new { e.CondtypeCode, e.Dchannel, e.PriceList, e.ArticleCode, e.StartDt, e.EndDt })
                    .HasName("IX_MAST_Price");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CondtypeCode)
                    .IsRequired()
                    .HasColumnName("CONDTypeCode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dchannel)
                    .IsRequired()
                    .HasColumnName("DChannel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EndDt)
                    .HasColumnName("EndDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2099-01-01')");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceList)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDt)
                    .HasColumnName("StartDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2012-01-01')");

                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.HasOne(d => d.ArticleCodeNavigation)
                    .WithMany(p => p.MastPrice)
                    .HasForeignKey(d => d.ArticleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAST_Price_MAST_Article");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasIndex(e => e.AddDatetime)
                    .HasName("IX_df_member_add_datetime");

                entity.HasIndex(e => e.ApplyDate)
                    .HasName("IX_df_member_apply_date");

                entity.HasIndex(e => e.CardTypeId)
                    .HasName("IX_df_member_2");

                entity.HasIndex(e => e.DateOfBirth)
                    .HasName("IX_df_member_1");

                entity.HasIndex(e => e.Ename)
                    .HasName("IX_df_member_ename");

                entity.HasIndex(e => e.IdCard)
                    .HasName("IX_df_member_id_card");

                entity.HasIndex(e => e.MainId)
                    .HasName("IX_df_member_main_id");

                entity.HasIndex(e => e.PassportNo)
                    .HasName("IX_df_member_passport_no");

                entity.HasIndex(e => e.TempCard)
                    .HasName("IX_df_member_3");

                entity.HasIndex(e => e.Tname)
                    .HasName("IX_df_member_tname");

                entity.HasIndex(e => e.UpdateDatetime)
                    .HasName("IX_update_datetime");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Addr1)
                    .HasColumnName("addr1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasColumnName("addr2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Addr3)
                    .HasColumnName("addr3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyDate)
                    .HasColumnName("apply_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BussinessId)
                    .IsRequired()
                    .HasColumnName("bussiness_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeId)
                    .IsRequired()
                    .HasColumnName("card_type_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CondfId)
                    .IsRequired()
                    .HasColumnName("condf_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditKpg)
                    .IsRequired()
                    .HasColumnName("credit_kpg")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasColumnName("discount")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmbossId)
                    .IsRequired()
                    .HasColumnName("emboss_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EmbossName)
                    .IsRequired()
                    .HasColumnName("emboss_name")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasColumnName("ename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCard)
                    .IsRequired()
                    .HasColumnName("id_card")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MainId)
                    .IsRequired()
                    .HasColumnName("main_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MemGroupId)
                    .IsRequired()
                    .HasColumnName("mem_group_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MemberRef)
                    .IsRequired()
                    .HasColumnName("member_ref")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mobile1)
                    .IsRequired()
                    .HasColumnName("mobile1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OldMemberId)
                    .IsRequired()
                    .HasColumnName("old_member_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassportNo)
                    .IsRequired()
                    .HasColumnName("passport_no")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProgramId)
                    .IsRequired()
                    .HasColumnName("program_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RefproId)
                    .IsRequired()
                    .HasColumnName("refpro_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasColumnName("religion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.RenewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SharedFlag).HasColumnName("shared_flag");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.StaffFlag).HasColumnName("staff_flag");

                entity.Property(e => e.SubprogramId)
                    .HasColumnName("subprogram_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TempCard)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TitleId)
                    .IsRequired()
                    .HasColumnName("title_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasColumnName("tname")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MemberCard>(entity =>
            {
                entity.HasKey(e => new { e.CardTypeCode, e.MemberId, e.Runno })
                    .HasName("PK_df_cardhist");

                entity.HasIndex(e => e.CardTypeId)
                    .HasName("IX_df_cardhist_2");

                entity.HasIndex(e => e.EmbossId)
                    .HasName("IX_df_cardhist_Emboss_id")
                    .IsUnique();

                entity.HasIndex(e => e.MemberId)
                    .HasName("IX_df_cardhist_1");

                entity.HasIndex(e => e.ShoppingCard)
                    .HasName("IX_df_cardhist");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SMC')");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardStatus).HasColumnName("card_status");

                entity.Property(e => e.CardTypeId)
                    .IsRequired()
                    .HasColumnName("card_type_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmbossId)
                    .IsRequired()
                    .HasColumnName("emboss_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EmbossName)
                    .IsRequired()
                    .HasColumnName("emboss_name")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReasonId)
                    .IsRequired()
                    .HasColumnName("reason_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ValidTerm)
                    .HasColumnName("valid_term")
                    .HasDefaultValueSql("((24))");
            });

            modelBuilder.Entity<Memguest>(entity =>
            {
                entity.HasKey(e => e.MmId);

                entity.ToTable("memguest");

                entity.Property(e => e.MmId)
                    .HasColumnName("MM_id")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.EName)
                    .HasColumnName("E_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.EmbossId)
                    .HasColumnName("Emboss_id")
                    .HasMaxLength(255);

                entity.Property(e => e.IssuedNo)
                    .HasColumnName("Issued No")
                    .HasMaxLength(255);

                entity.Property(e => e.ProgId).HasColumnName("Prog_id");

                entity.Property(e => e.ShoppingCard).HasColumnName("Shopping Card");
            });

            modelBuilder.Entity<MhnPushOrderLog>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.RecNo })
                    .HasName("PK_MHN_PushOrderLog_1");

                entity.ToTable("MHN_PushOrderLog");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecNo).HasColumnName("rec_no");

                entity.Property(e => e.IsPush).HasColumnName("is_push");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PushDt)
                    .HasColumnName("push_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxabbNo)
                    .HasColumnName("taxabb_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<MstAgentstatus>(entity =>
            {
                entity.HasKey(e => e.AgentstatusCode);

                entity.ToTable("mst_agentstatus");

                entity.Property(e => e.AgentstatusCode)
                    .HasColumnName("agentstatus_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentstatusName)
                    .IsRequired()
                    .HasColumnName("agentstatus_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstCardType>(entity =>
            {
                entity.HasKey(e => e.CardTypeId);

                entity.ToTable("mst_card_type");

                entity.HasIndex(e => e.CardTypeCode)
                    .HasName("IX_mst_card_type")
                    .IsUnique();

                entity.HasIndex(e => new { e.CardGroupId, e.Discount })
                    .HasName("IX_mst_card_type_1");

                entity.Property(e => e.CardTypeId)
                    .HasColumnName("card_type_id")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardGroupId)
                    .IsRequired()
                    .HasColumnName("card_group_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CardTypeCode)
                    .IsRequired()
                    .HasColumnName("card_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasColumnName("discount")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnName("remark")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RequireRef).HasColumnName("require_ref");

                entity.Property(e => e.StartShopCard)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MstTableAttribute>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.Attribute });

                entity.ToTable("Mst_TableAttribute");

                entity.Property(e => e.TableName).HasMaxLength(20);

                entity.Property(e => e.Attribute).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Valuetype)
                    .HasColumnName("valuetype")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewBranchConfig>(entity =>
            {
                entity.HasKey(e => e.BranchNo)
                    .HasName("PK_NEW_BranchConfig");

                entity.ToTable("New_BranchConfig");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DatabaseName).HasMaxLength(50);

                entity.Property(e => e.IsCanceled)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsMainHanging)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OfflineHangingType).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RunningPrefix).HasMaxLength(10);

                entity.Property(e => e.ServerName).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<NewHanging>(entity =>
            {
                entity.HasKey(e => e.HangingKey)
                    .HasName("PK_New_Hanging_1");

                entity.ToTable("New_Hanging");

                entity.HasIndex(e => new { e.HangingHeaderKey, e.HangingNo })
                    .HasName("IX_New_Hanging_Main_Search")
                    .IsUnique();

                entity.Property(e => e.HangingDataKey)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HangingNo).HasMaxLength(10);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IsInTransit)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.HangingDataKeyNavigation)
                    .WithMany(p => p.NewHanging)
                    .HasForeignKey(d => d.HangingDataKey)
                    .HasConstraintName("FK_New_Hanging_New_HangingData");

                entity.HasOne(d => d.HangingHeaderKeyNavigation)
                    .WithMany(p => p.NewHanging)
                    .HasForeignKey(d => d.HangingHeaderKey)
                    .HasConstraintName("FK_New_Hanging_New_HangingHeader");
            });

            modelBuilder.Entity<NewHangingAllocateHist>(entity =>
            {
                entity.HasKey(e => e.HangingAllocateHistKey);

                entity.ToTable("New_HangingAllocateHist");

                entity.Property(e => e.CreatDt)
                    .HasColumnName("CreatDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingHeaderKeyNavigation)
                    .WithMany(p => p.NewHangingAllocateHist)
                    .HasForeignKey(d => d.HangingHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingAllocateHist_New_HangingHeader");
            });

            modelBuilder.Entity<NewHangingData>(entity =>
            {
                entity.HasKey(e => e.HangingDataKey);

                entity.ToTable("New_HangingData");

                entity.HasIndex(e => e.HangingDataRunning)
                    .HasName("IX_New_HangingData_HagingDataRunning")
                    .IsUnique();

                entity.HasIndex(e => e.HangingKey);

                entity.HasIndex(e => e.OpaqNo);

                entity.HasIndex(e => e.ShoppingCard);

                entity.HasIndex(e => new { e.OrderDate, e.CashierMac, e.TaxAbbNo })
                    .HasName("IX_New_HangingData");

                entity.HasIndex(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType })
                    .HasName("IX_New_HangingData_1");

                entity.HasIndex(e => new { e.OrderDate, e.FlightDt, e.RecToPickupDt, e.IssuedOpaqTfkey })
                    .HasName("IX_New_HangingData_FlightDT");

                entity.Property(e => e.HangingDataKey)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CashierMac)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.FlightCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDt)
                    .HasColumnName("FlightDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.HangingDataRunning).ValueGeneratedOnAdd();

                entity.Property(e => e.IssuedOpaqTfkey).HasColumnName("IssuedOpaqTFKey");

                entity.Property(e => e.OpaqNo)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecToPickupDt)
                    .HasColumnName("RecToPickupDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecToPickupUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.ShoppingCard)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SuborderType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAbbNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingKeyNavigation)
                    .WithMany(p => p.NewHangingData)
                    .HasForeignKey(d => d.HangingKey)
                    .HasConstraintName("FK_New_HangingData_New_Hanging");

                entity.HasOne(d => d.IssuedOpaqTfkeyNavigation)
                    .WithMany(p => p.NewHangingData)
                    .HasForeignKey(d => d.IssuedOpaqTfkey)
                    .HasConstraintName("FK_New_HangingData_New_OpaqTF");
            });

            modelBuilder.Entity<NewHangingHeader>(entity =>
            {
                entity.HasKey(e => e.HangingHeaderKey);

                entity.ToTable("New_HangingHeader");

                entity.HasIndex(e => new { e.HangingHeaderKey, e.PickupCode })
                    .HasName("IX_New_Hanging_HeaderKey_Pickup");

                entity.Property(e => e.HangingHeaderKey).ValueGeneratedNever();

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HangingTypeCode).HasMaxLength(10);

                entity.Property(e => e.IsCanceled)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PickupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.HangingTypeCodeNavigation)
                    .WithMany(p => p.NewHangingHeader)
                    .HasForeignKey(d => d.HangingTypeCode)
                    .HasConstraintName("FK_New_HangingRunNo_New_HangingType");
            });

            modelBuilder.Entity<NewHangingType>(entity =>
            {
                entity.HasKey(e => e.HangingTypeCode);

                entity.ToTable("New_HangingType");

                entity.Property(e => e.HangingTypeCode)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowTransferIn)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.HangingTypeName).HasMaxLength(50);

                entity.Property(e => e.IsCanceled)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SortOrder).HasMaxLength(10);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<NewHangingTypeCf>(entity =>
            {
                entity.HasKey(e => e.HangingTypeCfcode);

                entity.ToTable("New_HangingTypeCF");

                entity.Property(e => e.HangingTypeCfcode)
                    .HasColumnName("HangingTypeCFCode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.HangingTypeCfname)
                    .HasColumnName("HangingTypeCFName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NewHangingTypeHead>(entity =>
            {
                entity.HasKey(e => e.TypeGroupKey)
                    .HasName("PK_New_HangingType_Head");

                entity.ToTable("New_HangingTypeHead");

                entity.Property(e => e.GroupOper)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HangingTypeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.HangingTypeCodeNavigation)
                    .WithMany(p => p.NewHangingTypeHead)
                    .HasForeignKey(d => d.HangingTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingTypeHead_New_HangingType");
            });

            modelBuilder.Entity<NewHangingTypeItem>(entity =>
            {
                entity.HasKey(e => e.HangingTypeItemKey);

                entity.ToTable("New_HangingTypeItem");

                entity.HasIndex(e => e.HangingTypeCode)
                    .HasName("IX_New_HangingTypeItem");

                entity.Property(e => e.AddDateTime).HasColumnType("datetime");

                entity.Property(e => e.HangingTypeCfcode)
                    .IsRequired()
                    .HasColumnName("HangingTypeCFCode")
                    .HasMaxLength(10);

                entity.Property(e => e.HangingTypeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SearchCode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasMaxLength(10);

                entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingTypeCfcodeNavigation)
                    .WithMany(p => p.NewHangingTypeItem)
                    .HasForeignKey(d => d.HangingTypeCfcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingTypeItem_New_HangingTypeCF");

                entity.HasOne(d => d.HangingTypeCodeNavigation)
                    .WithMany(p => p.NewHangingTypeItem)
                    .HasForeignKey(d => d.HangingTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingTypeItem_New_HangingType");
            });

            modelBuilder.Entity<NewHangingTypeItems>(entity =>
            {
                entity.HasKey(e => e.ItemKey);

                entity.ToTable("New_HangingTypeItems");

                entity.Property(e => e.HangingTypeCfcode)
                    .IsRequired()
                    .HasColumnName("HangingTypeCFCode")
                    .HasMaxLength(10);

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SearchCode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingTypeCfcodeNavigation)
                    .WithMany(p => p.NewHangingTypeItems)
                    .HasForeignKey(d => d.HangingTypeCfcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingTypeItems_New_HangingTypeCF");

                entity.HasOne(d => d.OperationNavigation)
                    .WithMany(p => p.NewHangingTypeItems)
                    .HasForeignKey(d => d.Operation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingTypeItems_New_HangingTypeOper");

                entity.HasOne(d => d.TypeGroupKeyNavigation)
                    .WithMany(p => p.NewHangingTypeItems)
                    .HasForeignKey(d => d.TypeGroupKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_HangingTypeItems_New_HangingTypeHead");
            });

            modelBuilder.Entity<NewHangingTypeOper>(entity =>
            {
                entity.HasKey(e => e.OperationCode);

                entity.ToTable("New_HangingTypeOper");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.OperationName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NewOpaqTf>(entity =>
            {
                entity.HasKey(e => e.OpaqTfkey);

                entity.ToTable("New_OpaqTF");

                entity.HasIndex(e => e.HangingDataKey)
                    .HasName("IX_New_OpaqTF");

                entity.HasIndex(e => e.OpaqTfheaderKey)
                    .HasName("IX_New_OpaqTF_HeaderKey");

                entity.Property(e => e.OpaqTfkey).HasColumnName("OpaqTFKey");

                entity.Property(e => e.HangingDataKey)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpaqTfheaderKey).HasColumnName("OpaqTFHeaderKey");

                entity.Property(e => e.ReceiveDt)
                    .HasColumnName("ReceiveDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReceiveUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.FromHanginKeyNavigation)
                    .WithMany(p => p.NewOpaqTfFromHanginKeyNavigation)
                    .HasForeignKey(d => d.FromHanginKey)
                    .HasConstraintName("FK_New_OpaqTF_New_OpaqTF_FromHanging");

                entity.HasOne(d => d.HangingDataKeyNavigation)
                    .WithMany(p => p.NewOpaqTf)
                    .HasForeignKey(d => d.HangingDataKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_OpaqTF_New_HangingData");

                entity.HasOne(d => d.OpaqTfheaderKeyNavigation)
                    .WithMany(p => p.NewOpaqTf)
                    .HasForeignKey(d => d.OpaqTfheaderKey)
                    .HasConstraintName("FK_New_OpaqTF_New_OpaqTFHeader");

                entity.HasOne(d => d.ToHangingKeyNavigation)
                    .WithMany(p => p.NewOpaqTfToHangingKeyNavigation)
                    .HasForeignKey(d => d.ToHangingKey)
                    .HasConstraintName("FK_New_OpaqTF_New_OpaqTF_ToHanging");
            });

            modelBuilder.Entity<NewOpaqTfheader>(entity =>
            {
                entity.HasKey(e => e.OpaqTfheaderKey);

                entity.ToTable("New_OpaqTFHeader");

                entity.HasIndex(e => e.DocNo)
                    .HasName("IX_New_OpaqTFHeader_DocNo");

                entity.HasIndex(e => e.OpaqTftypeCode)
                    .HasName("IX_New_OpaqTFHeader");

                entity.HasIndex(e => e.TimeStamp);

                entity.Property(e => e.OpaqTfheaderKey)
                    .HasColumnName("OpaqTFHeaderKey")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNo)
                    .HasColumnName("DocNO")
                    .HasMaxLength(10);

                entity.Property(e => e.OpaqTftypeCode)
                    .IsRequired()
                    .HasColumnName("OpaqTFTypeCode")
                    .HasMaxLength(10);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.OpaqTftypeCodeNavigation)
                    .WithMany(p => p.NewOpaqTfheader)
                    .HasForeignKey(d => d.OpaqTftypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_OpaqTFHeader_New_OpaqTFType");
            });

            modelBuilder.Entity<NewOpaqTftype>(entity =>
            {
                entity.HasKey(e => e.OpaqTftypeCode);

                entity.ToTable("New_OpaqTFType");

                entity.Property(e => e.OpaqTftypeCode)
                    .HasColumnName("OpaqTFTypeCode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.OpaqTftypeName)
                    .HasColumnName("OpaqTFTypeName")
                    .HasMaxLength(50);

                entity.Property(e => e.SortOrder).HasMaxLength(10);

                entity.Property(e => e.TftypeGroupCode)
                    .IsRequired()
                    .HasColumnName("TFTypeGroupCode")
                    .HasMaxLength(10);

                entity.HasOne(d => d.TftypeGroupCodeNavigation)
                    .WithMany(p => p.NewOpaqTftype)
                    .HasForeignKey(d => d.TftypeGroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_New_OpaqTFType_New_TFTypeGroup");
            });

            modelBuilder.Entity<NewTftypeGroup>(entity =>
            {
                entity.HasKey(e => e.TftypeGroupCode);

                entity.ToTable("New_TFTypeGroup");

                entity.Property(e => e.TftypeGroupCode)
                    .HasColumnName("TFTypeGroupCode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.TftypeGroupName)
                    .HasColumnName("TFTypeGroupName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NewUpdateLog>(entity =>
            {
                entity.HasKey(e => e.UpdateLogKey);

                entity.ToTable("New_UpdateLog");

                entity.Property(e => e.CommandGroup).HasMaxLength(50);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ToBranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateCommand).HasColumnType("text");
            });

            modelBuilder.Entity<OpaqRefNo>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OpaqNo });

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10);

                entity.Property(e => e.OpaqNo)
                    .HasColumnName("opaq_no")
                    .HasMaxLength(10);

                entity.Property(e => e.RefNo)
                    .HasColumnName("ref_no")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaysessPaytran>(entity =>
            {
                entity.HasKey(e => e.TranId)
                    .HasName("PK_ps_paytran");

                entity.ToTable("paysess_paytran");

                entity.Property(e => e.TranId).HasColumnName("tran_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CashierNo)
                    .HasColumnName("cashier_no")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CurrentStatus).HasColumnName("current_status");

                entity.Property(e => e.GatewayBarcode)
                    .HasColumnName("gateway_barcode")
                    .HasMaxLength(150);

                entity.Property(e => e.GatewayBuyerId)
                    .HasColumnName("gateway_buyer_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GatewaySessionKey).HasColumnName("gateway_session_key");

                entity.Property(e => e.IpNo)
                    .HasColumnName("ip_no")
                    .HasMaxLength(50);

                entity.Property(e => e.LastStatus).HasColumnName("last_status");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineTaxNo)
                    .HasColumnName("machine_tax_no")
                    .HasMaxLength(50);

                entity.Property(e => e.MerchantId)
                    .HasColumnName("merchant_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedDatetime)
                    .HasColumnName("modified_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PartnerGroup).HasColumnName("partner_group");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.PartnerTransId)
                    .HasColumnName("partner_trans_id")
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerType)
                    .HasColumnName("partner_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PaylineNo).HasColumnName("payline_no");

                entity.Property(e => e.PaytranNo).HasColumnName("paytran_no");

                entity.Property(e => e.PrintSlip).HasColumnName("print_slip");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.TranGroup).HasColumnName("tran_group");

                entity.Property(e => e.TranType)
                    .HasColumnName("tran_type")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.PaysessPaytran)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ps_paytran_ps_session");
            });

            modelBuilder.Entity<PaysessPaytranMovement>(entity =>
            {
                entity.HasKey(e => e.TranMovementId)
                    .HasName("PK_ps_paytran_movement");

                entity.ToTable("paysess_paytran_movement");

                entity.Property(e => e.TranMovementId).HasColumnName("tran_movement_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CurrAmt)
                    .HasColumnName("curr_amt")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CurrCode)
                    .HasColumnName("curr_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TranId).HasColumnName("tran_id");

                entity.Property(e => e.TranMovementType).HasColumnName("tran_movement_type");

                entity.HasOne(d => d.Tran)
                    .WithMany(p => p.PaysessPaytranMovement)
                    .HasForeignKey(d => d.TranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ps_paytran_movement_ps_paytran");
            });

            modelBuilder.Entity<PaysessSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_ps_session");

                entity.ToTable("paysess_session");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CurrentStatus).HasColumnName("current_status");

                entity.Property(e => e.LastStatus).HasColumnName("last_status");

                entity.Property(e => e.ModifiedDatetime)
                    .HasColumnName("modified_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PaidGuid).HasColumnName("paid_guid");
            });

            modelBuilder.Entity<PaysessSessionMovement>(entity =>
            {
                entity.HasKey(e => e.MovementId)
                    .HasName("PK_ps_session_movement");

                entity.ToTable("paysess_session_movement");

                entity.Property(e => e.MovementId).HasColumnName("movement_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.PaysessSessionMovement)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ps_session_movement_ps_session");
            });

            modelBuilder.Entity<PkBoxDetail>(entity =>
            {
                entity.HasKey(e => e.BoxDetailKey);

                entity.ToTable("PK_BoxDetail");

                entity.HasIndex(e => new { e.BranchNo, e.SubSoHdrRecNo })
                    .HasName("IX_PK_BoxDetail");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledDt)
                    .HasColumnName("CanceledDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CanceledUserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.BoxHeaderKeyNavigation)
                    .WithMany(p => p.PkBoxDetail)
                    .HasForeignKey(d => d.BoxHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_BoxDetail_PK_BoxHeader");

                entity.HasOne(d => d.DfSubsohdr)
                    .WithMany(p => p.PkBoxDetail)
                    .HasPrincipalKey(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey(d => new { d.BranchNo, d.SubSoHdrRecNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_BoxDetail_df_subsohdr");
            });

            modelBuilder.Entity<PkBoxHeader>(entity =>
            {
                entity.HasKey(e => e.BoxHeaderKey);

                entity.ToTable("PK_BoxHeader");

                entity.HasIndex(e => new { e.BranchNo, e.BoxNo })
                    .HasName("IX_PK_BoxHeader");

                entity.Property(e => e.BoxNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledDt)
                    .HasColumnName("CanceledDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CanceledUserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDt)
                    .HasColumnName("PickupDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickupUserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<PkBranchConfig>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("PK_BranchConfig");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HangNoPrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PkHanging>(entity =>
            {
                entity.HasKey(e => e.HangingKey);

                entity.ToTable("PK_Hanging");

                entity.HasIndex(e => new { e.BranchNo, e.SubSohdrRecNo })
                    .HasName("IX_PK_Hanging");

                entity.HasIndex(e => new { e.HangingNo, e.HangingHeaderKey })
                    .HasName("IX_PK_Hanging_1")
                    .IsUnique();

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HangingNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.HangingHeaderKeyNavigation)
                    .WithMany(p => p.PkHanging)
                    .HasForeignKey(d => d.HangingHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_Hanging_PK_HangingHeader");

                entity.HasOne(d => d.DfSubsohdr)
                    .WithMany(p => p.PkHanging)
                    .HasPrincipalKey(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey(d => new { d.BranchNo, d.SubSohdrRecNo })
                    .HasConstraintName("FK_PK_Hanging_df_subsohdr");
            });

            modelBuilder.Entity<PkHangingAllocateHist>(entity =>
            {
                entity.HasKey(e => e.HangingAllocateHistKey);

                entity.ToTable("PK_HangingAllocateHist");

                entity.Property(e => e.CreatDt)
                    .HasColumnName("CreatDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingHeaderKeyNavigation)
                    .WithMany(p => p.PkHangingAllocateHist)
                    .HasForeignKey(d => d.HangingHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingAllocateHist_PK_HangingHeader");
            });

            modelBuilder.Entity<PkHangingHeader>(entity =>
            {
                entity.HasKey(e => e.HangingHeaderKey);

                entity.ToTable("PK_HangingHeader");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HangingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.HangingTypeCodeNavigation)
                    .WithMany(p => p.PkHangingHeader)
                    .HasForeignKey(d => d.HangingTypeCode)
                    .HasConstraintName("FK_PK_HangingHeader_PK_HangingType");
            });

            modelBuilder.Entity<PkHangingType>(entity =>
            {
                entity.HasKey(e => e.HangingTypeCode);

                entity.ToTable("PK_HangingType");

                entity.Property(e => e.HangingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.HangingTypeName).HasMaxLength(50);

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<PkHangingTypeCf>(entity =>
            {
                entity.HasKey(e => e.HangingTypeCfcode);

                entity.ToTable("PK_HangingTypeCF");

                entity.Property(e => e.HangingTypeCfcode)
                    .HasColumnName("HangingTypeCFCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.HangingTypeCfname)
                    .HasColumnName("HangingTypeCFName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PkHangingTypeHead>(entity =>
            {
                entity.HasKey(e => e.TypeGroupKey);

                entity.ToTable("PK_HangingTypeHead");

                entity.Property(e => e.GroupOper)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HangingTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingTypeCodeNavigation)
                    .WithMany(p => p.PkHangingTypeHead)
                    .HasForeignKey(d => d.HangingTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingTypeHead_PK_HangingType");
            });

            modelBuilder.Entity<PkHangingTypeItem>(entity =>
            {
                entity.HasKey(e => e.HangingTypeItemKey);

                entity.ToTable("PK_HangingTypeItem");

                entity.Property(e => e.AddDateTime).HasColumnType("datetime");

                entity.Property(e => e.HangingTypeCfcode)
                    .IsRequired()
                    .HasColumnName("HangingTypeCFCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HangingTypeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SearchCode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingTypeCfcodeNavigation)
                    .WithMany(p => p.PkHangingTypeItem)
                    .HasForeignKey(d => d.HangingTypeCfcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingTypeItem_PK_HangingTypeCF");

                entity.HasOne(d => d.HangingTypeCodeNavigation)
                    .WithMany(p => p.PkHangingTypeItem)
                    .HasForeignKey(d => d.HangingTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingTypeItem_PK_HangingType");
            });

            modelBuilder.Entity<PkHangingTypeItems>(entity =>
            {
                entity.HasKey(e => e.ItemKey);

                entity.ToTable("PK_HangingTypeItems");

                entity.Property(e => e.HangingTypeCfcode)
                    .IsRequired()
                    .HasColumnName("HangingTypeCFCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchCode)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.HasOne(d => d.HangingTypeCfcodeNavigation)
                    .WithMany(p => p.PkHangingTypeItems)
                    .HasForeignKey(d => d.HangingTypeCfcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingTypeItems_PK_HangingTypeCF");

                entity.HasOne(d => d.OperationNavigation)
                    .WithMany(p => p.PkHangingTypeItems)
                    .HasForeignKey(d => d.Operation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingTypeItems_PK_HangingTypeOper");

                entity.HasOne(d => d.TypeGroupKeyNavigation)
                    .WithMany(p => p.PkHangingTypeItems)
                    .HasForeignKey(d => d.TypeGroupKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_HangingTypeItems_PK_HangingTypeHead");
            });

            modelBuilder.Entity<PkHangingTypeOper>(entity =>
            {
                entity.HasKey(e => e.OperationCode);

                entity.ToTable("PK_HangingTypeOper");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.OperationName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PkPackingNo>(entity =>
            {
                entity.HasKey(e => e.PackingNo);

                entity.ToTable("PK_PackingNo");

                entity.HasIndex(e => e.CreateDt)
                    .HasName("IX_PK_PackingNo");

                entity.HasIndex(e => new { e.BranchNo, e.SubSohdrRecNo })
                    .HasName("IX_PK_PackingNo_SubSohdrRecNo");

                entity.Property(e => e.PackingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CancelDt)
                    .HasColumnName("CancelDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CancelToNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CancelToNoNavigation)
                    .WithMany(p => p.InverseCancelToNoNavigation)
                    .HasForeignKey(d => d.CancelToNo)
                    .HasConstraintName("FK_PK_PackingNo_PK_PackingNo");

                entity.HasOne(d => d.DfSubsohdr)
                    .WithMany(p => p.PkPackingNo)
                    .HasPrincipalKey(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey(d => new { d.BranchNo, d.SubSohdrRecNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_PackingNo_df_subsohdr");
            });

            modelBuilder.Entity<PkPackingRunner>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.SubSohdrRecNo });

                entity.ToTable("PK_PackingRunner");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DollyNo)
                    .HasColumnName("dolly_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromStaffCode)
                    .IsRequired()
                    .HasColumnName("from_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SortationFailDt)
                    .HasColumnName("SortationFailDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.SortationSendDt)
                    .HasColumnName("SortationSendDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.ToStaffCode)
                    .IsRequired()
                    .HasColumnName("to_staff_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.DfSubsohdr)
                    .WithOne(p => p.PkPackingRunner)
                    .HasPrincipalKey<DfSubsohdr>(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey<PkPackingRunner>(d => new { d.BranchNo, d.SubSohdrRecNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_PackingRunner_df_subsohdr");
            });

            modelBuilder.Entity<PkTaken>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.SubSohdrRecNo });

                entity.ToTable("PK_Taken");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDt)
                    .HasColumnName("FlightDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.DfSubsohdr)
                    .WithOne(p => p.PkTaken)
                    .HasPrincipalKey<DfSubsohdr>(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey<PkTaken>(d => new { d.BranchNo, d.SubSohdrRecNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_Taken_df_subsohdr");
            });

            modelBuilder.Entity<PkTbaq>(entity =>
            {
                entity.HasKey(e => e.TbaqNo);

                entity.ToTable("PK_TBaq");

                entity.Property(e => e.TbaqNo).HasColumnName("tbaq_no");

                entity.Property(e => e.HangingNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PackingNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PkTftypeGroup>(entity =>
            {
                entity.HasKey(e => e.TftypeGroupCode);

                entity.ToTable("PK_TFTypeGroup");

                entity.Property(e => e.TftypeGroupCode)
                    .HasColumnName("TFTypeGroupCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TftypeGroupName)
                    .HasColumnName("TFTypeGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PkTransfer>(entity =>
            {
                entity.HasKey(e => e.TransferKey);

                entity.ToTable("PK_Transfer");

                entity.HasIndex(e => new { e.BranchNo, e.SubSoHdrRecNo })
                    .HasName("IX_PK_Transfer");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDt)
                    .HasColumnName("ReceiveDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReceiveUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.FromHangingKeyNavigation)
                    .WithMany(p => p.PkTransferFromHangingKeyNavigation)
                    .HasForeignKey(d => d.FromHangingKey)
                    .HasConstraintName("FK_PK_Transfer_PK_Hanging");

                entity.HasOne(d => d.ToHangingKeyNavigation)
                    .WithMany(p => p.PkTransferToHangingKeyNavigation)
                    .HasForeignKey(d => d.ToHangingKey)
                    .HasConstraintName("FK_PK_Transfer_PK_Hanging1");

                entity.HasOne(d => d.TransferHeaderKeyNavigation)
                    .WithMany(p => p.PkTransfer)
                    .HasForeignKey(d => d.TransferHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_Transfer_PK_TransferHeader");

                entity.HasOne(d => d.DfSubsohdr)
                    .WithMany(p => p.PkTransfer)
                    .HasPrincipalKey(p => new { p.BranchNo, p.RecNo })
                    .HasForeignKey(d => new { d.BranchNo, d.SubSoHdrRecNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_Transfer_df_subsohdr");
            });

            modelBuilder.Entity<PkTransferHeader>(entity =>
            {
                entity.HasKey(e => e.TransferHeaderKey);

                entity.ToTable("PK_TransferHeader");

                entity.HasIndex(e => e.TftypeCode)
                    .HasName("IX_PK_TransferHeader");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TftypeCode)
                    .IsRequired()
                    .HasColumnName("TFTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.TftypeCodeNavigation)
                    .WithMany(p => p.PkTransferHeader)
                    .HasForeignKey(d => d.TftypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_TransferHeader_PK_TransferType");
            });

            modelBuilder.Entity<PkTransferType>(entity =>
            {
                entity.HasKey(e => e.TftypeCode);

                entity.ToTable("PK_TransferType");

                entity.Property(e => e.TftypeCode)
                    .HasColumnName("TFTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TftypeGroupCode)
                    .IsRequired()
                    .HasColumnName("TFTypeGroupCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TftypeName)
                    .IsRequired()
                    .HasColumnName("TFTypeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TftypeGroupCodeNavigation)
                    .WithMany(p => p.PkTransferType)
                    .HasForeignKey(d => d.TftypeGroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_TransferType_PK_TFTypeGroup");
            });

            modelBuilder.Entity<PkTripDetail>(entity =>
            {
                entity.HasKey(e => e.TripDetailKey);

                entity.ToTable("PK_TripDetail");

                entity.HasIndex(e => e.BoxHeaderKey)
                    .HasName("IX_PK_TripDetail");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.BoxHeaderKeyNavigation)
                    .WithMany(p => p.PkTripDetail)
                    .HasForeignKey(d => d.BoxHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_TripDetail_PK_BoxHeader");

                entity.HasOne(d => d.TripHeaderKeyNavigation)
                    .WithMany(p => p.PkTripDetail)
                    .HasForeignKey(d => d.TripHeaderKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK_TripDetail_PK_TripHeader");
            });

            modelBuilder.Entity<PkTripHeader>(entity =>
            {
                entity.HasKey(e => e.TripHeaderKey);

                entity.ToTable("PK_TripHeader");

                entity.HasIndex(e => new { e.BranchNo, e.TripHeaderKey })
                    .HasName("IX_PK_TripHeader");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.TruckNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreOrderChangeFlight>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo });

                entity.ToTable("PRE_OrderChangeFlight");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDt)
                    .HasColumnName("flight_dt")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("order_status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(400);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveOrderNo)
                    .IsRequired()
                    .HasColumnName("receive_order_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PackedDt)
                    .HasColumnName("packed_dt");

            });

            modelBuilder.Entity<PromoBranch>(entity =>
            {
                entity.HasKey(e => new { e.PromotionCode, e.BranchNo });

                entity.Property(e => e.PromotionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(400);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.PromotionCodeNavigation)
                    .WithMany(p => p.PromoBranch)
                    .HasForeignKey(d => d.PromotionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromoBranch_Promotion");
            });

            modelBuilder.Entity<PromoSubBranch>(entity =>
            {
                entity.HasKey(e => e.PromoSubBranchKey);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).HasMaxLength(400);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubBranchCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.PromotionCodeNavigation)
                    .WithMany(p => p.PromoSubBranch)
                    .HasForeignKey(d => d.PromotionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PromoSubBranch_Promotion");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => e.PromotionCode);

                entity.HasIndex(e => e.RecNo)
                    .HasName("Promotion_uq")
                    .IsUnique();

                entity.Property(e => e.PromotionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowOverwriteDisc).HasColumnName("AllowOverwriteDISC");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiscAmt).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.DiscRate).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IgnoreMaxDisc).HasColumnName("IgnoreMaxDISC");

                entity.Property(e => e.NotAllowSmc).HasColumnName("NotAllowSMC");

                entity.Property(e => e.PaymentCode).HasMaxLength(10);

                entity.Property(e => e.PromoMap)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RecNo).ValueGeneratedOnAdd();

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<PvHeader>(entity =>
            {
                entity.HasKey(e => e.PvHeaderKey);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasColumnName("bank_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateDoc)
                    .HasColumnName("certificate_doc")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CertificateWt)
                    .HasColumnName("certificate_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chequereceiver)
                    .IsRequired()
                    .HasColumnName("chequereceiver")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Commissiontypekey).HasColumnName("commissiontypekey");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DownloadDoc)
                    .HasColumnName("download_doc")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Expensetypekey).HasColumnName("expensetypekey");

                entity.Property(e => e.IssueDt)
                    .HasColumnName("IssueDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PeriodDt)
                    .HasColumnName("PeriodDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PrepareDt)
                    .HasColumnName("PrepareDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.TaxOrCardId)
                    .IsRequired()
                    .HasColumnName("TaxOrCardID")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PvHeaderLog>(entity =>
            {
                entity.HasKey(e => e.PvHeaderLogKey);

                entity.ToTable("PvHeader_Log");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChequeReceiver)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueDt)
                    .HasColumnName("IssueDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.TaxOrCardId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PvSummary>(entity =>
            {
                entity.HasKey(e => e.PvSummaryKey);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('03')");

                entity.Property(e => e.ExpenseType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Netpaid)
                    .HasColumnName("netpaid")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TastateHdrKey).HasColumnName("TAStateHdrKey");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Wt)
                    .HasColumnName("wt")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<PvTastatement>(entity =>
            {
                entity.HasKey(e => new { e.PvHeaderKey, e.TastateHdrKey, e.BranchNo });

                entity.ToTable("PV_TAStatement");

                entity.Property(e => e.TastateHdrKey).HasColumnName("TAStateHdrKey");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("Branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("Agent_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeReceiver)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pax).HasColumnName("pax");

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PeriodDt)
                    .HasColumnName("PeriodDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Saleamount)
                    .HasColumnName("saleamount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PvTrans>(entity =>
            {
                entity.HasKey(e => e.PvTransKey);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountTypeKeyNavigation)
                    .WithMany(p => p.PvTrans)
                    .HasForeignKey(d => d.AccountTypeKey)
                    .HasConstraintName("FK_PvTrans_AccountType");
            });

            modelBuilder.Entity<PvappvHist>(entity =>
            {
                entity.HasKey(e => e.PvappvHistKey);

                entity.ToTable("PVAppvHist");

                entity.Property(e => e.PvappvHistKey).HasColumnName("PVAppvHistKey");

                entity.Property(e => e.ActionBy)
                    .IsRequired()
                    .HasColumnName("Action_By")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActionDatetime)
                    .HasColumnName("Action_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PvheaderKey).HasColumnName("PVHeaderKey");
            });

            modelBuilder.Entity<PvchqHist>(entity =>
            {
                entity.HasKey(e => e.PvChqHistKey);

                entity.ToTable("PVChqHist");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BankRef)
                    .IsRequired()
                    .HasColumnName("Bank_Ref")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneName)
                    .IsRequired()
                    .HasColumnName("Bene_Name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChequeNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChqAmount)
                    .HasColumnName("Chq_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustRefBatch)
                    .IsRequired()
                    .HasColumnName("CustRef_Batch")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustRefDetail)
                    .IsRequired()
                    .HasColumnName("CustRef_Detail")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DebitAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryMode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.LastStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastUpdateStatus)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PickupDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PickupStatus)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PvHeaderKey).HasColumnName("pvHeaderKey");

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.S1refBatch)
                    .IsRequired()
                    .HasColumnName("S1Ref_Batch")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.WhtNo)
                    .IsRequired()
                    .HasColumnName("WHT_No")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Qrcode>(entity =>
            {
                entity.HasKey(e => e.Qrcode1);

                entity.ToTable("QRCode");

                entity.Property(e => e.Qrcode1)
                    .HasColumnName("QRCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EanCode)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RunningNo).ValueGeneratedOnAdd();

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<RemitDetail>(entity =>
            {
                entity.HasKey(e => e.RemitDetailKey);

                entity.HasIndex(e => new { e.RemitHeaderKey, e.RemitLineNo, e.ActualData })
                    .HasName("IX_RemitDetail")
                    .IsUnique();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AmountCurr).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.BankOfEdc)
                    .HasColumnName("BankOfEDC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrRate).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MethodGroup)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Qty).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.RemitHeaderKeyNavigation)
                    .WithMany(p => p.RemitDetail)
                    .HasForeignKey(d => d.RemitHeaderKey)
                    .HasConstraintName("FK_RemitDetail_RemitHeader");
            });

            modelBuilder.Entity<RemitHeader>(entity =>
            {
                entity.HasKey(e => e.RemitHeaderKey);

                entity.HasIndex(e => new { e.BranchNo, e.OrderDate, e.CashierCode })
                    .HasName("IX_RemitHeader");

                entity.Property(e => e.RemitHeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApproveUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CashierCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RemitHistory>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.OrderDate, e.CashierCode, e.RemitLineNo, e.UpdateDt })
                    .HasName("PK_RemitHistory_1");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CashierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AmountCurr).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.BankOfEdc)
                    .HasColumnName("BankOfEDC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CurrCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrRate).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MethodGroup)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Qty).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RemitIncentive>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.RateCode });

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RateCode)
                    .HasColumnName("rate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FromNo)
                    .HasColumnName("from_no")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.StaffLevel).HasColumnName("staff_level");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.ToNo)
                    .HasColumnName("to_no")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RemitShortOver>(entity =>
            {
                entity.HasKey(e => e.RemitHeaderKey);

                entity.Property(e => e.RemitHeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CashOver).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CashShort).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Diff).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.OverSystem).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.ShortSystem).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.RemitHeaderKeyNavigation)
                    .WithOne(p => p.RemitShortOver)
                    .HasForeignKey<RemitShortOver>(d => d.RemitHeaderKey)
                    .HasConstraintName("FK_RemitShortOver_RemitHeader");
            });

            modelBuilder.Entity<RewardDtl>(entity =>
            {
                entity.HasKey(e => e.DetailKey);

                entity.HasIndex(e => e.ArticleCode)
                    .HasName("IX_RewardDtl");

                entity.HasIndex(e => new { e.HeaderKey, e.ArticleCode })
                    .HasName("IX_RewardDtl_1")
                    .IsUnique();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Karat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.HeaderKeyNavigation)
                    .WithMany(p => p.RewardDtl)
                    .HasForeignKey(d => d.HeaderKey)
                    .HasConstraintName("FK_RewardDtl_RewardHdr");
            });

            modelBuilder.Entity<RewardHdr>(entity =>
            {
                entity.HasKey(e => e.HeaderKey);

                entity.HasIndex(e => e.EndDate)
                    .HasName("IX_EndDate");

                entity.HasIndex(e => e.StartDate)
                    .HasName("IX_StartDate");

                entity.Property(e => e.HeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PromoCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RunNoRefundNoPur>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.Plant, e.PickUpCode });

                entity.ToTable("RunNo_Refund_NoPur");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpCode).HasMaxLength(10);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<Runno50bis>(entity =>
            {
                entity.HasKey(e => e.BisYear);

                entity.ToTable("runno_50bis");

                entity.Property(e => e.BisYear)
                    .HasColumnName("bis_year")
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoBox>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_box");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoCertificate>(entity =>
            {
                entity.HasKey(e => new { e.Yearmonth, e.Isperson });

                entity.ToTable("runno_certificate");

                entity.Property(e => e.Yearmonth)
                    .HasColumnName("yearmonth")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Isperson)
                    .HasColumnName("isperson")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoComm>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_comm");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoFrn>(entity =>
            {
                entity.HasKey(e => new { e.AirlineCode, e.FlightCode, e.FlightDate });

                entity.ToTable("runno_FRN");

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate)
                    .HasColumnName("flight_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Frn)
                    .HasColumnName("FRN")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RunnoInshop>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_inshop");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno)
                    .HasColumnName("runno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoInv>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_inv");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoMachine>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.MachineNo });

                entity.ToTable("runno_machine");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reciept).HasColumnName("reciept");

                entity.Property(e => e.Taxabb).HasColumnName("taxabb");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoNoshow>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.Code });

                entity.ToTable("runno_noshow");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Runno)
                    .HasColumnName("runno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoOpaq>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_opaq");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoPutrans>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_putrans");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoRefund>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.PickupCode });

                entity.ToTable("runno_refund");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoRefundGrp>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.Plant, e.PickupCode });

                entity.ToTable("runno_refund_grp");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCode)
                    .HasColumnName("pickup_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasColumnName("prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoSmc>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_smc");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoSpending>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_spending");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno)
                    .HasColumnName("runno")
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoTbag>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_tbag");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoTouragent>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_touragent");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoTourhdr>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_tourhdr");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoTrip>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_trip");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Runno)
                    .HasColumnName("runno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoWt>(entity =>
            {
                entity.HasKey(e => e.BranchNo);

                entity.ToTable("runno_wt");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<RunnoXHanging>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.Code });

                entity.ToTable("runno_x_hanging");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheckChange)
                    .IsRequired()
                    .HasColumnName("check_change")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Runno)
                    .HasColumnName("runno")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<ScoLog>(entity =>
            {
                entity.HasKey(e => e.LogKey)
                    .HasName("PK_sco_log_1");

                entity.ToTable("sco_log");

                entity.Property(e => e.LogKey).HasColumnName("log_key");

                entity.Property(e => e.LogBy)
                    .HasColumnName("log_by")
                    .HasMaxLength(10);

                entity.Property(e => e.LogDt)
                    .HasColumnName("log_dt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("status_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.ScoLog)
                    .HasForeignKey(d => d.StatusCode)
                    .HasConstraintName("FK_sco_log_sco_status");
            });

            modelBuilder.Entity<ScoPaymeth>(entity =>
            {
                entity.HasKey(e => e.MethodCode);

                entity.ToTable("sco_paymeth");

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsCancel).HasColumnName("is_cancel");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MethodCodeNavigation)
                    .WithOne(p => p.ScoPaymeth)
                    .HasForeignKey<ScoPaymeth>(d => d.MethodCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sco_paymeth_df_paymeth");
            });

            modelBuilder.Entity<ScoSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("PK_br_session");

                entity.ToTable("sco_session");

                entity.Property(e => e.SessionKey).HasColumnName("session_key");

                entity.Property(e => e.IsCancel)
                    .HasColumnName("is_cancel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastLogKey).HasColumnName("last_log_key");

                entity.Property(e => e.MachineNo)
                    .IsRequired()
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LastLogKeyNavigation)
                    .WithMany(p => p.ScoSession)
                    .HasForeignKey(d => d.LastLogKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sco_session_sco_log");
            });

            modelBuilder.Entity<ScoSessionDetail>(entity =>
            {
                entity.HasKey(e => e.SessionDetailKey)
                    .HasName("PK_br_session_detail");

                entity.ToTable("sco_session_detail");

                entity.Property(e => e.SessionDetailKey).HasColumnName("session_detail_key");

                entity.Property(e => e.CreateDt)
                    .HasColumnName("create_dt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsCancel)
                    .HasColumnName("is_cancel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SessionKey).HasColumnName("session_key");

                entity.Property(e => e.ShoppingCard)
                    .IsRequired()
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SessionKeyNavigation)
                    .WithMany(p => p.ScoSessionDetail)
                    .HasForeignKey(d => d.SessionKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_br_session_detail_br_session");
            });

            modelBuilder.Entity<ScoStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.ToTable("sco_status");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("status_code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .HasColumnName("status_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<SessionDetail>(entity =>
            {
                entity.HasKey(e => e.SessionDetailKey);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.MachineCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpaqNo)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCheck)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SessionHeader>(entity =>
            {
                entity.HasKey(e => e.SessionKey);

                entity.Property(e => e.SessionKey).ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.PickupCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SessionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmcBirthday>(entity =>
            {
                entity.HasKey(e => e.BdCode);

                entity.ToTable("SMC_Birthday");

                entity.Property(e => e.BdCode)
                    .HasColumnName("bd_code")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BdDesc)
                    .HasColumnName("bd_desc")
                    .HasMaxLength(50);

                entity.Property(e => e.BdRate)
                    .HasColumnName("bd_rate")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RqBdCode)
                    .HasColumnName("rq_bd_code")
                    .HasMaxLength(3);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(10);

                entity.Property(e => e.ValueCode)
                    .HasColumnName("value_code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SmcCardActive>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK_SMC_card_cancel");

                entity.ToTable("SMC_card_active");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.SmcRun).HasColumnName("smc_run");
            });

            modelBuilder.Entity<SmcCoupon>(entity =>
            {
                entity.HasKey(e => e.CouponKey);

                entity.ToTable("SMC_Coupon");

                entity.HasIndex(e => e.HeaderKey);

                entity.Property(e => e.CouponKey).ValueGeneratedNever();

                entity.Property(e => e.CouponCode).HasMaxLength(50);

                entity.Property(e => e.CouponStatus).HasMaxLength(10);

                entity.Property(e => e.CouponType).HasMaxLength(10);

                entity.Property(e => e.Expiredate).HasColumnType("smalldatetime");

                entity.Property(e => e.IssueCode).HasMaxLength(10);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Validdate).HasColumnType("smalldatetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SmcHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderKey);

                entity.ToTable("SMC_header");

                entity.HasIndex(e => e.KeySearch);

                entity.HasIndex(e => new { e.MemberId, e.HeaderKey })
                    .HasName("IX_SMC_header_MemberID_HeaderKey");

                entity.Property(e => e.HeaderKey).ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BalanceAccAmt)
                    .HasColumnName("balance_acc_amt")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BalanceAccPoint)
                    .HasColumnName("balance_acc_point")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BalanceEPurse)
                    .HasColumnName("balance_e_purse")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(50);

                entity.Property(e => e.CancelToDate)
                    .HasColumnName("cancel_to_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CancelToDoc).HasColumnName("cancel_to_doc");

                entity.Property(e => e.CheckPoint)
                    .HasColumnName("check_point")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CurAccAmt)
                    .HasColumnName("cur_acc_amt")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CurAccPoint)
                    .HasColumnName("cur_acc_point")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CurEPurse)
                    .HasColumnName("cur_e_purse")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DocDate)
                    .HasColumnName("doc_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DocNo).HasColumnName("doc_no");

                entity.Property(e => e.EmbossId)
                    .HasColumnName("emboss_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(50);

                entity.Property(e => e.IssuedOrder).HasColumnName("issued_order");

                entity.Property(e => e.KeySearch)
                    .HasColumnName("key_search")
                    .HasMaxLength(50);

                entity.Property(e => e.LocCode)
                    .HasColumnName("loc_code")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleCode)
                    .HasColumnName("module_code")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ProcessAccAmt)
                    .HasColumnName("process_acc_amt")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessAccPoint)
                    .HasColumnName("process_acc_point")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessEPurse)
                    .HasColumnName("process_e_purse")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SaleDate)
                    .HasColumnName("sale_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SaleDoc)
                    .HasColumnName("sale_doc")
                    .HasMaxLength(50);

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(50);

                entity.Property(e => e.SlipText)
                    .HasColumnName("slip_text")
                    .HasColumnType("text");

                entity.Property(e => e.SmcId)
                    .HasColumnName("smc_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SmcLocked>(entity =>
            {
                entity.HasKey(e => e.LockId);

                entity.ToTable("SMC_Locked");

                entity.Property(e => e.LockId)
                    .HasColumnName("LockID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LockCode).HasMaxLength(10);

                entity.Property(e => e.LockMessage).HasMaxLength(100);

                entity.Property(e => e.LockName).HasMaxLength(50);
            });

            modelBuilder.Entity<SmcMovementType>(entity =>
            {
                entity.HasKey(e => e.MvtCode);

                entity.ToTable("SMC_Movement_Type");

                entity.Property(e => e.MvtCode)
                    .HasColumnName("mvt_code")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InOutAcc).HasDefaultValueSql("(0)");

                entity.Property(e => e.InOutEpurse).HasDefaultValueSql("(0)");

                entity.Property(e => e.InOutPoint).HasDefaultValueSql("(0)");

                entity.Property(e => e.MvtName)
                    .IsRequired()
                    .HasColumnName("mvt_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SmcPaymethNopoint>(entity =>
            {
                entity.HasKey(e => e.MethodCode);

                entity.ToTable("SMC_paymeth_nopoint");

                entity.Property(e => e.MethodCode)
                    .HasColumnName("method_code")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SmcTrans>(entity =>
            {
                entity.HasKey(e => e.TransKey);

                entity.ToTable("SMC_trans");

                entity.HasIndex(e => e.HeaderKey);

                entity.Property(e => e.BahtPerPoint)
                    .HasColumnName("baht_per_point")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BalanceValue)
                    .HasColumnName("balance_value")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CurValue)
                    .HasColumnName("cur_value")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DocDate)
                    .HasColumnName("doc_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DocNo).HasColumnName("doc_no");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("exp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormatVersion)
                    .HasColumnName("format_version")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.MvtCode)
                    .HasColumnName("mvt_code")
                    .HasMaxLength(50);

                entity.Property(e => e.PointPerBaht)
                    .HasColumnName("point_per_baht")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessValue)
                    .HasColumnName("process_value")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordNo).HasColumnName("record_no");

                entity.Property(e => e.ReverseFlag)
                    .IsRequired()
                    .HasColumnName("reverse_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.ValidDate)
                    .HasColumnName("valid_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValueCode)
                    .HasColumnName("value_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ValueType).HasColumnName("value_type");
            });

            modelBuilder.Entity<SmcUpcardCond>(entity =>
            {
                entity.HasKey(e => new { e.BaseCardTypeCode, e.UpgradeCardTypeCode });

                entity.ToTable("SMC_upcard_cond");

                entity.Property(e => e.BaseCardTypeCode)
                    .HasColumnName("base_card_type_code")
                    .HasMaxLength(10);

                entity.Property(e => e.UpgradeCardTypeCode)
                    .HasColumnName("upgrade_card_type_code")
                    .HasMaxLength(10);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelFlag)
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountCode)
                    .HasColumnName("discount_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Netsales)
                    .HasColumnName("netsales")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasMaxLength(8);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SmcUpgrade>(entity =>
            {
                entity.HasKey(e => e.UpgradeKey);

                entity.ToTable("SMC_upgrade");

                entity.HasIndex(e => e.HeaderKey);

                entity.Property(e => e.DocDate)
                    .HasColumnName("doc_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DocNo).HasColumnName("doc_no");

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.NewCardTypeCode)
                    .HasColumnName("new_card_type_code")
                    .HasMaxLength(10);

                entity.Property(e => e.NewDiscount)
                    .HasColumnName("new_discount")
                    .HasMaxLength(10);

                entity.Property(e => e.OldCardTypeCode)
                    .HasColumnName("old_card_type_code")
                    .HasMaxLength(10);

                entity.Property(e => e.OldDiscount)
                    .HasColumnName("old_discount")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SmcValue>(entity =>
            {
                entity.HasKey(e => e.ValueKey);

                entity.ToTable("SMC_value");

                entity.HasIndex(e => e.HeaderKey);

                entity.Property(e => e.BalanceValue)
                    .HasColumnName("balance_value")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DocDate)
                    .HasColumnName("doc_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DocNo).HasColumnName("doc_no");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("exp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormatVersion)
                    .HasColumnName("format_version")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("member_id")
                    .HasMaxLength(50);

                entity.Property(e => e.RecordNo).HasColumnName("record_no");

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.ValidDate)
                    .HasColumnName("valid_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValueCode)
                    .HasColumnName("value_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ValueType).HasColumnName("value_type");
            });

            modelBuilder.Entity<SmcValueCode>(entity =>
            {
                entity.HasKey(e => e.ValueCode);

                entity.ToTable("SMC_Value_code");

                entity.Property(e => e.ValueCode)
                    .HasColumnName("value_code")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AllowBranch)
                    .HasColumnName("allow_branch")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsCorporate)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserAdd)
                    .HasColumnName("user_add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasMaxLength(10);

                entity.Property(e => e.ValueDesc)
                    .HasColumnName("value_desc")
                    .HasMaxLength(100);

                entity.Property(e => e.ValueShort)
                    .HasColumnName("value_short")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SmcValueType>(entity =>
            {
                entity.HasKey(e => e.ValueType);

                entity.ToTable("SMC_value_type");

                entity.Property(e => e.ValueType)
                    .HasColumnName("value_type")
                    .ValueGeneratedNever();

                entity.Property(e => e.ValueTypeDesc)
                    .HasColumnName("value_type_desc")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SolByMacCate>(entity =>
            {
                entity.HasKey(e => new { e.SaleDate, e.LocCode, e.MachineNo, e.CateCode });

                entity.ToTable("SOL_ByMacCate");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('03')");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SolByType>(entity =>
            {
                entity.HasKey(e => new { e.TypeCode, e.SaleDate, e.LocCode, e.MachineNo, e.Key1, e.Key2, e.Key3, e.Key4 })
                    .HasName("PK_SOL_ByType_1");

                entity.ToTable("SOL_ByType");

                entity.HasIndex(e => new { e.TypeCode, e.SaleDate, e.Key1, e.Key2, e.Key3, e.Key4 })
                    .HasName("IX_SOL_ByType_1");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Key1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Key2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Key3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Key4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SolTarget>(entity =>
            {
                entity.HasKey(e => new { e.SaleDate, e.LocCode, e.CateCode });

                entity.ToTable("SOL_Target");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('03')");

                entity.Property(e => e.TargetAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SurrogateKey>(entity =>
            {
                entity.HasKey(e => e.GroupName);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.SurrogateKey1)
                    .HasColumnName("SurrogateKey")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TaCondition>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.AgentCode, e.GroupFlag, e.CountryCode, e.CateCode, e.BrandCode, e.FlightGroup, e.PaidType, e.CheckFrom, e.Range1, e.Range2 })
                    .HasName("PK_ta_comm_condition");

                entity.ToTable("ta_condition");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupFlag)
                    .HasColumnName("group_flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.CateCode)
                    .HasColumnName("cate_code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.BrandCode)
                    .HasColumnName("brand_code")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.FlightGroup)
                    .HasColumnName("flight_group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaidType).HasColumnName("paid_type");

                entity.Property(e => e.CheckFrom).HasColumnName("check_from");

                entity.Property(e => e.Range1)
                    .HasColumnName("range1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Range2)
                    .HasColumnName("range2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CalcType)
                    .HasColumnName("calc_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Ispercent)
                    .HasColumnName("ispercent")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaSaleTour>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.Catecode, e.Brandcode });

                entity.ToTable("TA_SaleTour");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Brandcode)
                    .HasColumnName("brandcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.CustTypeCode)
                    .IsRequired()
                    .HasColumnName("cust_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.FlightCode)
                    .IsRequired()
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Netsale)
                    .HasColumnName("netsale")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Payment)
                    .HasColumnName("payment")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ValueCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValueType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TacarRegDtl>(entity =>
            {
                entity.HasKey(e => e.TacarRegDtlKey);

                entity.ToTable("TACarRegDtl");

                entity.HasIndex(e => e.TourCode)
                    .HasName("IX_TACarRegDtl");

                entity.Property(e => e.TacarRegDtlKey).HasColumnName("TACarRegDtlKey");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("Add_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CarLicense)
                    .IsRequired()
                    .HasColumnName("Car_License")
                    .HasMaxLength(20);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("Del_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FeeType)
                    .IsRequired()
                    .HasColumnName("Fee_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ShwLicense)
                    .IsRequired()
                    .HasColumnName("Shw_License")
                    .HasMaxLength(20);

                entity.Property(e => e.TacarRegHdrKey).HasColumnName("TACarRegHdrKey");

                entity.Property(e => e.TourCode)
                    .IsRequired()
                    .HasColumnName("Tour_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TacarRegHdr>(entity =>
            {
                entity.HasKey(e => e.TacarRegHdrKey);

                entity.ToTable("TACarRegHdr");

                entity.HasIndex(e => new { e.TacarRegHdrKey, e.BranchNo, e.AgentCode })
                    .HasName("IX_TACarRegHdr");

                entity.Property(e => e.TacarRegHdrKey).HasColumnName("TACarRegHdrKey");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("Add_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("Agent_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('03')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("Del_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.PeriodDt)
                    .HasColumnName("PeriodDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.TastateHdrKey)
                    .HasColumnName("TAStateHdrKey")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TastateDtl>(entity =>
            {
                entity.HasKey(e => e.TastateDtlKey)
                    .HasName("PK_TrStateDtl");

                entity.ToTable("TAStateDtl");

                entity.Property(e => e.TastateDtlKey).HasColumnName("TAStateDtlKey");

                entity.Property(e => e.AccountCode)
                    .HasColumnName("Account_Code")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddDateTime)
                    .HasColumnName("Add_DateTime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BrandCode)
                    .HasColumnName("Brand_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CalcType).HasColumnName("Calc_Type");

                entity.Property(e => e.CateCode)
                    .HasColumnName("Cate_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CheckFrom).HasColumnName("Check_From");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("Country_Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("Del_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupFlag).HasColumnName("Group_Flag");

                entity.Property(e => e.Range1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Range2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaleAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyAmount)
                    .HasColumnName("Sy_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SySaleAmount)
                    .HasColumnName("Sy_SaleAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TastateHdrKey).HasColumnName("TAStateHdrKey");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.TrCondAmt)
                    .HasColumnName("TrCond_Amt")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TastateHdr>(entity =>
            {
                entity.HasKey(e => e.TastateHdrKey);

                entity.ToTable("TAStateHdr");

                entity.Property(e => e.TastateHdrKey).HasColumnName("TAStateHdrKey");

                entity.Property(e => e.AddDateTime)
                    .HasColumnName("Add_DateTime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address3)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("Agent_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("Branch_No")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChequeReceiver)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("Del_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.PaidAmount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pax).HasDefaultValueSql("((0))");

                entity.Property(e => e.Perhead)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PeriodDt)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PrintPv)
                    .IsRequired()
                    .HasColumnName("PrintPV")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RefTrPayHdr)
                    .HasColumnName("Ref_TrPayHdr")
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaleAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyCommission)
                    .HasColumnName("Sy_Commission")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyPax).HasColumnName("Sy_Pax");

                entity.Property(e => e.SyPerHead)
                    .HasColumnName("Sy_PerHead")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SySaleAmount)
                    .HasColumnName("Sy_SaleAmount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SyTransport)
                    .HasColumnName("Sy_Transport")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TastateType)
                    .IsRequired()
                    .HasColumnName("TAState_Type")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxOrCardId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.Transport)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("Update_DateTime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TastateHdrAttr>(entity =>
            {
                entity.ToTable("TAStateHdr_Attr");

                entity.Property(e => e.TaStateHdrAttrId).HasColumnName("TaStateHdrAttrID");

                entity.Property(e => e.Attribute)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("Branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValueString).HasMaxLength(400);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TastatePax>(entity =>
            {
                entity.HasKey(e => e.TastatePaxKey);

                entity.ToTable("TAStatePax");

                entity.Property(e => e.TastatePaxKey).HasColumnName("TAStatePaxKey");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("Add_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasColumnName("Brand_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .IsRequired()
                    .HasColumnName("Cate_Code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CheckFrom).HasColumnName("Check_From");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("Country_Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("Del_Flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupFlag).HasColumnName("Group_Flag");

                entity.Property(e => e.Perhead).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Range1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Range2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SyPax).HasColumnName("Sy_Pax");

                entity.Property(e => e.SyPerhead)
                    .HasColumnName("Sy_Perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TastateHdrKey).HasColumnName("TAStateHdrKey");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.TrCondAmt)
                    .HasColumnName("TrCond_Amt")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbgConfig>(entity =>
            {
                entity.HasKey(e => e.TbgconfigCode);

                entity.ToTable("TBG_Config");

                entity.Property(e => e.TbgconfigCode)
                    .HasColumnName("TBGConfigCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TbgconfigName)
                    .IsRequired()
                    .HasColumnName("TBGConfigName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbgMachine>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.MachineNo });

                entity.ToTable("TBG_Machine");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TbgconfigCode)
                    .IsRequired()
                    .HasColumnName("TBGConfigCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.TbgconfigCodeNavigation)
                    .WithMany(p => p.TbgMachine)
                    .HasForeignKey(d => d.TbgconfigCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBG_Machine_TBG_Config");
            });

            modelBuilder.Entity<TbgRunNo>(entity =>
            {
                entity.HasKey(e => new { e.TbgconfigCode, e.OrderDate });

                entity.ToTable("TBG_RunNo");

                entity.Property(e => e.TbgconfigCode)
                    .HasColumnName("TBGConfigCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TbgTrans>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.ShoppingCard, e.OrderNo, e.SuborderType, e.TbagNo });

                entity.ToTable("TBG_Trans");

                entity.HasIndex(e => e.TbagNo)
                    .HasName("IX_TBG_Trans");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.SuborderType)
                    .HasColumnName("suborder_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TbagNo)
                    .HasColumnName("tbag_no")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TbgconfigCode)
                    .IsRequired()
                    .HasColumnName("TBGConfigCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TbgorderNo).HasColumnName("TBGOrderNo");

                entity.Property(e => e.TbgrunNo).HasColumnName("TBGRunNo");
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.HasKey(e => e.Running);

                entity.ToTable("tbl_log");

                entity.Property(e => e.Running)
                    .HasColumnName("running")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCode)
                    .HasColumnName("messageCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NameFunction)
                    .HasColumnName("nameFunction")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.ShoppingCard)
                    .HasColumnName("shopping_card")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SourcePlatform)
                    .HasColumnName("sourcePlatform")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUi>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TrCode });

                entity.ToTable("tblUI");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.TrCode)
                    .HasColumnName("tr_code")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DebugErrMsg)
                    .IsRequired()
                    .HasColumnName("debug_err_msg")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasColumnName("form_name")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Secure)
                    .HasColumnName("secure")
                    .HasMaxLength(50);

                entity.Property(e => e.TableCode)
                    .HasColumnName("table_code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TableCodeFlag)
                    .HasColumnName("table_code_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserProcess)
                    .IsRequired()
                    .HasColumnName("user_process")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TcPayDtl>(entity =>
            {
                entity.HasKey(e => new { e.DocNo, e.BranchNo, e.TourCode });

                entity.ToTable("TC_PayDtl");

                entity.HasIndex(e => e.TourDate)
                    .HasName("IX_TC_PayDtl_1");

                entity.HasIndex(e => new { e.BranchNo, e.TourCode })
                    .HasName("IX_TC_PayDtl");

                entity.Property(e => e.DocNo)
                    .HasColumnName("Doc_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Customer).HasColumnName("customer");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Netsale)
                    .HasColumnName("netsale")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pax).HasColumnName("pax");

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.TourDate)
                    .HasColumnName("tour_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TcPayHdr>(entity =>
            {
                entity.HasKey(e => e.DocNo);

                entity.ToTable("TC_PayHdr");

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.Pax).HasColumnName("pax");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrintFlag).HasColumnName("Print_Flag");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubagentCode)
                    .IsRequired()
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TempMachine>(entity =>
            {
                entity.HasKey(e => e.MachineNo);

                entity.ToTable("Temp_Machine");

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TourservicesLog>(entity =>
            {
                entity.HasKey(e => e.LogKey);

                entity.ToTable("Tourservices_Log");

                entity.Property(e => e.LogKey).HasColumnName("log_key");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .IsRequired()
                    .HasColumnName("doc_group")
                    .HasMaxLength(10);

                entity.Property(e => e.ErrMessage)
                    .IsRequired()
                    .HasColumnName("err_message")
                    .HasMaxLength(100);

                entity.Property(e => e.Grouptype)
                    .IsRequired()
                    .HasColumnName("grouptype")
                    .HasMaxLength(20);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("ip_address")
                    .HasMaxLength(20);

                entity.Property(e => e.LogDate)
                    .HasColumnName("log_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TrCommPerHead>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.RateCode });

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RateCode)
                    .HasColumnName("rate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FromNo)
                    .HasColumnName("from_no")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.ToNo)
                    .HasColumnName("to_no")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TrCondition>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.AgentCode, e.GroupFlag, e.CountryCode, e.CateCode, e.BrandCode, e.FlightGroup, e.PaidType, e.CheckFrom, e.Range1, e.Range2 })
                    .HasName("PK_tr_comm_condition");

                entity.ToTable("tr_condition");

                entity.HasIndex(e => e.AgentCode)
                    .HasName("IX_tr_comm_condition");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupFlag)
                    .HasColumnName("group_flag")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.CateCode)
                    .HasColumnName("cate_code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.BrandCode)
                    .HasColumnName("brand_code")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.FlightGroup)
                    .HasColumnName("flight_group")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.PaidType).HasColumnName("paid_type");

                entity.Property(e => e.CheckFrom).HasColumnName("check_from");

                entity.Property(e => e.Range1)
                    .HasColumnName("range1")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Range2)
                    .HasColumnName("range2")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CalcType)
                    .HasColumnName("calc_type")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.SaleformBranch)
                    .HasColumnName("saleform_branch")
                    .HasMaxLength(30);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrConditionLog>(entity =>
            {
                entity.HasKey(e => e.LogKey);

                entity.ToTable("tr_condition_log");

                entity.Property(e => e.LogKey).HasColumnName("log_key");

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasColumnName("brand_code")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.CalcType)
                    .HasColumnName("calc_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CateCode)
                    .IsRequired()
                    .HasColumnName("cate_code")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.CheckFrom).HasColumnName("check_from");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("create default [blank] as ' '");

                entity.Property(e => e.FlightGroup)
                    .HasColumnName("flight_group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupFlag)
                    .HasColumnName("group_flag")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LogBy)
                    .IsRequired()
                    .HasColumnName("log_by")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogDate)
                    .HasColumnName("log_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PaidType).HasColumnName("paid_type");

                entity.Property(e => e.Range1)
                    .HasColumnName("range1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Range2)
                    .HasColumnName("range2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SpendingPerPaxByAgent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpendingPerPaxByTour).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrCustType>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CustTypeCode })
                    .HasName("PK_ma_cust_type");

                entity.ToTable("tr_cust_type");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.CustTypeCode)
                    .HasColumnName("cust_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountAmount)
                    .IsRequired()
                    .HasColumnName("count_amount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CountPax)
                    .IsRequired()
                    .HasColumnName("count_pax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CustTypeDesc)
                    .IsRequired()
                    .HasColumnName("cust_type_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlagAmtAll)
                    .IsRequired()
                    .HasColumnName("flag_amt_all")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<TrHead>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.TourCode, e.CountryCode, e.AirlineCode, e.FlightCode });

                entity.ToTable("tr_head");

                entity.HasIndex(e => new { e.BranchNo, e.AgentCode })
                    .HasName("IX_tr_head");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AgentComm)
                    .HasColumnName("agent_comm")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AgentHead)
                    .HasColumnName("agent_head")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlightGroup)
                    .IsRequired()
                    .HasColumnName("flight_group")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.GuideComm)
                    .HasColumnName("guide_comm")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GuideHead)
                    .HasColumnName("guide_head")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GuidePost)
                    .IsRequired()
                    .HasColumnName("guide_post")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.GuidePrepost)
                    .IsRequired()
                    .HasColumnName("guide_prepost")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Netsales)
                    .HasColumnName("netsales")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Pax)
                    .HasColumnName("pax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PostFlag)
                    .IsRequired()
                    .HasColumnName("post_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrepostFlag)
                    .IsRequired()
                    .HasColumnName("prepost_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SubagentCode)
                    .IsRequired()
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrMarket>(entity =>
            {
                entity.HasKey(e => e.TrMarketKey);

                entity.ToTable("Tr_Market");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasColumnName("brand_code")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CalcType)
                    .HasColumnName("calc_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CateCode)
                    .IsRequired()
                    .HasColumnName("cate_code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CommPerhead)
                    .HasColumnName("comm_perhead")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .IsRequired()
                    .HasColumnName("doc_group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("doc_no")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DtPeriod)
                    .HasColumnName("dtPeriod")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.FlightGroup)
                    .HasColumnName("flight_group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupFlag).HasColumnName("group_flag");

                entity.Property(e => e.PaidType)
                    .HasColumnName("paid_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Range1)
                    .HasColumnName("range1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Range2)
                    .HasColumnName("range2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalePax)
                    .HasColumnName("sale_pax")
                    .HasColumnType("decimal(15, 2)");
            });

            modelBuilder.Entity<TrNonAmount>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CustTypeCode, e.CateCode, e.BrandCode });

                entity.ToTable("tr_non_amount");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CustTypeCode)
                    .HasColumnName("cust_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .HasColumnName("cate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BrandCode)
                    .HasColumnName("brand_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TrPayCateBrand>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocGroup, e.DocNo, e.TourCode, e.CountryCode, e.AirlineCode, e.FlightCode, e.CateCode, e.BrandCode });

                entity.ToTable("Tr_PayCateBrand");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .HasColumnName("doc_group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .HasColumnName("cate_code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BrandCode)
                    .HasColumnName("brand_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarketBrand)
                    .IsRequired()
                    .HasColumnName("market_brand")
                    .HasMaxLength(9);

                entity.Property(e => e.MarketCategory)
                    .IsRequired()
                    .HasColumnName("market_category")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MarketCountry)
                    .IsRequired()
                    .HasColumnName("market_country")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Perhead)
                    .HasColumnName("perhead")
                    .HasColumnType("decimal(15, 2)");
            });

            modelBuilder.Entity<TrPaydtl>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocGroup, e.DocNo, e.TourCode, e.CountryCode, e.AirlineCode, e.FlightCode });

                entity.ToTable("tr_paydtl");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .HasColumnName("doc_group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("airline_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightCode)
                    .HasColumnName("flight_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PerHead)
                    .HasColumnName("per_head")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrPaydtlExtend>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocGroup, e.DocNo, e.TourCode })
                    .HasName("PK_tr_paydtl_extend_1");

                entity.ToTable("tr_paydtl_extend");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .HasColumnName("doc_group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TourCode)
                    .HasColumnName("tour_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraComm)
                    .HasColumnName("extra_comm")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ExtraHead)
                    .HasColumnName("extra_head")
                    .HasColumnType("decimal(15, 2)");
            });

            modelBuilder.Entity<TrPayhdr>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.DocGroup, e.DocNo });

                entity.ToTable("tr_payhdr");

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .HasColumnName("doc_group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .HasColumnName("doc_no")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AddDatetime)
                    .HasColumnName("add_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasColumnName("agent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DelFlag)
                    .IsRequired()
                    .HasColumnName("del_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExtraComm)
                    .HasColumnName("extra_comm")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtraHead)
                    .HasColumnName("extra_head")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.PeriodDt)
                    .HasColumnName("PeriodDT")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.SubagentCode)
                    .IsRequired()
                    .HasColumnName("subagent_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.TastateHdrKey)
                    .HasColumnName("TAStateHdrKey")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnName("time_stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("user_add")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("user_update")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtAmount)
                    .HasColumnName("wht_amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhtRate)
                    .HasColumnName("wht_rate")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TrPayhdrAttr>(entity =>
            {
                entity.HasKey(e => e.PayHdrAttrId);

                entity.ToTable("Tr_payhdr_attr");

                entity.Property(e => e.PayHdrAttrId).HasColumnName("PayHdrAttrID");

                entity.Property(e => e.Attribute)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .IsRequired()
                    .HasColumnName("Branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DocGroup)
                    .IsRequired()
                    .HasColumnName("doc_group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasColumnName("doc_no")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ValueString).HasMaxLength(400);

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WalletAgent>(entity =>
            {
                entity.HasKey(e => e.WalletAgentKey);

                entity.HasIndex(e => new { e.BranchNo, e.AreaCode, e.LocCode, e.MachineNo, e.WalletType })
                    .HasName("IX_WalletAgent")
                    .IsUnique();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .HasColumnName("area_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNo)
                    .HasColumnName("branch_no")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocCode)
                    .HasColumnName("loc_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasColumnName("machine_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WalletAgent1)
                    .IsRequired()
                    .HasColumnName("WalletAgent")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WalletType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.BranchNoNavigation)
                    .WithMany(p => p.WalletAgent)
                    .HasForeignKey(d => d.BranchNo)
                    .HasConstraintName("FK_WalletAgent_df_branch");

                entity.HasOne(d => d.WalletAgent1Navigation)
                    .WithMany(p => p.WalletAgentNavigation)
                    .HasForeignKey(d => d.WalletAgent1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalletAgent_WalletAgentMaster");

                entity.HasOne(d => d.DfArea)
                    .WithMany(p => p.WalletAgent)
                    .HasForeignKey(d => new { d.BranchNo, d.AreaCode })
                    .HasConstraintName("FK_WalletAgent_df_area");

                entity.HasOne(d => d.DfLocation)
                    .WithMany(p => p.WalletAgent)
                    .HasForeignKey(d => new { d.BranchNo, d.LocCode })
                    .HasConstraintName("FK_WalletAgent_df_location");

                entity.HasOne(d => d.DfMachine)
                    .WithMany(p => p.WalletAgent)
                    .HasForeignKey(d => new { d.BranchNo, d.MachineNo })
                    .HasConstraintName("FK_WalletAgent_df_machine");
            });

            modelBuilder.Entity<WalletAgentMaster>(entity =>
            {
                entity.HasKey(e => e.WalletAgent);

                entity.Property(e => e.WalletAgent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApiUrl)
                    .HasColumnName("apiUrl")
                    .HasMaxLength(500);

                entity.Property(e => e.MerChantId)
                    .IsRequired()
                    .HasColumnName("MerChantID")
                    .HasMaxLength(50);

                entity.Property(e => e.PartnerTypeId).HasColumnName("PartnerTypeID");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WsUrl)
                    .IsRequired()
                    .HasColumnName("wsUrl")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<WalletPrefix>(entity =>
            {
                entity.HasKey(e => e.WalletPrefixKey);

                entity.HasIndex(e => e.BarcodePrefix)
                    .HasName("IX_WalletPrefix")
                    .IsUnique();

                entity.Property(e => e.AddDt)
                    .HasColumnName("AddDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodePrefix)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.UpdateDt)
                    .HasColumnName("UpdateDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUser)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WalletType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MethodCodeNavigation)
                    .WithMany(p => p.WalletPrefix)
                    .HasForeignKey(d => d.MethodCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalletPrefix_df_paymeth");
            });

            modelBuilder.Entity<Whtdoc>(entity =>
            {
                entity.HasKey(e => new { e.Wtgroup, e.WhtdocNo });

                entity.ToTable("WHTDoc");

                entity.Property(e => e.Wtgroup)
                    .HasColumnName("WTGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhtdocNo)
                    .HasColumnName("WHTDoc_No")
                    .HasMaxLength(15);

                entity.Property(e => e.AddDateTime)
                    .HasColumnName("Add_DateTime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.Address1).HasMaxLength(300);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CancelToDate)
                    .HasColumnName("Cancel_to_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.CancelToDoc)
                    .IsRequired()
                    .HasColumnName("Cancel_to_Doc")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CertificateDoc)
                    .HasColumnName("certificate_doc")
                    .HasMaxLength(10);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("Cust_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DataDate)
                    .HasColumnName("Data_Date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.IsPerson)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RefDoc)
                    .IsRequired()
                    .HasColumnName("Ref_Doc")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxOrCardId)
                    .IsRequired()
                    .HasColumnName("TaxOrCardID")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("Time_Stamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("Update_Datetime")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("create default [curr_time] as getdate()");

                entity.Property(e => e.UserAdd)
                    .IsRequired()
                    .HasColumnName("User_Add")
                    .HasMaxLength(10);

                entity.Property(e => e.UserUpdate)
                    .IsRequired()
                    .HasColumnName("User_Update")
                    .HasMaxLength(10);

                entity.Property(e => e.Wht)
                    .HasColumnName("WHT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WtAddress)
                    .HasColumnName("WT_Address")
                    .HasMaxLength(200);

                entity.Property(e => e.WtCode)
                    .HasColumnName("WT_Code")
                    .HasMaxLength(15);

                entity.Property(e => e.WtCust)
                    .HasColumnName("WT_Cust")
                    .HasMaxLength(100);

                entity.Property(e => e.WtTaxOrCardId)
                    .HasColumnName("WT_TaxOrCardID")
                    .HasMaxLength(20);
            });
        }
    }
}
