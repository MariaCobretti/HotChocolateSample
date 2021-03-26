#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionLists_SelectionLists_SelectionListConnection
        : ISelectionLists_SelectionLists_SelectionListConnection
    {
        public SelectionLists_SelectionLists_SelectionListConnection(global::System.Collections.Generic.IReadOnlyList<ISelectionLists_SelectionLists_Nodes?>? nodes)
        {
            Nodes = nodes;
        }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<ISelectionLists_SelectionLists_Nodes?>? Nodes { get; } = default!;
    }
}
