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
            var haus2 = typeof(ConcreteItemType<>).MakeGenericType(typeof(Haus));

            descriptor.Field("haus")
                .Type(haus)
                .Resolve(x => new Haus() { ItemId = "parentId" } );
            descriptor.Field("haus2")
                .Type(haus2)
                .Resolve(x => new Haus2() { ItemId = "parentId" } );
        }
    }
}
