#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the FullTestInventories GraphQL operation
    /// <code>
    /// query FullTestInventories {
    ///   fullTestInventory {
    ///     __typename
    ///     totalCount
    ///     nodes {
    ///       __typename
    ///       ... FullTestInventory
    ///       ... on FullTestInventory {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FullTestInventory on FullTestInventory {
    ///   dynamicItemId
    ///   boolField
    ///   boolFieldList
    ///   boolFieldNull
    ///   boolFieldNullList
    ///   dateField
    ///   dateFieldList
    ///   dateFieldNull
    ///   dateFieldNullList
    ///   enumField
    ///   enumFieldList
    ///   enumFieldNull
    ///   enumFieldNullList
    ///   numberField
    ///   numberFieldList
    ///   numberFieldNull
    ///   numberFieldNullList
    ///   refField {
    ///     __typename
    ///     ... BasicInventory
    ///     ... on BasicInventory {
    ///       id
    ///     }
    ///   }
    ///   refFieldList {
    ///     __typename
    ///     ... BasicInventory
    ///     ... on BasicInventory {
    ///       id
    ///     }
    ///   }
    ///   refFieldNull {
    ///     __typename
    ///     ... BasicInventory
    ///     ... on BasicInventory {
    ///       id
    ///     }
    ///   }
    ///   refFieldNullList {
    ///     __typename
    ///     ... BasicInventory
    ///     ... on BasicInventory {
    ///       id
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
    public partial class FullTestInventoriesQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IFullTestInventoriesResult> _operationExecutor;

        public FullTestInventoriesQuery(global::StrawberryShake.IOperationExecutor<IFullTestInventoriesResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IFullTestInventoriesResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IFullTestInventoriesResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return new global::StrawberryShake.OperationRequest(
                "FullTestInventories",
                FullTestInventoriesQueryDocument.Instance);
        }
    }
}
