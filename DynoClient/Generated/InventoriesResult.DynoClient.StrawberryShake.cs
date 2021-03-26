#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class InventoriesResult
        : IInventoriesResult
    {
        public InventoriesResult(IInventories_DynamicInventories? dynamicInventories)
        {
            DynamicInventories = dynamicInventories;
        }

        public IInventories_DynamicInventories? DynamicInventories { get; } = default!;
    }
}
