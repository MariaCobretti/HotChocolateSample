#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class InventoriesResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<InventoriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<DynamicInventoryEntity, Inventories_DynamicInventories_Nodes_DynamicInventory> _inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper;

        public InventoriesResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<DynamicInventoryEntity, Inventories_DynamicInventories_Nodes_DynamicInventory> inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper = inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper));
        }

        public InventoriesResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is InventoriesResultInfo info)
            {
                return new InventoriesResult(MapIInventories_DynamicInventories(info.DynamicInventories));
            }

            throw new global::System.ArgumentException("InventoriesResultInfo expected.");
        }

        private IInventories_DynamicInventories? MapIInventories_DynamicInventories(global::DynoClient.DynoClient.State.DynamicInventoryConnectionData data)
        {
            if (data == default)
            {
                return null;
            }

            IInventories_DynamicInventories returnValue = default!;

            if (data?.__typename.Equals(
                    "DynamicInventoryConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new Inventories_DynamicInventories_DynamicInventoryConnection(MapIInventories_DynamicInventories_NodesArray(data.Nodes));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<IInventories_DynamicInventories_Nodes?>? MapIInventories_DynamicInventories_NodesArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list)
        {
            if (list == default)
            {
                return null;
            }

            var dynamicInventorys = new global::System.Collections.Generic.List<IInventories_DynamicInventories_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                dynamicInventorys.Add(MapIInventories_DynamicInventories_Nodes(child));
            }

            return dynamicInventorys;
        }

        private IInventories_DynamicInventories_Nodes? MapIInventories_DynamicInventories_Nodes(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "DynamicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _inventories_DynamicInventories_Nodes_DynamicInventoryFromDynamicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<DynamicInventoryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}
