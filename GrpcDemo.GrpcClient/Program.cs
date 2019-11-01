using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GrpcDemo.GrpcClient
{
    class Program
    {
        static async Task Main()
        {
            var services = new ServiceCollection();
            services.AddGrpcDemoAsGrpc(options =>
            {
                options.GrpcServerAddress = "http://localhost:10042";
            });

            var serviceProvider = services.BuildServiceProvider();

            var watch = new Stopwatch();
            watch.Start();

            for (var i = 0; i <= 10000; i++)
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var calculator = scope.ServiceProvider.GetRequiredService<ICalculator>();
                    var result = await calculator.MultiplyAsync(new Abstraction.Models.MultiplyRequest { X = 10, Y = 20 });

                    Console.WriteLine(result.Result);
                }
            }

            watch.Stop();
            Console.WriteLine($"Completed: {watch.ElapsedMilliseconds } milliseconds ");
        }
    }
}
