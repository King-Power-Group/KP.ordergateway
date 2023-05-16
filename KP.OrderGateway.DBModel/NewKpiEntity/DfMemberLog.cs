using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class DfMemberLog
    {
        public decimal Logno { get; set; }
        public string MemberId { get; set; }
        public string ShoppingCard { get; set; }
        public string TitleId { get; set; }
        public string Ename { get; set; }
        public string Tname { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdCard { get; set; }
        public string CardTypeId { get; set; }
        public string MemGroupId { get; set; }
        public string ProgramId { get; set; }
        public string SubprogramId { get; set; }
        public string BussinessId { get; set; }
        public string CreditKpg { get; set; }
        public string CondfId { get; set; }
        public string RefproId { get; set; }
        public string EmbossId { get; set; }
        public string EmbossName { get; set; }
        public string Discount { get; set; }
        public string PassportNo { get; set; }
        public string CountryCode { get; set; }
        public string HaddrNumber { get; set; }
        public string HaddrBldg { get; set; }
        public string HaddrMoo { get; set; }
        public string HaddrSoi { get; set; }
        public string HaddrRoad { get; set; }
        public string HaddrSubdistrict { get; set; }
        public string HaddrDistrict { get; set; }
        public string HaddrCity { get; set; }
        public string HaddrZipCode { get; set; }
        public string HaddrTel1 { get; set; }
        public string HaddrTel1Ext { get; set; }
        public string HaddrTel2 { get; set; }
        public string HaddrTel2Ext { get; set; }
        public string HaddrFax { get; set; }
        public string HaddrPct { get; set; }
        public string HaddrPctExt { get; set; }
        public string Email { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string CompanyName { get; set; }
        public string CaddrNumber { get; set; }
        public string CaddrBldg { get; set; }
        public string CaddrFloor { get; set; }
        public string CaddrDept { get; set; }
        public string CaddrSoi { get; set; }
        public string CaddrRoad { get; set; }
        public string CaddrSubdistrict { get; set; }
        public string CaddrDistrict { get; set; }
        public string CaddrCity { get; set; }
        public string CaddrZipCode { get; set; }
        public string CaddrTel { get; set; }
        public string CaddrFax { get; set; }
        public string CaddrTelext { get; set; }
        public string WPosition { get; set; }
        public int MaillingAddr { get; set; }
        public string MainId { get; set; }
        public string MemberRef { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime ApplyDate { get; set; }
        public bool SupVerified { get; set; }
        public int StepNo { get; set; }
        public bool ReprintEmboss { get; set; }
        public string DelFlag { get; set; }
        public string Remark { get; set; }
        public DateTime AddDatetime { get; set; }
        public string UserAdd { get; set; }
        public byte[] TimeStamp { get; set; }
        public string TempCard { get; set; }
        public bool? FlagNoSms { get; set; }
        public DateTime? RenewDate { get; set; }
        public string StaffSource { get; set; }
    }
}
