#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the operation service of the CreateBasicInventory GraphQL operation
    /// <code>
    /// mutation CreateBasicInventory($numberField: Float, $stringField: String) {
    ///   createBasicInventory(input: { numberField: $numberField, stringField: $stringField }) {
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
    public partial class CreateBasicInventoryMutation
    {
        private readonly global::StrawberryShake.IOperationExecutor<ICreateBasicInventoryResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _floatFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter;

        public CreateBasicInventoryMutation(
            global::StrawberryShake.IOperationExecutor<ICreateBasicInventoryResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _floatFormatter = serializerResolver.GetInputValueFormatter("Float");
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<ICreateBasicInventoryResult>> ExecuteAsync(
            global::System.Double? numberField,
            global::System.String? stringField,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                numberField,
                stringField);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<ICreateBasicInventoryResult>> Watch(
            global::System.Double? numberField,
            global::System.String? stringField,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                numberField,
                stringField);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            global::System.Double? numberField,
            global::System.String? stringField)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "numberField",
                FormatNumberField(numberField));
            variables.Add(
                "stringField",
                FormatStringField(stringField));

            return new global::StrawberryShake.OperationRequest(
                "CreateBasicInventory",
                CreateBasicInventoryMutationDocument.Instance,
                variables);
        }

        private global::System.Object? FormatNumberField(global::System.Double? value)
        {
            return _floatFormatter.Format(value);
        }

        private global::System.Object? FormatStringField(global::System.String? value)
        {
            return _stringFormatter.Format(value);
        }
    }
}
