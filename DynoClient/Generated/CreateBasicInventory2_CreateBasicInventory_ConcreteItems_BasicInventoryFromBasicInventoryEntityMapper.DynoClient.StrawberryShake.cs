﻿#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper
        : global::StrawberryShake.IEntityMapper<BasicInventoryEntity, CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory>
    {
        public CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory Map(BasicInventoryEntity entity)
        {
            return new CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory(
                entity.DynamicItemId,
                entity.NumberField,
                entity.StringField);
        }
    }
}
