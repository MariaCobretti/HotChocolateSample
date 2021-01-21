using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryOperation
        : IOperation<ICreateBasicInventory>
    {
        public string Name => "CreateBasicInventory";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Mutation;

        public Type ResultType => typeof(ICreateBasicInventory);

        public Optional<string> StringInput { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (StringInput.HasValue)
            {
                variables.Add(new VariableValue("stringInput", "String", StringInput.Value));
            }

            return variables;
        }
    }
}
