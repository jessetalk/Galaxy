using Grpc.Net.Client;
using Microsoft.Extensions.DependencyInjection;
using ProtoBuf.Grpc.Client;
using System;
using GrpcDemo.Abstraction;
using GrpcDemo;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
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
