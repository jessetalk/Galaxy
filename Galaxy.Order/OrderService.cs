using Galaxy.Order.Abstraction;
using Galaxy.Order.Abstraction.Models.Dtos;
using Galaxy.Product.Abstraction.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy.Order
{
    public class OrderService : IOrderService
    {
        public OrderService()
        {
        }

        public Task<OrderDto> CreateAsync(OrderDto Order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> GetAsync(string id)
        {
            var items = new List<ProductDto>();
            var task = Task.Run(() =>
            {
                Thread.Sleep(100);
                return new OrderDto() { Id = id, OrderNo = "1234", ProductItems = items };
            });
            return task;
        }
    }
}
