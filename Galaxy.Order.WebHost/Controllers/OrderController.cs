using Galaxy.Order.Abstraction;
using Galaxy.Order.Abstraction.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.Product.WebHost.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController: ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService _orderService)
        {
            this._orderService = _orderService;
        }

        [Route("")]
        [HttpPost]
        public async Task<OrderDto> CreateOrderAsync([FromBody]OrderDto product)
        {
            return await _orderService.CreateAsync(product);
        }

        [Route("")]
        [HttpGet("{id}")]
        public async Task<OrderDto> GetAsync(string id)
        {
            return await _orderService.GetAsync(id);
        }
    }
}
