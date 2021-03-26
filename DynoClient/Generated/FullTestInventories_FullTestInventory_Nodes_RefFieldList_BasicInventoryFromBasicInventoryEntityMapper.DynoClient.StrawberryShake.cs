#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper
        : global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory>
    {
        public FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory Map(BasicInventoryEntity entity)
        {
            return new FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory(
                entity.DynamicItemId,
                entity.NumberField,
                entity.StringField);
        }
    }
}
