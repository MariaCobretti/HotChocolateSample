using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventoryPayload
        : ICreateBasicInventoryPayload
    {
        public CreateBasicInventoryPayload(
            global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory> concreteItems, 
            global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IUserError> errors)
        {
            ConcreteItems = concreteItems;
            Errors = errors;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory> ConcreteItems { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IUserError> Errors { get; }
    }
}
