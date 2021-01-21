using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventoryConnection1
        : IBasicInventoryConnection1
    {
        public BasicInventoryConnection1(
            global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory> nodes)
        {
            Nodes = nodes;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory> Nodes { get; }
    }
}
