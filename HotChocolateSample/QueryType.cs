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
            var haus = typeof(ConcreteItemType<>).MakeGenericType(typeof(MyTypeBase));
            descriptor.Field("haus")
                .Type(haus)
                .Resolve(x => new MyTypeBase() { ItemId = "parentId" } );



            //var haus = typeof(ConcreteItemType<>).MakeGenericType(typeof(Haus));
            //var wohnung = typeof(ConcreteItemType<>).MakeGenericType(typeof(Wohnung));

            //var filterType = typeof(ConcreteItemFilterInput<>).MakeGenericType(typeof(Haus));
            //var wohnungfilterType = typeof(ConcreteItemFilterInput<>).MakeGenericType(typeof(Wohnung));

            //descriptor.Field("haus")
            //    //.Type(haus)
            //    .UsePaging(haus)
            //    //.Type<ConcreteItemType>()
            //    .Resolve(x => new List<Haus>() { new Haus() { ItemId = "parentId" } })
            //    .UseFiltering(filterType);
            //    //.UseFiltering<ConcreteItemFilterInput>();

            //descriptor.Field("wohnung")
            //    //.Type(wohnung)
            //    .UsePaging(wohnung)
            //    //.Type<ConcreteItemType>()
            //    .Resolve(x => new List<Wohnung>() { new Wohnung() { ItemId = "parentId" } })
            //    .UseFiltering(wohnungfilterType);
            //    //.UseFiltering<ConcreteItemFilterInput>();
        }
    }
}
