using Galaxy.Order;
using Galaxy.Order.Abstraction;

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
