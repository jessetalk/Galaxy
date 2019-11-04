using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Galaxy.Order.Abstraction.Models.Dtos;

namespace Galaxy.Order.Abstraction
{
    public interface IOrderService
    {
        Task<OrderDto> CreateAsync(OrderDto product);
        Task<OrderDto> GetAsync(string id);
    }
}
