#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory2_CreateBasicInventory_CreateBasicInventoryPayload
        : ICreateBasicInventory2_CreateBasicInventory_CreateBasicInventoryPayload
    {
        public CreateBasicInventory2_CreateBasicInventory_CreateBasicInventoryPayload(global::System.Collections.Generic.IReadOnlyList<ICreateBasicInventory2_CreateBasicInventory_ConcreteItems>? concreteItems)
        {
            ConcreteItems = concreteItems;
        }

        public global::System.Collections.Generic.IReadOnlyList<ICreateBasicInventory2_CreateBasicInventory_ConcreteItems>? ConcreteItems { get; } = default!;
    }
}
