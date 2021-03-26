#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventories_BasicInventory_BasicInventoryConnection
        : IBasicInventories_BasicInventory_BasicInventoryConnection
    {
        public BasicInventories_BasicInventory_BasicInventoryConnection(global::System.Collections.Generic.IReadOnlyList<IBasicInventories_BasicInventory_Nodes?>? nodes)
        {
            Nodes = nodes;
        }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<IBasicInventories_BasicInventory_Nodes?>? Nodes { get; } = default!;
    }
}
