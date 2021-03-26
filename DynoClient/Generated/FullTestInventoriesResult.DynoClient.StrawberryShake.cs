#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventoriesResult
        : IFullTestInventoriesResult
    {
        public FullTestInventoriesResult(IFullTestInventories_FullTestInventory? fullTestInventory)
        {
            FullTestInventory = fullTestInventory;
        }

        public IFullTestInventories_FullTestInventory? FullTestInventory { get; } = default!;
    }
}
