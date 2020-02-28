using System;
using System.Threading;
using System.Threading.Tasks;
using Galaxy.Order.Contracts;
using Galaxy.Order.Contracts.Models.Dtos;
using Galaxy.Product.Contracts;
using Galaxy.Product.Contracts.Models.Dtos;
using Volo.Abp.Application.Services;

namespace Galaxy.Order
{
    public class OrderService : ApplicationService, IOrderService
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