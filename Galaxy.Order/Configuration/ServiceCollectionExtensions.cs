using Galaxy.Order;
using Galaxy.Order.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOrderService(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
