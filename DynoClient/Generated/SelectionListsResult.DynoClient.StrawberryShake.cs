#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionListsResult
        : ISelectionListsResult
    {
        public SelectionListsResult(ISelectionLists_SelectionLists? selectionLists)
        {
            SelectionLists = selectionLists;
        }

        public ISelectionLists_SelectionLists? SelectionLists { get; } = default!;
    }
}
