#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper
        : global::StrawberryShake.IEntityMapper<DynamicInventoryEntity, Inventories_DynamicInventories_Nodes_DynamicInventory>
    {
        public Inventories_DynamicInventories_Nodes_DynamicInventory Map(DynamicInventoryEntity entity)
        {
            return new Inventories_DynamicInventories_Nodes_DynamicInventory(
                entity.DynamicInventoryId,
                entity.FieldName,
                entity.DisplayName,
                entity.Variant);
        }
    }
}
