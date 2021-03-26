#nullable enable

namespace DynoClient.DynoClient.State
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventoryConnectionData
    {
        public FullTestInventoryConnectionData(
            global::System.String typename,
            global::System.Int32? totalCount = null,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? nodes = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            TotalCount = totalCount;
            Nodes = nodes;
        }

        public global::System.String __typename { get; }

        public global::System.Int32? TotalCount { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Nodes { get; }
    }
}
