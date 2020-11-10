using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    public interface IConcreteItem
    {
        string ItemId { get; set; }
    }

    public class ConcreteItemType<TSchema> : ObjectType<TSchema>
        where TSchema : IConcreteItem
    {
        protected override void Configure(IObjectTypeDescriptor<TSchema> descriptor)
        {
            descriptor.Name("ConcreteItem");

            descriptor.Field(f => f.ItemId)
                .Resolve(ctx => ctx.Parent<IConcreteItem>().ItemId);

            descriptor.Extend()
                .OnBeforeCompletion((context, definition) =>
                {
                    // single property
                    var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(TSchema));
                    var newField = new ObjectFieldDefinition()
                    {
                        Name = "concreteItemField",
                        Type = propertyTypeRef,
                        Resolver = async ctx => await Task.FromResult(new Haus() { ItemId = "childId" })
                    };
                    definition.Fields.Add(newField);

                    // list property
                    var listPropertyTypeRef = context.TypeInspector.GetTypeRef(typeof(List<TSchema>));
                    var newListField = new ObjectFieldDefinition()
                    {
                        Name = "concreteItemListField",
                        Type = listPropertyTypeRef,
                        Resolver = async ctx => await Task.FromResult(new List<Haus>()
                        {
                            new Haus(){ ItemId = "firstChildId"},
                            new Haus(){ ItemId = "secondChildId"}
                        })
                    };
                    definition.Fields.Add(newListField);
                });
        }
    }

    public class ConcreteItemFilterInput<TSchema> : FilterInputType<TSchema>
        where TSchema : IConcreteItem
    {
        protected override void Configure(IFilterInputTypeDescriptor<TSchema> descriptor)
        {
            descriptor.Name("ConcreteItemFilterInput");

            descriptor.BindFieldsExplicitly();

            descriptor.Field(f => f.ItemId);

            descriptor.Extend()
                .OnBeforeCompletion((context, definition) =>
                {
                    // single property
                    var propertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ConcreteItemFilterInput<TSchema>));
                    var newFilterField = new FilterFieldDefinition()
                    {
                        Name = "concreteItem",
                        Type = propertyTypeRef,
                        Handler = new QueryableDefaultFieldHandler()
                    };
                    definition.Fields.Add(newFilterField);

                    // list property
                    // TODO: this is the issue
                    var listPropertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ListFilterInput<ConcreteItemFilterInput<TSchema>>));
                    var newListFilterField = new FilterFieldDefinition()
                    {
                        Name = "concreteItems",
                        Type = listPropertyTypeRef,
                        Handler = new QueryableDefaultFieldHandler()
                    };
                    definition.Fields.Add(newListFilterField);
                });
        }
    }
}
