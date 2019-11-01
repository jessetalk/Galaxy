using System;
using System.Net.Http;
using Newtonsoft.Json;
using GrpcDemo.Abstraction.Models;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace GrpcDemo.ApiClient
{
    class Program
    {

        static Semaphore sema = new Semaphore(10, 50);
        static async Task Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            for (var i = 0; i <= 10000; i++)
            {
                Task.Run(() => {  TestOne();  });
            }

            watch.Stop();
            Console.WriteLine($"Completed: {watch.ElapsedMilliseconds } milliseconds ");

        }


        public static async Task TestOne()
        {
            sema.WaitOne();

            var httpclient = new HttpClient();

            var mulitply = new MultiplyRequest { X = 100, Y = 20 };
            var str = JsonConvert.SerializeObject(mulitply);

            var content = new StringContent(str);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await httpclient.PostAsync($"http://localhost:5000/Caculator", content);
            var result = await response.Content.ReadAsStringAsync();
            var objResult = JsonConvert.DeserializeObject<MultiplyResult>(result);
            Console.WriteLine($" {mulitply.X} X {mulitply.Y} = { objResult.Result } ");

            sema.Release();
        }
    }
}
