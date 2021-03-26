#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventoriesResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<BasicInventoriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, BasicInventories_BasicInventory_Nodes_BasicInventory> _basicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper;

        public BasicInventoriesResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, BasicInventories_BasicInventory_Nodes_BasicInventory> basicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _basicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper = basicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(basicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper));
        }

        public BasicInventoriesResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is BasicInventoriesResultInfo info)
            {
                return new BasicInventoriesResult(MapIBasicInventories_BasicInventory(info.BasicInventory));
            }

            throw new global::System.ArgumentException("BasicInventoriesResultInfo expected.");
        }

        private IBasicInventories_BasicInventory? MapIBasicInventories_BasicInventory(global::DynoClient.DynoClient.State.BasicInventoryConnectionData data)
        {
            if (data == default)
            {
                return null;
            }

            IBasicInventories_BasicInventory returnValue = default!;

            if (data?.__typename.Equals(
                    "BasicInventoryConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new BasicInventories_BasicInventory_BasicInventoryConnection(MapIBasicInventories_BasicInventory_NodesArray(data.Nodes));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<IBasicInventories_BasicInventory_Nodes?>? MapIBasicInventories_BasicInventory_NodesArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list)
        {
            if (list == default)
            {
                return null;
            }

            var basicInventorys = new global::System.Collections.Generic.List<IBasicInventories_BasicInventory_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                basicInventorys.Add(MapIBasicInventories_BasicInventory_Nodes(child));
            }

            return basicInventorys;
        }

        private IBasicInventories_BasicInventory_Nodes? MapIBasicInventories_BasicInventory_Nodes(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _basicInventories_BasicInventory_Nodes_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}
