using System;
using System.Linq;
using System.Net.Http.Headers;
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
            serviceCollection.AddHttpClient("DynamicServiceClient",c =>
            {
                c.BaseAddress = new Uri("https://localhost:5001/graphql/");
            });



            serviceCollection.AddDynamicServiceClient();

            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IDynamicServiceClient client = services.GetRequiredService<IDynamicServiceClient>();

            var result = await client.GetBasicInventoriesAsync();
            
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

            var neuesItem = await client.CreateBasicInventoryAsync("hallo");
            var neueItemId = neuesItem.Data.CreateBasicInventory.ConcreteItems.First().DynamicItemId;

            var item = await client.GetBasicInventoryByIdAsync(neueItemId);
            Console.WriteLine(item.Data.BasicInventory.Nodes.First().StringField);
        }
    }
}
