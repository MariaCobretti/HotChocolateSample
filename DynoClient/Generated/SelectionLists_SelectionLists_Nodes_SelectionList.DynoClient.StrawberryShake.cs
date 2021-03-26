#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionLists_SelectionLists_Nodes_SelectionList
        : ISelectionLists_SelectionLists_Nodes_SelectionList
    {
        public SelectionLists_SelectionLists_Nodes_SelectionList(
            global::System.String fieldName,
            global::System.Guid selectionListId,
            global::System.String displayName,
            global::System.Collections.Generic.IReadOnlyList<ISelectionLists_SelectionLists_Nodes_SelectionItems> selectionItems)
        {
            FieldName = fieldName;
            SelectionListId = selectionListId;
            DisplayName = displayName;
            SelectionItems = selectionItems;
        }

        public global::System.String FieldName { get; }

        public global::System.Guid SelectionListId { get; }

        public global::System.String DisplayName { get; }

        public global::System.Collections.Generic.IReadOnlyList<ISelectionLists_SelectionLists_Nodes_SelectionItems> SelectionItems { get; }
    }
}
