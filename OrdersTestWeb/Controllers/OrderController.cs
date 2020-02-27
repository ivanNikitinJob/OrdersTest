using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersTest.Web.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetOrdersList()
        {
            return Ok();
        }

        [HttpPost("getOrder")]
        public async Task<IActionResult> GetOrder(Guid orderId)
        {
            return Ok();
        }
    }
}
