#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the BasicInventories GraphQL operation
    /// <code>
    /// query BasicInventories {
    ///   basicInventory {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       ... BasicInventory
    ///       ... on BasicInventory {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment BasicInventory on BasicInventory {
    ///   dynamicItemId
    ///   numberField
    ///   stringField
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventoriesQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IBasicInventoriesResult> _operationExecutor;

        public BasicInventoriesQuery(global::StrawberryShake.IOperationExecutor<IBasicInventoriesResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IBasicInventoriesResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IBasicInventoriesResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return new global::StrawberryShake.OperationRequest(
                "BasicInventories",
                BasicInventoriesQueryDocument.Instance);
        }
    }
}
