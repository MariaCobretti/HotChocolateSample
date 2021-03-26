#nullable enable

namespace DynoClient.DynoClient.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionItemData
    {
        public SelectionItemData(
            global::System.String typename,
            global::System.String? fieldName = null,
            global::System.Guid? selectionItemId = null,
            global::System.String? description = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            FieldName = fieldName;
            SelectionItemId = selectionItemId;
            Description = description;
        }

        public global::System.String __typename { get; }

        public global::System.String? FieldName { get; }

        public global::System.Guid? SelectionItemId { get; }

        public global::System.String? Description { get; }
    }
}
