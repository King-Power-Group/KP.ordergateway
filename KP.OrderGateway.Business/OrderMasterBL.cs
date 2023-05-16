using System;
using System.Collections.Generic;
using System.Text;
using static KP.OrderGateway.ServiceModel.OrderManagementModel;

namespace KP.OrderGateway.ServiceModel
{
    public static class OrderMasterBL
    {
        public static string GetOrderTypeDetail(string typeCode)
        {
			var ret = "";
			try
			{
				switch (typeCode)
				{
					case OrderType.Normal:
						ret = "NORMAL";
						break;
					case OrderType.DutyPaidDelivery:
						ret = "DELIVERY";
						break;
					case OrderType.PreOrder:
						ret = "PRE-ORDER";
						break;
					case OrderType.Receive:
						ret = "RECEIVE";
						break;
					default:
						ret = "";
						break;
				}
			}
			catch (Exception)
			{

			}
			return ret;
        }
    }
}
