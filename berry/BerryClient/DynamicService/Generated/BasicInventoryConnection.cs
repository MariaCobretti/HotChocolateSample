using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventoryConnection
        : IBasicInventoryConnection
    {
        public BasicInventoryConnection(
            global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory1> nodes)
        {
            Nodes = nodes;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory1> Nodes { get; }
    }
}
