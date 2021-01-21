using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class BasicInventory
        : IBasicInventory
    {
        public BasicInventory(
            System.Guid dynamicItemId, 
            string stringField)
        {
            DynamicItemId = dynamicItemId;
            StringField = stringField;
        }

        public System.Guid DynamicItemId { get; }

        public string StringField { get; }
    }
}
