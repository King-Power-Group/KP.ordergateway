using System;
using System.Collections.Generic;

namespace KP.OrderGateway.DBModel.NewKpiEntity
{
    public partial class Member
    {
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
        public string Religion { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Email { get; set; }
        public string Mobile1 { get; set; }
        public string MainId { get; set; }
        public string MemberRef { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime ApplyDate { get; set; }
        public string OldMemberId { get; set; }
        public bool StaffFlag { get; set; }
        public bool SharedFlag { get; set; }
        public string DelFlag { get; set; }
        public DateTime AddDatetime { get; set; }
        public DateTime UpdateDatetime { get; set; }
        public string TempCard { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime? RenewDate { get; set; }
        public bool Foreigner { get; set; }
    }
}
