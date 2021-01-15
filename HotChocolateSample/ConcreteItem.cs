using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HotChocolate.Configuration;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.Descriptors.Definitions;

namespace HotChocolateSample
{
    public class Haus : IConcreteItem
    {
        public string ItemId { get; set; }
    }
    public class Haus2 : IConcreteItem
    {
        public string ItemId { get; set; }
    }

    public interface IConcreteItem
    {
        string ItemId { get; set; }
    }

    public class ConcreteItemType<TSchema> : ObjectType<TSchema>
        where TSchema : IConcreteItem
    {
        protected override void Configure(IObjectTypeDescriptor<TSchema> descriptor)
        {
            descriptor.BindFieldsImplicitly();

            //descriptor.Field(f => f.ItemId)
            //    .Resolve(ctx => ctx.Parent<IConcreteItem>().ItemId);
            
            descriptor.Extend()
                .OnBeforeCompletion((context, definition) =>
                {
                    var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(string));

                    foreach (var field in definition.Fields)
                    {
                    }

                    //var newField = new ObjectFieldDefinition()
                    //{
                    //    Name = "stringField",
                    //    Type = propertyTypeRef,
                    //    Resolver = async ctx => await Task.FromResult("test")
                    //};
                    //definition.Fields.Add(newField);
                });
        }
    }
}
