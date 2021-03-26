#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the SelectionLists GraphQL operation
    /// <code>
    /// query SelectionLists {
    ///   selectionLists {
    ///     __typename
    ///     nodes {
    ///       __typename
    ///       fieldName
    ///       selectionListId
    ///       displayName
    ///       selectionItems {
    ///         __typename
    ///         fieldName
    ///         selectionItemId
    ///         description
    ///       }
    ///       ... on SelectionList {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionListsQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<ISelectionListsResult> _operationExecutor;

        public SelectionListsQuery(global::StrawberryShake.IOperationExecutor<ISelectionListsResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<ISelectionListsResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<ISelectionListsResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return new global::StrawberryShake.OperationRequest(
                "SelectionLists",
                SelectionListsQueryDocument.Instance);
        }
    }
}
