#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IInventory
    {
        public global::System.Guid DynamicInventoryId { get; }

        public global::System.String FieldName { get; }

        public global::System.String DisplayName { get; }

        public Variant Variant { get; }
    }
}
