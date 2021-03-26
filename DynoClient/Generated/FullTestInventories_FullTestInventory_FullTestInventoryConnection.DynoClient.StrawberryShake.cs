#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventories_FullTestInventory_FullTestInventoryConnection
        : IFullTestInventories_FullTestInventory_FullTestInventoryConnection
    {
        public FullTestInventories_FullTestInventory_FullTestInventoryConnection(
            global::System.Int32 totalCount,
            global::System.Collections.Generic.IReadOnlyList<IFullTestInventories_FullTestInventory_Nodes?>? nodes)
        {
            TotalCount = totalCount;
            Nodes = nodes;
        }

        public global::System.Int32 TotalCount { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<IFullTestInventories_FullTestInventory_Nodes?>? Nodes { get; } = default!;
    }
}
