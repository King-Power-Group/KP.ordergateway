using System;
using System.Collections.Generic;
using System.Text;

namespace KP.OrderGateway.ServiceModel
{
    public class HangingModel
    {
    }

    public class ParameterHanging
    {
        public string branchNo { get; set; }
        //public string subBranchCode { get; set; }
        public string shoppingCard { get; set; }
        public int orderNo { get; set; }
        public string subOrderType { get; set; }
        public UserInfo userInfo { get; set; }
    }

    public class HangingTypeLis
    {
        public string HangingTypeCode { get; set; }
        public string SqlWhere { get; set; }
    }
    public class UserInfo
    {
        public string userID { get; set; }
        public string clientIP { get; set; }
    }

    public class ReserveHangingModel : ParameterHanging
    {
        public string pickupCode { get; set; }
        public string passportNo { get; set; }
        public string flightCode { get; set; }
        public DateTime flightDate { get; set; }
        public string flightTime { get; set; }
        public UserInfo userInfo { get; set; }
    }

    public class posReserveHanging
    {
        public string pickupCode { get; set; }
        public string hangingType { get; set; }
        public string packingNo { get; set; }
        public string passportNo { get; set; }
        public string flightCode { get; set; }
        public DateTime flightDate { get; set; }
        public string flightTime { get; set; }
        public UserInfo userInfo { get; set; }
    }

    public class authenModel
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string grantType { get; set; }
    }

    public class respAuthen
    {
        public string data { get; set; }
        public string accessToken { get; set; }
    }

    public class PackReserveHangingInfo
    {
        public string PickupCode { get; set; }
        public string HangingType { get; set; }
        public string PackingNo { get; set; }
        public string PassportNo { get; set; }
        public string FlightCode { get; set; }
        public DateTime? FlightDate { get; set; }
        public string FlightTime { get; set; }
        public UserInfo UserInfo { get; set; }
    }

    public class ReserveHangingInfo : PackReserveHangingInfo
    {
        public string HangingNo { get; set; }
    }

    public class CancelHangingInfo
    {
        public string branchNo { get; set; }
        //public string subBranchCode { get; set; }
        public string pickupCode { get; set; }
        public string hangingNo { get; set; }
        public string packingNo { get; set; }
        public UserInfo userInfo { get; set; }
    }

    public class InputPickupFromFlight
    {
        public string branchNo { get; set; }
        public string airlineCode { get; set; }
        public string flightCode { get; set; }
        public bool isIncludeName { get; set; }
    }
}
