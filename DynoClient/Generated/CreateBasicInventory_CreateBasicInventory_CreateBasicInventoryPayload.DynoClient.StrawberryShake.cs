#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory_CreateBasicInventory_CreateBasicInventoryPayload
        : ICreateBasicInventory_CreateBasicInventory_CreateBasicInventoryPayload
    {
        public CreateBasicInventory_CreateBasicInventory_CreateBasicInventoryPayload(global::System.Collections.Generic.IReadOnlyList<ICreateBasicInventory_CreateBasicInventory_ConcreteItems>? concreteItems)
        {
            ConcreteItems = concreteItems;
        }

        public global::System.Collections.Generic.IReadOnlyList<ICreateBasicInventory_CreateBasicInventory_ConcreteItems>? ConcreteItems { get; } = default!;
    }
}
