#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventoriesResult
        : IBasicInventoriesResult
    {
        public BasicInventoriesResult(IBasicInventories_BasicInventory? basicInventory)
        {
            BasicInventory = basicInventory;
        }

        public IBasicInventories_BasicInventory? BasicInventory { get; } = default!;
    }
}
