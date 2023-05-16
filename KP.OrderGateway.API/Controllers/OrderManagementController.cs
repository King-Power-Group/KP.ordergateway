using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KP.OrderGateway.DBModel.NewKpiEntity;
using KP.OrderGateway.IService;
using KP.OrderGateway.Business;
using Microsoft.AspNetCore.Mvc;
using KP.Common.Return;
using Microsoft.AspNetCore.Authorization;
using KP.OrderGateway.ServiceModel;
using KP.OrderGateway.DBModel.KPVirtualStockEntity;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KP.OrderGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class OrderManagementController : ControllerBase
    {
        private readonly IOrderManagement _orderManagementBL;
        public OrderManagementController(KPIMNPOSMAContext context, DBModel.CustomerDataContext _cusContext, KPVirtualStockContext _vscontext, IConfiguration config)
        {
            var posConstring = config.GetConnectionString("NewKpiDB");
            _orderManagementBL = new OrderManagementBL(context, _cusContext, _vscontext, posConstring);
        }
        [HttpPost]
        [Route("GetOrderType")]
        public async Task<ReturnObject<string>> GetOrderType(ServiceModel.OrderManagementModel.OrderTypeModel request)
        {
            var ret = new ReturnObject<string>();
            try
            {
                ret = await _orderManagementBL.GetOrderType(request);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }
        [HttpPost]
        [Route("CheckOrderType")]
        public async Task<ReturnObject<string>> CheckOrderType(OrderManagementModel.OrderTypeModel request)
        {
            var ret = new ReturnObject<string>();
            try
            {
                ret = await _orderManagementBL.CheckOrderType(request);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }
        [HttpPost]
        [Route("ChangeOrderType")]
        public async Task<ReturnObject<string>> ChangeOrderType(OrderManagementModel.OrderTypeModel request)
        {
            var ret = new ReturnObject<string>();
            var forceChange = true;
            try
            {
                ret = await _orderManagementBL.CheckOrderType(request, forceChange);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("CanAddItemToOrder")]
        public async Task<ReturnObject<string>> CanAddItemToOrder(OrderManagementModel.CheckScanItemToOrder request)
        {
            var ret = new ReturnObject<string>();
            try
            {
                ret = await _orderManagementBL.CanAddItemToOrder(request);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }
        [HttpPost]
        [Route("UpdateShipping")]
        public async Task<ReturnObject<bool>> UpdateShipping(lstShippingUpdate param)
        {
            var ret = new ReturnObject<bool>();

            try
            {
                ret = await _orderManagementBL.UpdateShipping(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("ChangeFlightPreOrder")]
        public async Task<ReturnObject<bool>> ChangeFlightPreOrder(ChangeFlightPreOrderInfoModel param)
        {
            var ret = new ReturnObject<bool>();

            try
            {
                ret = await _orderManagementBL.ChangeFlightPreOrder(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("SearchPreOrder")]
        public async Task<ReturnObject<List<DataModel>>> SearchPreOrder(OrderManagementModel.SearchOrderInfoModel param)
        {
            var ret = new ReturnObject<List<DataModel>>();

            try
            {
                //ret = await
                ret = await _orderManagementBL.SearchPreOrder(param);
            }
            catch (System.Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("SearchShippingOrder")]
        public async Task<ReturnObject<List<DataModel>>> SearchShippingOrder(OrderManagementModel.SearchOrderInfoModel param)
        {
            var ret = new ReturnObject<List<DataModel>>();
            try
            {
                ret = await _orderManagementBL.SearchShipping(param);
            }
            catch (System.Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }
        /// <summary>
        /// Duplicate Order for Receive
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DuplicateReceiveOrder")]
        public async Task<ReturnObject<ResultOrderModel>> DuplicateReceiveOrder(ReceiveOrderInfoModel request)
        {
            var ret = new ReturnObject<ResultOrderModel>();

            try
            {
                ret = await _orderManagementBL.DuplicateOrder(request);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        /// <summary>
        /// Duplicate Order for Cancel 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DuplicateCancelOrder")]
        public async Task<ReturnObject<ResultOrderModel>> DuplicateCancelOrder(ReceiveOrderInfoModel request)
        {
            var ret = new ReturnObject<ResultOrderModel>();

            try
            {
                ret = await _orderManagementBL.CancelOrder(request);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }


        [HttpPost]
        [Route("SearchStock")]
        public async Task<ReturnObject<List<DataModel>>> SearchStock(OrderManagementModel.SearchOrderInfoModel param)
        {
            var ret = new ReturnObject<List<DataModel>>();

            try
            {
                //ret = await
                ret = await _orderManagementBL.SearchStock(param);
            }
            catch (System.Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("SearchStockKPD")]
        public async Task<ReturnObject<List<KPDModel>>> SearchStockKPD(OrderManagementModel.SearchStockKPD param)
        {
            var ret = new ReturnObject<List<KPDModel>>();

            try
            {
                //ret = await
                ret = await _orderManagementBL.SearchStockKPD(param);
            }
            catch (System.Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("ReportStock")]
        public async Task<ReturnObject<List<ReportTrans>>> ReportStock(OrderManagementModel.SearchOrderReport param)
        {
            var ret = new ReturnObject<List<ReportTrans>>();

            try
            {
                //ret = await
                ret = await _orderManagementBL.ReportStock(param);
            }
            catch (System.Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("SaveStock")]
        public async Task<ReturnObject<bool>> SaveStock(saveTrans param)
        {
            var ret = new ReturnObject<bool>();

            try
            {
                //ret = await
                ret = await _orderManagementBL.SaveStock(param);
            }
            catch (System.Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpGet]
        [Route("ListSubBranch")]
        public async Task<ReturnObject<List<OrderSubBranch>>> getListSubBranch()
        {
            var ret = new ReturnObject<List<OrderSubBranch>>();

            try
            {
                ret = await _orderManagementBL.listSubBranch();
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("UpdateLastStatus")]
        public async Task<ReturnObject<bool>> updateLastStatus(ParamUpdateOrder param)
        {
            var ret = new ReturnObject<bool>();

            try
            {
                ret = await _orderManagementBL.updateLastStatus(param);
            }
            catch (Exception ex)
            {

                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("UpdateOrderLastStatusKPD")]
        public async Task<ReturnObject<UpdateOrderStatusKPDModel>> updateOrderLastStatusKPD(UpdateOrderStatusKPDReq param)
        {
            var ret = new ReturnObject<UpdateOrderStatusKPDModel>();

            try
            {
                ret = await _orderManagementBL.updateOrderLastStatusKPD(param);
            }
            catch (Exception ex)
            {

                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("TimeVirtualStock")]
        public async Task<ReturnObject<List<string>>> TimeVirtualStock(settings param)
        {
            var ret = new ReturnObject<List<string>>();

            try
            {
                ret = await _orderManagementBL.TimeVirtualStock(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("GetHangingType")]
        public async Task<ReturnObject<string>> GetHangingType(ParameterHanging param)
        {
            var ret = new ReturnObject<string>();

            try
            {
                ret = await _orderManagementBL.getHangingType(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("ReserveHanging")]
        public async Task<ReturnObject<bool>> reserveHanging(ParameterHanging param)
        {
            var ret = new ReturnObject<bool>();

            try
            {
                ret = await _orderManagementBL.reserveHanging(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }
            return ret;
        }

        [HttpPost]
        [Route("CancelHanging")]
        public async Task<ReturnObject<bool>> cancelHanging(ParameterHanging param)
        {
            var ret = new ReturnObject<bool>();

            try
            {
                ret = await _orderManagementBL.cancelHanging(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("FindPickupFromFlight")]
        public ReturnObject<string> getPickupFromFlight(InputPickupFromFlight param)
        {
            var ret = new ReturnObject<string>();

            try
            {
                ret = _orderManagementBL.getPickupFromFlight(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("GetSiteMachine")]
        public async Task<ReturnObject<ListSite>> getListByMachine(StockModels param)
        {
            var ret = new ReturnObject<ListSite>();

            try
            {
                ret = await _orderManagementBL.getListByMachine(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage(ex);
            }

            return ret;
        }

        [HttpPost]
        [Route("GetConfigPos")]
        public async Task<ReturnObject<List<ConfigData>>> getConfigData(ConfigParam param)
        {
            var ret = new ReturnObject<List<ConfigData>>();

            try
            {
                ret = await _orderManagementBL.ConfigValue(param);
            }
            catch (Exception ex)
            {
                ret.SetMessage("Ex-Data", ex.Message + "-" + ex.InnerException);
            }

            return ret;
        }
    }
}
