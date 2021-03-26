#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory2ResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<CreateBasicInventory2Result>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<BasicInventoryEntity, CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory> _createBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper;

        public CreateBasicInventory2ResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<BasicInventoryEntity, CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory> createBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _createBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper = createBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(createBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper));
        }

        public CreateBasicInventory2Result Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is CreateBasicInventory2ResultInfo info)
            {
                return new CreateBasicInventory2Result(MapNonNullableICreateBasicInventory2_CreateBasicInventory(info.CreateBasicInventory));
            }

            throw new global::System.ArgumentException("CreateBasicInventory2ResultInfo expected.");
        }

        private ICreateBasicInventory2_CreateBasicInventory MapNonNullableICreateBasicInventory2_CreateBasicInventory(global::DynoClient.DynoClient.State.CreateBasicInventoryPayloadData data)
        {
            ICreateBasicInventory2_CreateBasicInventory returnValue = default!;

            if (data.__typename.Equals(
                    "CreateBasicInventoryPayload",
                    global::System.StringComparison.Ordinal))
            {
                returnValue = new CreateBasicInventory2_CreateBasicInventory_CreateBasicInventoryPayload(MapICreateBasicInventory2_CreateBasicInventory_ConcreteItemsNonNullableArray(data.ConcreteItems));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<ICreateBasicInventory2_CreateBasicInventory_ConcreteItems>? MapICreateBasicInventory2_CreateBasicInventory_ConcreteItemsNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list)
        {
            if (list == default)
            {
                return null;
            }

            var basicInventorys = new global::System.Collections.Generic.List<ICreateBasicInventory2_CreateBasicInventory_ConcreteItems>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                basicInventorys.Add(MapNonNullableICreateBasicInventory2_CreateBasicInventory_ConcreteItems(child));
            }

            return basicInventorys;
        }

        private ICreateBasicInventory2_CreateBasicInventory_ConcreteItems MapNonNullableICreateBasicInventory2_CreateBasicInventory_ConcreteItems(global::StrawberryShake.EntityId entityId)
        {

            if (entityId.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                return _createBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventoryFromBasicInventoryEntityMapper.Map(
                    _entityStore.GetEntity<BasicInventoryEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}
