#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionListsBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, ISelectionListsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<ISelectionListsResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;

        public SelectionListsBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<ISelectionListsResult> resultDataFactory,
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
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
        }

        public global::StrawberryShake.IOperationResult<ISelectionListsResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (ISelectionListsResult Result, SelectionListsResultInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<ISelectionListsResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null);
        }

        private (ISelectionListsResult, SelectionListsResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();


            var resultInfo = new SelectionListsResultInfo(
                DeserializeISelectionLists_SelectionLists(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "selectionLists"),
                    entityIds),
                entityIds,
                session.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::DynoClient.DynoClient.State.SelectionListConnectionData? DeserializeISelectionLists_SelectionLists(
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

            if (typename?.Equals("SelectionListConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::DynoClient.DynoClient.State.SelectionListConnectionData(
                    typename,
                    nodes: UpdateISelectionLists_SelectionLists_NodesEntityArray(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "nodes"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateISelectionLists_SelectionLists_NodesEntityArray(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var selectionLists = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                selectionLists.Add(UpdateISelectionLists_SelectionLists_NodesEntity(
                    child,
                    entityIds));
            }

            return selectionLists;
        }

        private global::StrawberryShake.EntityId? UpdateISelectionLists_SelectionLists_NodesEntity(
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
                    "SelectionList",
                    global::System.StringComparison.Ordinal))
            {
                SelectionListEntity entity = _entityStore.GetOrCreate<SelectionListEntity>(entityId);
                entity.FieldName = DeserializeNonNullableString(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "fieldName"));
                entity.SelectionListId = DeserializeNonNullableGuid(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "selectionListId"));
                entity.DisplayName = DeserializeNonNullableString(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "displayName"));
                entity.SelectionItems = DeserializeNonNullableISelectionLists_SelectionLists_Nodes_SelectionItemsNonNullableArray(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "selectionItems"));

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::DynoClient.DynoClient.State.SelectionItemData> DeserializeNonNullableISelectionLists_SelectionLists_Nodes_SelectionItemsNonNullableArray(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var selectionItems = new global::System.Collections.Generic.List<global::DynoClient.DynoClient.State.SelectionItemData>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                selectionItems.Add(DeserializeNonNullableISelectionLists_SelectionLists_Nodes_SelectionItems(child));
            }

            return selectionItems;
        }

        private global::DynoClient.DynoClient.State.SelectionItemData DeserializeNonNullableISelectionLists_SelectionLists_Nodes_SelectionItems(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("SelectionItem", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::DynoClient.DynoClient.State.SelectionItemData(
                    typename,
                    fieldName: DeserializeNonNullableString(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "fieldName")),
                    selectionItemId: DeserializeNonNullableGuid(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "selectionItemId")),
                    description: DeserializeString(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "description")));
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
    }
}
