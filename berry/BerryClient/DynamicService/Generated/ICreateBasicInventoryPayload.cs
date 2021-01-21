using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface ICreateBasicInventoryPayload
    {
        global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IBasicInventory> ConcreteItems { get; }

        global::System.Collections.Generic.IReadOnlyList<global::BerryClient.IUserError> Errors { get; }
    }
}
