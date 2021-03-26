#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionLists_SelectionLists_Nodes_SelectionItems_SelectionItem
        : ISelectionLists_SelectionLists_Nodes_SelectionItems_SelectionItem
    {
        public SelectionLists_SelectionLists_Nodes_SelectionItems_SelectionItem(
            global::System.String fieldName,
            global::System.Guid selectionItemId,
            global::System.String? description)
        {
            FieldName = fieldName;
            SelectionItemId = selectionItemId;
            Description = description;
        }

        public global::System.String FieldName { get; }

        public global::System.Guid SelectionItemId { get; }

        public global::System.String? Description { get; } = default!;
    }
}
