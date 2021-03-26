#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory2Builder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, ICreateBasicInventory2Result>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<ICreateBasicInventory2Result> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Double, global::System.Double> _floatParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;

        public CreateBasicInventory2Builder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<ICreateBasicInventory2Result> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _floatParser = serializerResolver.GetLeafValueParser<global::System.Double, global::System.Double>("Float")
                 ?? throw new global::System.ArgumentException("No serializer for type `Float` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
        }

        public global::StrawberryShake.IOperationResult<ICreateBasicInventory2Result> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (ICreateBasicInventory2Result Result, CreateBasicInventory2ResultInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<ICreateBasicInventory2Result>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null);
        }

        private (ICreateBasicInventory2Result, CreateBasicInventory2ResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();


            var resultInfo = new CreateBasicInventory2ResultInfo(
                DeserializeNonNullableICreateBasicInventory2_CreateBasicInventory(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "createBasicInventory"),
                    entityIds),
                entityIds,
                session.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::DynoClient.DynoClient.State.CreateBasicInventoryPayloadData DeserializeNonNullableICreateBasicInventory2_CreateBasicInventory(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("CreateBasicInventoryPayload", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::DynoClient.DynoClient.State.CreateBasicInventoryPayloadData(
                    typename,
                    concreteItems: UpdateICreateBasicInventory2_CreateBasicInventory_ConcreteItemsEntityNonNullableArray(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "concreteItems"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? UpdateICreateBasicInventory2_CreateBasicInventory_ConcreteItemsEntityNonNullableArray(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var basicInventorys = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                basicInventorys.Add(UpdateNonNullableICreateBasicInventory2_CreateBasicInventory_ConcreteItemsEntity(
                    child,
                    entityIds));
            }

            return basicInventorys;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableICreateBasicInventory2_CreateBasicInventory_ConcreteItemsEntity(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _extractId(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "BasicInventory",
                    global::System.StringComparison.Ordinal))
            {
                BasicInventoryEntity entity = _entityStore.GetOrCreate<BasicInventoryEntity>(entityId);
                entity.DynamicItemId = DeserializeNonNullableGuid(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dynamicItemId"));
                entity.NumberField = DeserializeDouble(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "numberField"));
                entity.StringField = DeserializeString(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "stringField"));

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.Double? DeserializeDouble(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _floatParser.Parse(obj.Value.GetDouble()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }
}
