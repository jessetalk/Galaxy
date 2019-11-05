using Galaxy.Product;
using Galaxy.Product.Abstraction;
using Galaxy.Product.Entity;
using Grpc.Net.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProtoBuf.Grpc.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProductService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext();

            return services;
        }

        public static IServiceCollection AddProductServiceAsGrpc(this IServiceCollection services, Action<GrpcOptions> options)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;

            var grpcOptions = new GrpcOptions();
            options?.Invoke(grpcOptions);

            services.AddScoped(sp => GrpcChannel.ForAddress(grpcOptions.ServerAddress));
            services.AddScoped(sp =>
            {
                var channel = sp.GetRequiredService<GrpcChannel>();
                return channel.CreateGrpcService<IProductService>();
            });

            return services;
        }
    
        private static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ProductContext>(option => option.UseMySql("server=mysql.zzhong.me;userid=lims;password=Dev@2017;database=Galaxy;"));
            return services;
        }
    }
}
