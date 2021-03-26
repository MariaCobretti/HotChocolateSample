#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Inventories_DynamicInventories_Nodes_DynamicInventory
        : IInventories_DynamicInventories_Nodes_DynamicInventory
    {
        public Inventories_DynamicInventories_Nodes_DynamicInventory(
            global::System.Guid dynamicInventoryId,
            global::System.String fieldName,
            global::System.String displayName,
            Variant variant)
        {
            DynamicInventoryId = dynamicInventoryId;
            FieldName = fieldName;
            DisplayName = displayName;
            Variant = variant;
        }

        public global::System.Guid DynamicInventoryId { get; }

        public global::System.String FieldName { get; }

        public global::System.String DisplayName { get; }

        public Variant Variant { get; }
    }
}
