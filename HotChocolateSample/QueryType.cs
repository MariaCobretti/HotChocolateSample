using System.Linq;
using HotChocolate.Types;

namespace HotChocolateSample
{
    public class QueryType : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field("buildings")
                .Type<ListType<ConcreteItemType<Building>>>()
                .Resolve(async x => DataServiceMock.Buildings.Select(x => x.Value));

            descriptor.Field("flats")
                .Type<ListType<ConcreteItemType<Flat>>>()
                .Resolve(async x => DataServiceMock.Flats.Select(x => x.Value));
        }
    }
}
