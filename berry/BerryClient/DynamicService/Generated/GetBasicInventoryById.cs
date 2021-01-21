using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetBasicInventoryById
        : IGetBasicInventoryById
    {
        public GetBasicInventoryById(
            global::BerryClient.IBasicInventoryConnection1 basicInventory)
        {
            BasicInventory = basicInventory;
        }

        public global::BerryClient.IBasicInventoryConnection1 BasicInventory { get; }
    }
}
