using OrderTest.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersList();
        Task<Order> GetOrder(Guid orderId);
    }
}
