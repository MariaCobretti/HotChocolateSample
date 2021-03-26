#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public static partial class DynoClientServiceCollectionExtensions
    {
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddDynoClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();

                    ConfigureClient(
                        serviceCollection,
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.BasicInventoriesQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.CreateBasicInventoryMutation>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.CreateBasicInventory2Mutation>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.FullTestInventoriesQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.InventoriesQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.SelectionListsQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::DynoClient.DynoClient.DynoClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return services;
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClient(
            global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            if (services is null)
            {
                throw new global::System.ArgumentNullException(nameof(services));
            }
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId>>(
                services,
                global::DynoClient.DynoClient.EntityIdFactory.CreateEntityId);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)
                    .Watch()));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("DynoClient"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.BasicInventories_BasicInventory_Nodes_BasicInventory>, global::DynoClient.DynoClient.BasicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.CreateBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventory>, global::DynoClient.DynoClient.CreateBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory>, global::DynoClient.DynoClient.CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.FullTestInventoryEntity, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_FullTestInventory>, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefField_BasicInventory>, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory>, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventory>, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.BasicInventoryEntity, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventory>, global::DynoClient.DynoClient.FullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.DynamicInventoryEntity, global::DynoClient.DynoClient.Inventories_DynamicInventories_Nodes_DynamicInventory>, global::DynoClient.DynoClient.Inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::DynoClient.DynoClient.SelectionListEntity, global::DynoClient.DynoClient.SelectionLists_SelectionLists_Nodes_SelectionList>, global::DynoClient.DynoClient.SelectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::DynoClient.DynoClient.StocksSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::DynoClient.DynoClient.VariantSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::DynoClient.DynoClient.CreateBasicInventoryInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::DynoClient.DynoClient.IBasicInventoriesResult>, global::DynoClient.DynoClient.BasicInventoriesResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IBasicInventoriesResult>, global::DynoClient.DynoClient.BasicInventoriesBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::DynoClient.DynoClient.IBasicInventoriesResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IBasicInventoriesResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IBasicInventoriesResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.BasicInventoriesQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::DynoClient.DynoClient.ICreateBasicInventoryResult>, global::DynoClient.DynoClient.CreateBasicInventoryResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ICreateBasicInventoryResult>, global::DynoClient.DynoClient.CreateBasicInventoryBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::DynoClient.DynoClient.ICreateBasicInventoryResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ICreateBasicInventoryResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ICreateBasicInventoryResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.CreateBasicInventoryMutation>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::DynoClient.DynoClient.ICreateBasicInventory2Result>, global::DynoClient.DynoClient.CreateBasicInventory2ResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ICreateBasicInventory2Result>, global::DynoClient.DynoClient.CreateBasicInventory2Builder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::DynoClient.DynoClient.ICreateBasicInventory2Result>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ICreateBasicInventory2Result>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ICreateBasicInventory2Result>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.CreateBasicInventory2Mutation>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::DynoClient.DynoClient.IFullTestInventoriesResult>, global::DynoClient.DynoClient.FullTestInventoriesResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IFullTestInventoriesResult>, global::DynoClient.DynoClient.FullTestInventoriesBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::DynoClient.DynoClient.IFullTestInventoriesResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IFullTestInventoriesResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IFullTestInventoriesResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.FullTestInventoriesQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::DynoClient.DynoClient.IInventoriesResult>, global::DynoClient.DynoClient.InventoriesResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IInventoriesResult>, global::DynoClient.DynoClient.InventoriesBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::DynoClient.DynoClient.IInventoriesResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IInventoriesResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.IInventoriesResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.InventoriesQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::DynoClient.DynoClient.ISelectionListsResult>, global::DynoClient.DynoClient.SelectionListsResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ISelectionListsResult>, global::DynoClient.DynoClient.SelectionListsBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::DynoClient.DynoClient.ISelectionListsResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ISelectionListsResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::DynoClient.DynoClient.ISelectionListsResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.SelectionListsQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::DynoClient.DynoClient.DynoClient>(services);
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}
