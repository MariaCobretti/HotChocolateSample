#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class InventoriesBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IInventoriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<IInventoriesResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::DynoClient.DynoClient.Variant> _variantParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public InventoriesBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<IInventoriesResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _variantParser = serializerResolver.GetLeafValueParser<global::System.String, global::DynoClient.DynoClient.Variant>("Variant")
                 ?? throw new global::System.ArgumentException("No serializer for type `Variant` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IInventoriesResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IInventoriesResult Result, InventoriesResultInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<IInventoriesResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null);
        }

        private (IInventoriesResult, InventoriesResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();


            var resultInfo = new InventoriesResultInfo(
                DeserializeIInventories_DynamicInventories(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dynamicInventories"),
                    entityIds),
                entityIds,
                session.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::DynoClient.DynoClient.State.DynamicInventoryConnectionData? DeserializeIInventories_DynamicInventories(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("DynamicInventoryConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::DynoClient.DynoClient.State.DynamicInventoryConnectionData(
                    typename,
                    nodes: UpdateIInventories_DynamicInventories_NodesEntityArray(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "nodes"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIInventories_DynamicInventories_NodesEntityArray(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var dynamicInventorys = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                dynamicInventorys.Add(UpdateIInventories_DynamicInventories_NodesEntity(
                    child,
                    entityIds));
            }

            return dynamicInventorys;
        }

        private global::StrawberryShake.EntityId? UpdateIInventories_DynamicInventories_NodesEntity(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _extractId(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "DynamicInventory",
                    global::System.StringComparison.Ordinal))
            {
                DynamicInventoryEntity entity = _entityStore.GetOrCreate<DynamicInventoryEntity>(entityId);
                entity.DynamicInventoryId = DeserializeNonNullableGuid(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dynamicInventoryId"));
                entity.FieldName = DeserializeNonNullableString(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "fieldName"));
                entity.DisplayName = DeserializeNonNullableString(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "displayName"));
                entity.Variant = DeserializeNonNullableVariant(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "variant"));

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

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private Variant DeserializeNonNullableVariant(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _variantParser.Parse(obj.Value.GetString()!);
        }
    }
}
