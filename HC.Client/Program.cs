using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            await Run(host.Services);
            Console.WriteLine("Hello World!");
            //return host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddHttpClient(
                            "TestClient",
                            c =>
                            {
                                c.BaseAddress = new Uri("https://localhost:5001/graphql");
                                //c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _token);
                            });

                    services.AddTestClient();
                });


         static async Task Run(IServiceProvider services)
         {
             using IServiceScope serviceScope = services.CreateScope();
             IServiceProvider provider = serviceScope.ServiceProvider;

            var testClient = provider.GetRequiredService<TestClient>();
            var testClientTestQueryQuery = await testClient.TestQuery.ExecuteAsync();
            Console.WriteLine(testClientTestQueryQuery.Data.ComplexField.NumberField);

            var sss = new ComplexInput()
            {
                NumberField = 113,
                StringField = "okok"
            };
            var res = await testClient.CreateTest.ExecuteAsync(sss);

            Console.WriteLine(res.Data.CreateWithComplexArg.StringField);
        }
    }
}
