#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionLists_SelectionLists_Nodes_SelectionListFromSelectionListEntityMapper
        : global::StrawberryShake.IEntityMapper<SelectionListEntity, SelectionLists_SelectionLists_Nodes_SelectionList>
    {
        public SelectionLists_SelectionLists_Nodes_SelectionList Map(SelectionListEntity entity)
        {
            return new SelectionLists_SelectionLists_Nodes_SelectionList(
                entity.FieldName,
                entity.SelectionListId,
                entity.DisplayName,
                MapNonNullableISelectionLists_SelectionLists_Nodes_SelectionItemsNonNullableArray(entity.SelectionItems));
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
