using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace HC.Server._11_1
{
    public class QueryType : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field("complexField").Type<ComplexOutputType>().Resolve(x => new ComplexOutput(){ NumberField = 1.1, StringField = "okok"});
        }
    }
}
