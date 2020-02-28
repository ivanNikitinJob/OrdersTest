using OrderTest.ViewModels;
using OrderTest.ViewModels.Responses;
using System;
using System.Threading.Tasks;

namespace OrderTest.Services.Interfaces
{
    public interface IOrderService
    {
        Task<GetOrdersResponseModel> GetOrdersList();
        Task<GetOrderResponseModel> GetOrder(Guid orderId);
    }
}
