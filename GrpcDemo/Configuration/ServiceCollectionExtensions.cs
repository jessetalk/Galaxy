using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using GrpcDemo.Abstraction;
using GrpcDemo;
using ProtoBuf.Grpc.Client;
using Grpc.Net.Client;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGrpcDemo(this IServiceCollection services)
        {
            services.AddScoped<ICalculator, MyCalculator>();
            services.AddScoped<ITimeService, MyTimeService>();

            return services;
        }

        public static IServiceCollection AddGrpcDemoAsGrpc(this IServiceCollection services, Action<GrpcDemoOptions> options)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;

            var grpcDemoOptions = new GrpcDemoOptions();
            options?.Invoke(grpcDemoOptions);

            services.AddScoped(sp => GrpcChannel.ForAddress(grpcDemoOptions.GrpcServerAddress));
            services.AddScoped(sp =>
            {
                var channel = sp.GetRequiredService<GrpcChannel>();
                return channel.CreateGrpcService<ITimeService>();
            });

            services.AddScoped(sp =>
            {
                var channel = sp.GetRequiredService<GrpcChannel>();
                return channel.CreateGrpcService<ICalculator>();
            });

            return services;
        }

    }
}
