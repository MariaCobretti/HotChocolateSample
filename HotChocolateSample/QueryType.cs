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

            var haus = typeof(ConcreteItemType<>).MakeGenericType(typeof(Haus));

            var filterType = typeof(ConcreteItemFilterInput<>).MakeGenericType(typeof(Haus));

            descriptor.Field("concreteItem")
                .Type(haus)
                //.Type<ConcreteItemType>()
                .Resolve(x => new Haus(){ ItemId = "parentId"})
                .UseFiltering(filterType);
                //.UseFiltering<ConcreteItemFilterInput>();
        }
    }
}
