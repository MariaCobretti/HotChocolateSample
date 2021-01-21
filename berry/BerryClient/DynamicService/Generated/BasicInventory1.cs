using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventory1
        : IBasicInventory
    {
        public BasicInventory1(
            global::BerryClient.IBasicInventoryConnection basicInventory)
        {
            BasicInventory = basicInventory;
        }

        public global::BerryClient.IBasicInventoryConnection BasicInventory { get; }
    }
}
