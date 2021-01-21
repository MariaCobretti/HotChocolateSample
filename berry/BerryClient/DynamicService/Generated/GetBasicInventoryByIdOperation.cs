using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetBasicInventoryByIdOperation
        : IOperation<IGetBasicInventoryById>
    {
        public string Name => "GetBasicInventoryById";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetBasicInventoryById);

        public Optional<System.Guid?> ItemId { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (ItemId.HasValue)
            {
                variables.Add(new VariableValue("itemId", "Uuid", ItemId.Value));
            }

            return variables;
        }
    }
}
