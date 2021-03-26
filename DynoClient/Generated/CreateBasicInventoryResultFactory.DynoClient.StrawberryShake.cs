#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<CreateBasicInventoryResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, CreateBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventory> _createBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper;

        public CreateBasicInventoryResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, CreateBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventory> createBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _createBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper = createBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(createBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper));
        }

        public CreateBasicInventoryResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is CreateBasicInventoryResultInfo info)
            {
                return new CreateBasicInventoryResult(MapNonNullableICreateBasicInventory_CreateBasicInventory(info.CreateBasicInventory));
            }

            throw new global::System.ArgumentException("CreateBasicInventoryResultInfo expected.");
        }

        private ICreateBasicInventory_CreateBasicInventory MapNonNullableICreateBasicInventory_CreateBasicInventory(global::DynoClient.DynoClient.State.CreateBasicInventoryPayloadData data)
        {
            ICreateBasicInventory_CreateBasicInventory returnValue = default!;

            if (data.__typename.Equals(
                    "CreateBasicInventoryPayload",
                    global::System.StringComparison.Ordinal))
            {
                returnValue = new CreateBasicInventory_CreateBasicInventory_CreateBasicInventoryPayload(MapICreateBasicInventory_CreateBasicInventory_ConcreteItemsNonNullableArray(data.ConcreteItems));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<ICreateBasicInventory_CreateBasicInventory_ConcreteItems>? MapICreateBasicInventory_CreateBasicInventory_ConcreteItemsNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list)
        {
            if (list == default)
            {
                return null;
            }

            var basicInventorys = new global::System.Collections.Generic.List<ICreateBasicInventory_CreateBasicInventory_ConcreteItems>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                basicInventorys.Add(MapNonNullableICreateBasicInventory_CreateBasicInventory_ConcreteItems(child));
            }

            return basicInventorys;
        }

        private ICreateBasicInventory_CreateBasicInventory_ConcreteItems MapNonNullableICreateBasicInventory_CreateBasicInventory_ConcreteItems(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _createBasicInventory_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}
