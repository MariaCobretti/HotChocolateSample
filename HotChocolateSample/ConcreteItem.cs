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
    public class ConcreteItem
    {
        public string ItemId { get; set; }
    }

    public class ConcreteItemType : ObjectType<ConcreteItem>
    {
        protected override void Configure(IObjectTypeDescriptor<ConcreteItem> descriptor)
        {
            descriptor.Name("ConcreteItem");

            descriptor.Field(f => f.ItemId)
                .Resolve(ctx => ctx.Parent<ConcreteItem>().ItemId);

            descriptor.Extend()
                .OnBeforeCompletion((context, definition) =>
                {
                    // single property
                    var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(ConcreteItem));
                    var newField = new ObjectFieldDefinition()
                    {
                        Name = "concreteItemField",
                        Type = propertyTypeRef,
                        Resolver = async ctx => await Task.FromResult(new ConcreteItem() { ItemId = "childId" })
                    };
                    definition.Fields.Add(newField);

                    // list property
                    var listPropertyTypeRef = context.TypeInspector.GetTypeRef(typeof(List<ConcreteItem>));
                    var newListField = new ObjectFieldDefinition()
                    {
                        Name = "concreteItemListField",
                        Type = listPropertyTypeRef,
                        Resolver = async ctx => await Task.FromResult(new List<ConcreteItem>()
                        {
                            new ConcreteItem(){ ItemId = "firstChildId"},
                            new ConcreteItem(){ ItemId = "secondChildId"}
                        })
                    };
                    definition.Fields.Add(newListField);
                });
        }
    }

    public class ConcreteItemFilterInput : FilterInputType<ConcreteItem>
    {
        protected override void Configure(IFilterInputTypeDescriptor<ConcreteItem> descriptor)
        {
            descriptor.Name("ConcreteItemFilterInput");

            descriptor.BindFieldsExplicitly();

            descriptor.Field(f => f.ItemId);

            descriptor.Extend()
                .OnBeforeCompletion((context, definition) =>
                {
                    // single property
                    var propertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ConcreteItemFilterInput));
                    var newFilterField = new FilterFieldDefinition()
                    {
                        Name = "concreteItem",
                        Type = propertyTypeRef,
                        Handler = new QueryableDefaultFieldHandler()
                    };
                    definition.Fields.Add(newFilterField);

                    // list property
                    // TODO: this is the issue
                    var listPropertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ListFilterInput<ConcreteItemFilterInput>));
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
