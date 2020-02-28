using OrderTest.Entities;
using OrderTest.Repositories.Interfaces;
using OrderTest.Services.Interfaces;
using OrderTest.ViewModels;
using OrderTest.ViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderTest.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<GetOrderResponseModel> GetOrder(Guid orderId)
        {
            try
            {
                Order order = await _orderRepository.GetOrder(orderId);
                var result = new GetOrderResponseModel()
                {
                    CreationDate = order.CreationDate,
                    Id = order.Id,
                    Name = order.Name,
                    Status = order.Status
                };

                foreach (var product in order.ProductsList)
                {
                    var productModel = new GetOrderProductItem()
                    {
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        TotalPrice = product.TotalPrice
                    };

                    result.ProductsList.Add(productModel);
                }

                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new GetOrderResponseModel();
            }
        }

        public async Task<GetOrdersResponseModel> GetOrdersList()
        {
            try
            {
                List<Order> ordersList = await _orderRepository.GetOrdersList();
                var result = new GetOrdersResponseModel();

                foreach (var order in ordersList)
                {
                    var orderModel = new GetOrdersResponseItem()
                    {
                        Name = order.Name,
                        CreationDate = order.CreationDate,
                        Id = order.Id,
                        Status = order.Status
                    };

                    result.Orders.Add(orderModel);
                }

                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return new GetOrdersResponseModel();
            }
        }
    }
}
