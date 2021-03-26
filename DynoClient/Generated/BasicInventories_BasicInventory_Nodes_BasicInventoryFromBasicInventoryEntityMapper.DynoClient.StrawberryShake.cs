#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper
        : global::StrawberryShake.IEntityMapper<BasicInventoryEntity, BasicInventories_BasicInventory_Nodes_BasicInventory>
    {
        public BasicInventories_BasicInventory_Nodes_BasicInventory Map(BasicInventoryEntity entity)
        {
            return new BasicInventories_BasicInventory_Nodes_BasicInventory(
                entity.DynamicItemId,
                entity.NumberField,
                entity.StringField);
        }
    }
}
