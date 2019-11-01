using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using GrpcDemo.Abstraction;
using GrpcDemo;

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

    }
}
