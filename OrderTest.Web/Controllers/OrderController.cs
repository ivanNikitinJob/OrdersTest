using Microsoft.AspNetCore.Mvc;
using OrderTest.Services.Interfaces;
using OrderTest.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersTest.Web.Controllers
{
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getOrders")]
        public async Task<IActionResult> GetOrdersList()
        {
            var result = await _orderService.GetOrdersList();
            return Ok(result);
        }

        [HttpPost("getOrder")]
        public async Task<IActionResult> GetOrder([FromBody] GetOrderRequestModel model)
        {
            var result = await _orderService.GetOrder(model.OrderId);
            return Ok(result);
        }
    }
}
