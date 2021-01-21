using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory1
        : ICreateBasicInventory
    {
        public CreateBasicInventory1(
            global::BerryClient.ICreateBasicInventoryPayload createBasicInventory)
        {
            CreateBasicInventory = createBasicInventory;
        }

        public global::BerryClient.ICreateBasicInventoryPayload CreateBasicInventory { get; }
    }
}
