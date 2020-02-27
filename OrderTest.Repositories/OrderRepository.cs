using OrderTest.Entities;
using OrderTest.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderTest.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        Task<Order> IOrderRepository.GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        Task<List<Order>> IOrderRepository.GetOrdersList()
        {
            throw new NotImplementedException();
        }
    }
}
