using Microsoft.EntityFrameworkCore;
using OrderTest.Entities;
using OrderTest.Repositories.Context;
using OrderTest.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderTest.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context;

        public OrderRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public async Task<Order> GetOrder(Guid orderId)
        {
            try
            {
                var result = await _context.Orders.Include(x => x.ProductsList).Where(x => x.Id == orderId).SingleOrDefaultAsync();
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return null;
            }
        }

        public async Task<List<Order>> GetOrdersList()
        {
            try
            {
                var result = await _context.Orders.ToListAsync();
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return null;
            }
        }
    }
}
