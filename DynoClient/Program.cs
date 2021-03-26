using System;
using System.Threading.Tasks;
using DynoClient.DynoClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DynoClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            //await Run(host.Services);
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddHttpClient(
                        "DynoClient",
                        c =>
                        {
                            c.BaseAddress = new Uri("https://s2o-fk-dev-app-graphql-tsservice.azurewebsites.net/graphql/");
                            //c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _token);
                        });

                    services.AddDynoClient();
                });

    }
}
