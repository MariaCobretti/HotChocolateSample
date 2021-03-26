#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventoriesBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IFullTestInventoriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<IFullTestInventoriesResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::DynoClient.DynoClient.Stocks> _stocksParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Boolean, global::System.Boolean> _booleanParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.DateTimeOffset> _dateTimeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Double, global::System.Double> _floatParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public FullTestInventoriesBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<IFullTestInventoriesResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stocksParser = serializerResolver.GetLeafValueParser<global::System.String, global::DynoClient.DynoClient.Stocks>("Stocks")
                 ?? throw new global::System.ArgumentException("No serializer for type `Stocks` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
            _booleanParser = serializerResolver.GetLeafValueParser<global::System.Boolean, global::System.Boolean>("Boolean")
                 ?? throw new global::System.ArgumentException("No serializer for type `Boolean` found.");
            _dateTimeParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.DateTimeOffset>("DateTime")
                 ?? throw new global::System.ArgumentException("No serializer for type `DateTime` found.");
            _floatParser = serializerResolver.GetLeafValueParser<global::System.Double, global::System.Double>("Float")
                 ?? throw new global::System.ArgumentException("No serializer for type `Float` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IFullTestInventoriesResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IFullTestInventoriesResult Result, FullTestInventoriesResultInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<IFullTestInventoriesResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null);
        }

        private (IFullTestInventoriesResult, FullTestInventoriesResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();


            var resultInfo = new FullTestInventoriesResultInfo(
                DeserializeIFullTestInventories_FullTestInventory(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "fullTestInventory"),
                    entityIds),
                entityIds,
                session.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::DynoClient.DynoClient.State.FullTestInventoryConnectionData? DeserializeIFullTestInventories_FullTestInventory(
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

            if (typename?.Equals("FullTestInventoryConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::DynoClient.DynoClient.State.FullTestInventoryConnectionData(
                    typename,
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")),
                    nodes: UpdateIFullTestInventories_FullTestInventory_NodesEntityArray(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "nodes"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIFullTestInventories_FullTestInventory_NodesEntityArray(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var fullTestInventorys = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                fullTestInventorys.Add(UpdateIFullTestInventories_FullTestInventory_NodesEntity(
                    child,
                    entityIds));
            }

            return fullTestInventorys;
        }

        private global::StrawberryShake.EntityId? UpdateIFullTestInventories_FullTestInventory_NodesEntity(
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
                    "FullTestInventory",
                    global::System.StringComparison.Ordinal))
            {
                FullTestInventoryEntity entity = _entityStore.GetOrCreate<FullTestInventoryEntity>(entityId);
                entity.DynamicItemId = DeserializeNonNullableGuid(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dynamicItemId"));
                entity.BoolField = DeserializeNonNullableBoolean(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "boolField"));
                entity.BoolFieldList = DeserializeNonNullableBooleanNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "boolFieldList"));
                entity.BoolFieldNull = DeserializeBoolean(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "boolFieldNull"));
                entity.BoolFieldNullList = DeserializeBooleanNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "boolFieldNullList"));
                entity.DateField = DeserializeNonNullableDateTimeOffset(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dateField"));
                entity.DateFieldList = DeserializeNonNullableDateTimeOffsetNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dateFieldList"));
                entity.DateFieldNull = DeserializeDateTimeOffset(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dateFieldNull"));
                entity.DateFieldNullList = DeserializeDateTimeOffsetNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "dateFieldNullList"));
                entity.EnumField = DeserializeNonNullableStocks(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "enumField"));
                entity.EnumFieldList = DeserializeNonNullableStocksNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "enumFieldList"));
                entity.EnumFieldNull = DeserializeStocks(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "enumFieldNull"));
                entity.EnumFieldNullList = DeserializeStocksNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "enumFieldNullList"));
                entity.NumberField = DeserializeNonNullableDouble(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "numberField"));
                entity.NumberFieldList = DeserializeNonNullableDoubleNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "numberFieldList"));
                entity.NumberFieldNull = DeserializeDouble(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "numberFieldNull"));
                entity.NumberFieldNullList = DeserializeDoubleNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "numberFieldNullList"));
                entity.RefField = UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldEntity(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "refField"),
                    entityIds);
                entity.RefFieldList = UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldListEntityNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "refFieldList"),
                    entityIds);
                entity.RefFieldNull = UpdateIFullTestInventories_FullTestInventory_Nodes_RefFieldNullEntity(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "refFieldNull"),
                    entityIds);
                entity.RefFieldNullList = UpdateIFullTestInventories_FullTestInventory_Nodes_RefFieldNullListEntityNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "refFieldNullList"),
                    entityIds);

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

        private global::System.Boolean DeserializeNonNullableBoolean(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _booleanParser.Parse(obj.Value.GetBoolean()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::System.Boolean> DeserializeNonNullableBooleanNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var booleans = new global::System.Collections.Generic.List<global::System.Boolean>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                booleans.Add(DeserializeNonNullableBoolean(child));
            }

            return booleans;
        }

        private global::System.Boolean? DeserializeBoolean(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _booleanParser.Parse(obj.Value.GetBoolean()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::System.Boolean>? DeserializeBooleanNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var booleans = new global::System.Collections.Generic.List<global::System.Boolean>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                booleans.Add(DeserializeNonNullableBoolean(child));
            }

            return booleans;
        }

        private global::System.DateTimeOffset DeserializeNonNullableDateTimeOffset(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _dateTimeParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::System.DateTimeOffset> DeserializeNonNullableDateTimeOffsetNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var dateTimes = new global::System.Collections.Generic.List<global::System.DateTimeOffset>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                dateTimes.Add(DeserializeNonNullableDateTimeOffset(child));
            }

            return dateTimes;
        }

        private global::System.DateTimeOffset? DeserializeDateTimeOffset(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _dateTimeParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::System.DateTimeOffset>? DeserializeDateTimeOffsetNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var dateTimes = new global::System.Collections.Generic.List<global::System.DateTimeOffset>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                dateTimes.Add(DeserializeNonNullableDateTimeOffset(child));
            }

            return dateTimes;
        }

        private Stocks DeserializeNonNullableStocks(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stocksParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<Stocks> DeserializeNonNullableStocksNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var stockss = new global::System.Collections.Generic.List<Stocks>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                stockss.Add(DeserializeNonNullableStocks(child));
            }

            return stockss;
        }

        private Stocks? DeserializeStocks(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stocksParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<Stocks>? DeserializeStocksNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var stockss = new global::System.Collections.Generic.List<Stocks>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                stockss.Add(DeserializeNonNullableStocks(child));
            }

            return stockss;
        }

        private global::System.Double DeserializeNonNullableDouble(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _floatParser.Parse(obj.Value.GetDouble()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::System.Double> DeserializeNonNullableDoubleNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var floats = new global::System.Collections.Generic.List<global::System.Double>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                floats.Add(DeserializeNonNullableDouble(child));
            }

            return floats;
        }

        private global::System.Double? DeserializeDouble(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _floatParser.Parse(obj.Value.GetDouble()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::System.Double>? DeserializeDoubleNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var floats = new global::System.Collections.Generic.List<global::System.Double>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                floats.Add(DeserializeNonNullableDouble(child));
            }

            return floats;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldEntity(
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

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldListEntityNonNullableArray(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var basicInventorys = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                basicInventorys.Add(UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldListEntity(
                    child,
                    entityIds));
            }

            return basicInventorys;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldListEntity(
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

        private global::StrawberryShake.EntityId? UpdateIFullTestInventories_FullTestInventory_Nodes_RefFieldNullEntity(
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

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? UpdateIFullTestInventories_FullTestInventory_Nodes_RefFieldNullListEntityNonNullableArray(
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
                basicInventorys.Add(UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldNullListEntity(
                    child,
                    entityIds));
            }

            return basicInventorys;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIFullTestInventories_FullTestInventory_Nodes_RefFieldNullListEntity(
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
    }
}
