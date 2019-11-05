using Galaxy.Order.Abstraction;
using Galaxy.Order.Abstraction.Models.Dtos;
using Galaxy.Product.Abstraction;
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
        private IProductService productService { get; set; }

        public OrderService(IProductService productService)
        {
            this.productService = productService;
        }

        public Task<OrderDto> CreateAsync(OrderDto Order)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> GetAsync(string id)
        {
            var items = await this.productService.GetListAsync(new ProductQueryDto());
            var task = await Task.Run(() =>
            {
                Thread.Sleep(100);
                return new OrderDto() { Id = id, OrderNo = "1234", ProductItems = items };
            });
            return task;
        }
    }
}
