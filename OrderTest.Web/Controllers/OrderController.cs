using Microsoft.AspNetCore.Mvc;
using OrderTest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersTest.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetOrdersList()
        {
            var result = await _orderService.GetOrdersList();
            return Ok(result);
        }

        [HttpPost("getOrder")]
        public async Task<IActionResult> GetOrder(Guid orderId)
        {
            var result = await _orderService.GetOrder(orderId);
            return Ok(result);
        }
    }
}
