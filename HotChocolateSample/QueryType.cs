using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace HotChocolateSample
{
    public class QueryType : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field("concreteItem")
                .Type<ConcreteItemType>()
                .Resolve(x => new ConcreteItem(){ ItemId = "parentId"})
                .UseFiltering<ConcreteItemFilterInput>();
        }
    }
}
