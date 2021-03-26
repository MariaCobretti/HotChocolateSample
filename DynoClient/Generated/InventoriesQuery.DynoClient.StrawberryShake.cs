#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the Inventories GraphQL operation
    /// <code>
    /// query Inventories {
    ///   dynamicInventories {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       ... Inventory
    ///       ... on DynamicInventory {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Inventory on DynamicInventory {
    ///   dynamicInventoryId
    ///   fieldName
    ///   displayName
    ///   variant
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class InventoriesQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IInventoriesResult> _operationExecutor;

        public InventoriesQuery(global::StrawberryShake.IOperationExecutor<IInventoriesResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IInventoriesResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IInventoriesResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return new global::StrawberryShake.OperationRequest(
                "Inventories",
                InventoriesQueryDocument.Instance);
        }
    }
}
