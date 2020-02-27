using OrderTest.Entities;
using OrderTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderTest.Services
{
    public class OrderService : IOrderService
    {
        Task<Order> IOrderService.GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        Task<List<Order>> IOrderService.GetOrdersList()
        {
            throw new NotImplementedException();
        }
    }
}
