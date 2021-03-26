#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Inventories_DynamicInventories_DynamicInventoryConnection
        : IInventories_DynamicInventories_DynamicInventoryConnection
    {
        public Inventories_DynamicInventories_DynamicInventoryConnection(global::System.Collections.Generic.IReadOnlyList<IInventories_DynamicInventories_Nodes?>? nodes)
        {
            Nodes = nodes;
        }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<IInventories_DynamicInventories_Nodes?>? Nodes { get; } = default!;
    }
}
