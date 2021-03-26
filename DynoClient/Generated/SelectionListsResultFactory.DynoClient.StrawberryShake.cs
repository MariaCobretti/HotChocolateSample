#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionListsResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<SelectionListsResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<SelectionListEntity, SelectionLists_SelectionLists_Nodes_SelectionList> _selectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper;

        public SelectionListsResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<SelectionListEntity, SelectionLists_SelectionLists_Nodes_SelectionList> selectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _selectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper = selectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(selectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper));
        }

        public SelectionListsResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is SelectionListsResultInfo info)
            {
                return new SelectionListsResult(MapISelectionLists_SelectionLists(info.SelectionLists));
            }

            throw new global::System.ArgumentException("SelectionListsResultInfo expected.");
        }

        private ISelectionLists_SelectionLists? MapISelectionLists_SelectionLists(global::DynoClient.DynoClient.State.SelectionListConnectionData data)
        {
            if (data == default)
            {
                return null;
            }

            ISelectionLists_SelectionLists returnValue = default!;

            if (data?.__typename.Equals(
                    "SelectionListConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new SelectionLists_SelectionLists_SelectionListConnection(MapISelectionLists_SelectionLists_NodesArray(data.Nodes));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<ISelectionLists_SelectionLists_Nodes?>? MapISelectionLists_SelectionLists_NodesArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list)
        {
            if (list == default)
            {
                return null;
            }

            var selectionLists = new global::System.Collections.Generic.List<ISelectionLists_SelectionLists_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                selectionLists.Add(MapISelectionLists_SelectionLists_Nodes(child));
            }

            return selectionLists;
        }

        private ISelectionLists_SelectionLists_Nodes? MapISelectionLists_SelectionLists_Nodes(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "SelectionList",
                    global::System.StringComparison.Ordinal))
            {
                return _selectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper.Map(
                    _entityStore.GetEntity<SelectionListEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<ISelectionLists_SelectionLists_Nodes_SelectionItems> MapNonNullableISelectionLists_SelectionLists_Nodes_SelectionItemsNonNullableArray(global::System.Collections.Generic.IReadOnlyList<global::DynoClient.DynoClient.State.SelectionItemData>? list)
        {
            var selectionItems = new global::System.Collections.Generic.List<ISelectionLists_SelectionLists_Nodes_SelectionItems>();

            foreach (global::DynoClient.DynoClient.State.SelectionItemData child in list)
            {
                selectionItems.Add(MapNonNullableISelectionLists_SelectionLists_Nodes_SelectionItems(child));
            }

            return selectionItems;
        }

        private ISelectionLists_SelectionLists_Nodes_SelectionItems MapNonNullableISelectionLists_SelectionLists_Nodes_SelectionItems(global::DynoClient.DynoClient.State.SelectionItemData data)
        {
            ISelectionLists_SelectionLists_Nodes_SelectionItems returnValue = default!;

            if (data.__typename.Equals(
                    "SelectionItem",
                    global::System.StringComparison.Ordinal))
            {
                returnValue = new SelectionLists_SelectionLists_Nodes_SelectionItems_SelectionItem(
                    data.FieldName ?? throw new global::System.ArgumentNullException(),
                    data.SelectionItemId ?? throw new global::System.ArgumentNullException(),
                    data.Description ?? throw new global::System.ArgumentNullException());
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }
    }
}
