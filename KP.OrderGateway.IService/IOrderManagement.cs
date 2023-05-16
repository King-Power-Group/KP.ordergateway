using KP.Common.Return;
using KP.OrderGateway.ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static KP.OrderGateway.ServiceModel.OrderManagementModel;

namespace KP.OrderGateway.IService
{
    public interface IOrderManagement
    {
        Task<ReturnObject<string>> GetOrderType(OrderTypeModel request);
        Task<ReturnObject<string>> CheckOrderType(OrderTypeModel request, bool forceChange = false);
        Task<ReturnObject<string>> CanAddItemToOrder(CheckScanItemToOrder request);

        //Task<ReturnObject<string>> ChangeOrderType(OrderTypeModel request);

        //Task<ReturnObject<List<OrderInfoModel>>> SearchPreOrder(SearchOrderInfoModel request);
       // Task<ReturnObject<bool>> ChangeFlightOrder(ReceivePreOrderInfoModel request);

        Task<ReturnObject<List<DataModel>>> SearchPreOrder(OrderManagementModel.SearchOrderInfoModel request);
        Task<ReturnObject<List<ReportTrans>>> ReportStock(OrderManagementModel.SearchOrderReport param);
        Task<ReturnObject<List<DataModel>>> SearchShipping(OrderManagementModel.SearchOrderInfoModel request);
        Task<ReturnObject<List<DataModel>>> SearchStock(OrderManagementModel.SearchOrderInfoModel request);
        Task<ReturnObject<List<KPDModel>>> SearchStockKPD(SearchStockKPD request);
        Task<ReturnObject<bool>> SaveStock(saveTrans request);
        // Task<ReturnObject<List<OrderInfoModel>>> SearchPreOrder(SearchOrderInfoModel request);
        Task<ReturnObject<bool>> ChangeFlightPreOrder(ChangeFlightPreOrderInfoModel request);
        Task<ReturnObject<bool>> UpdateShipping(lstShippingUpdate lstUpdate);
        Task<ReturnObject<bool>> updateLastStatus(ParamUpdateOrder param);
        Task<ReturnObject<UpdateOrderStatusKPDModel>> updateOrderLastStatusKPD(UpdateOrderStatusKPDReq param, object context = null);
        Task<ReturnObject<ResultOrderModel>> DuplicateOrder(ReceiveOrderInfoModel request);
        Task<ReturnObject<ResultOrderModel>> CancelOrder(ReceiveOrderInfoModel request);
        Task<ReturnObject<List<string>>> TimeVirtualStock(settings subBranch);
        Task<ReturnObject<List<OrderSubBranch>>> listSubBranch();

        Task<ReturnObject<string>> getHangingType(ParameterHanging param);
        Task<ReturnObject<bool>> reserveHanging(ParameterHanging param);
        Task<ReturnObject<bool>> cancelHanging(ParameterHanging param);

        ReturnObject<string> getPickupFromFlight(InputPickupFromFlight param);
        Task<ReturnObject<ListSite>> getListByMachine(StockModels param);
        Task<ReturnObject<List<ConfigData>>> ConfigValue(ConfigParam param);
    }

}
