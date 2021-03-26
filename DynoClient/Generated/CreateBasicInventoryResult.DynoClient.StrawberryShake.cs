#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryResult
        : ICreateBasicInventoryResult
    {
        public CreateBasicInventoryResult(ICreateBasicInventory_CreateBasicInventory createBasicInventory)
        {
            CreateBasicInventory = createBasicInventory;
        }

        public ICreateBasicInventory_CreateBasicInventory CreateBasicInventory { get; }
    }
}
