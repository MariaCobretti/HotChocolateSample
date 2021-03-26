#nullable enable

namespace DynoClient.DynoClient.State
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SelectionListConnectionData
    {
        public SelectionListConnectionData(
            global::System.String typename,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? nodes = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            Nodes = nodes;
        }

        public global::System.String __typename { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Nodes { get; }
    }
}
