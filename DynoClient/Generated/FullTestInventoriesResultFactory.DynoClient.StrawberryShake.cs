#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventoriesResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<FullTestInventoriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<FullTestInventoryEntity, FullTestInventories_FullTestInventory_Nodes_FullTestInventory> _fullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefField_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventory> _fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper;

        public FullTestInventoriesResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<FullTestInventoryEntity, FullTestInventories_FullTestInventory_Nodes_FullTestInventory> fullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefField_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, FullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventory> fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _fullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefField_BasicInventoryFromBasicInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefFieldList_BasicInventoryFromBasicInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefFieldNull_BasicInventoryFromBasicInventoryEntityMapper));
            _fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper = fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories_FullTestInventory_Nodes_RefFieldNullList_BasicInventoryFromBasicInventoryEntityMapper));
        }

        public FullTestInventoriesResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is FullTestInventoriesResultInfo info)
            {
                return new FullTestInventoriesResult(MapIFullTestInventories_FullTestInventory(info.FullTestInventory));
            }

            throw new global::System.ArgumentException("FullTestInventoriesResultInfo expected.");
        }

        private IFullTestInventories_FullTestInventory? MapIFullTestInventories_FullTestInventory(global::DynoClient.DynoClient.State.FullTestInventoryConnectionData data)
        {
            if (data == default)
            {
                return null;
            }

            IFullTestInventories_FullTestInventory returnValue = default!;

            if (data?.__typename.Equals(
                    "FullTestInventoryConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new FullTestInventories_FullTestInventory_FullTestInventoryConnection(
                    data.TotalCount ?? throw new global::System.ArgumentNullException(),
                    MapIFullTestInventories_FullTestInventory_NodesArray(data.Nodes));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<IFullTestInventories_FullTestInventory_Nodes?>? MapIFullTestInventories_FullTestInventory_NodesArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list)
        {
            if (list == default)
            {
                return null;
            }

            var fullTestInventorys = new global::System.Collections.Generic.List<IFullTestInventories_FullTestInventory_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                fullTestInventorys.Add(MapIFullTestInventories_FullTestInventory_Nodes(child));
            }

            return fullTestInventorys;
        }

        private IFullTestInventories_FullTestInventory_Nodes? MapIFullTestInventories_FullTestInventory_Nodes(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "FullTestInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _fullTestInventories_FullTestInventory_Nodes_FullTestInventoryFromFullTestInventoryEntityMapper.Map(
                    _entityStore.GetEntity<FullTestInventoryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
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
