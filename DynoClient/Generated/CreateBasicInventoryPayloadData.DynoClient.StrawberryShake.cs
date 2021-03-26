#nullable enable

namespace DynoClient.DynoClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryPayloadData
    {
        public CreateBasicInventoryPayloadData(
            global::System.String typename,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? concreteItems = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            ConcreteItems = concreteItems;
        }

        public global::System.String __typename { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? ConcreteItems { get; }
    }
}
