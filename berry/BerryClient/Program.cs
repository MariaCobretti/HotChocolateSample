using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

namespace BerryClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient("DynamicServiceClient",c => c.BaseAddress = new Uri("https://localhost:5001/graphql/"));

            serviceCollection.AddDynamicServiceClient();

            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IDynamicServiceClient client = services.GetRequiredService<IDynamicServiceClient>();

            Console.WriteLine("start");
            IOperationResult<IBasicInventory> result = await client.BasicInventoryAsync();
            Console.WriteLine("finish");

            if (result.HasErrors)
            {
                foreach (var resultError in result.Errors)
                {
                    Console.WriteLine(resultError.Code);
                }
            }
            else
            {
                foreach (var basicInventoryNode in result.Data.BasicInventory.Nodes)
                {
                    Console.WriteLine($"{basicInventoryNode.DynamicItemId} - {basicInventoryNode.StringField}");
                }
            }
        }
    }
}
