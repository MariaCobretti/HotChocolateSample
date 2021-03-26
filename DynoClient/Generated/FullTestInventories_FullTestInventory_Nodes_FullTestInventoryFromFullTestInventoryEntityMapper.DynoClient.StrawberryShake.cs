#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper
        : global::StrawberryShake.IEntityMapper<FullTestInventoryEntity, FullTestInventories_FullTestInventory_Nodes_FullTestInventory>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefField_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper;

        public FullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefField_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper));
        }

        public FullTestInventories_FullTestInventory_Nodes_FullTestInventory Map(FullTestInventoryEntity entity)
        {
            return new FullTestInventories_FullTestInventory_Nodes_FullTestInventory(
                entity.DynamicItemId,
                entity.BoolField,
                entity.BoolFieldList,
                entity.BoolFieldNull,
                entity.BoolFieldNullList,
                entity.DateField,
                entity.DateFieldList,
                entity.DateFieldNull,
                entity.DateFieldNullList,
                entity.EnumField,
                entity.EnumFieldList,
                entity.EnumFieldNull,
                entity.EnumFieldNullList,
                entity.NumberField,
                entity.NumberFieldList,
                entity.NumberFieldNull,
                entity.NumberFieldNullList,
                MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefField(entity.RefField),
                MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldListNonNullableArray(entity.RefFieldList),
                MapIFullTestInventories_FullTestInventory_Nodes_RefFieldNull(entity.RefFieldNull),
                MapIFullTestInventories_FullTestInventory_Nodes_RefFieldNullListNonNullableArray(entity.RefFieldNullList));
        }

        private IFullTestInventories_FullTestInventory_Nodes_RefField MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefField(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<IFullTestInventories_FullTestInventory_Nodes_RefFieldList> MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldListNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list)
        {
            var basicInventorys = new global::System.Collections.Generic.List<IFullTestInventories_FullTestInventory_Nodes_RefFieldList>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                basicInventorys.Add(MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldList(child));
            }

            return basicInventorys;
        }

        private IFullTestInventories_FullTestInventory_Nodes_RefFieldList MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldList(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private IFullTestInventories_FullTestInventory_Nodes_RefFieldNull? MapIFullTestInventories_FullTestInventory_Nodes_RefFieldNull(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<IFullTestInventories_FullTestInventory_Nodes_RefFieldNullList>? MapIFullTestInventories_FullTestInventory_Nodes_RefFieldNullListNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list)
        {
            if (list == default)
            {
                return null;
            }

            var basicInventorys = new global::System.Collections.Generic.List<IFullTestInventories_FullTestInventory_Nodes_RefFieldNullList>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                basicInventorys.Add(MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldNullList(child));
            }

            return basicInventorys;
        }

        private IFullTestInventories_FullTestInventory_Nodes_RefFieldNullList MapNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldNullList(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}
