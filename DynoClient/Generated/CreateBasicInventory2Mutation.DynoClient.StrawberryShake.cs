#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the CreateBasicInventory2 GraphQL operation
    /// <code>
    /// mutation CreateBasicInventory2($input: [CreateBasicInventoryInput!]!) {
    ///   createBasicInventory(input: $input) {
    ///     __typename
    ///     concreteItems {
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
    public partial class CreateBasicInventory2Mutation
    {
        private readonly global::StrawberryShake.IOperationExecutor<ICreateBasicInventory2Result> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _createBasicInventoryInputFormatter;

        public CreateBasicInventory2Mutation(
            global::StrawberryShake.IOperationExecutor<ICreateBasicInventory2Result> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _createBasicInventoryInputFormatter = serializerResolver.GetInputValueFormatter("CreateBasicInventoryInput");
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<ICreateBasicInventory2Result>> ExecuteAsync(
            global::System.Collections.Generic.IReadOnlyList<CreateBasicInventoryInput> input,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(input);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<ICreateBasicInventory2Result>> Watch(
            global::System.Collections.Generic.IReadOnlyList<CreateBasicInventoryInput> input,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(input);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyList<CreateBasicInventoryInput> input)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "input",
                FormatInput(input));

            return new global::StrawberryShake.OperationRequest(
                "CreateBasicInventory2",
                CreateBasicInventory2MutationDocument.Instance,
                variables);
        }

        private global::System.Object? FormatInput(global::System.Collections.Generic.IReadOnlyList<CreateBasicInventoryInput> value)
        {
            if (value == default)
            {
                return null;
            }

            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                if (value_elm == default)
                {
                    value_list.Add(null);
                    continue;
                }

                value_list.Add(_createBasicInventoryInputFormatter.Format(value_elm));
            }
            return value_list;
        }
    }
}
