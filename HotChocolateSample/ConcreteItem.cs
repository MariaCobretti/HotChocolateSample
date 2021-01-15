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

    public class Wohnung : IConcreteItem
    {
        public string ItemId { get; set; }
    }

    public interface IConcreteItem
    {
        string ItemId { get; set; }
    }

    public class DynamicItemType : ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Extend()
                .OnBeforeCreate((context, definition) =>
                {
                    var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(string));
                    var newField = new ObjectFieldDefinition()
                    {
                        Name = "stringField",
                        Type = propertyTypeRef,
                        Resolver = async ctx => await Task.FromResult("test")
                    };
                    definition.Fields.Add(newField);
                });
        }
    }
    public class ConcreteItemType<TSchema> : ObjectType<TSchema>
        where TSchema : IConcreteItem
    {
        protected override void Configure(IObjectTypeDescriptor<TSchema> descriptor)
        {
            //descriptor.Name(typeof(TSchema).Name);
            //descriptor.Name("ConcreteItem");

            descriptor.Field(f => f.ItemId)
                .Resolve(ctx => ctx.Parent<IConcreteItem>().ItemId);
            descriptor.Extend()
                .OnBeforeCreate((context, definition) =>
                {
                    var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(string));
                    var newField = new ObjectFieldDefinition()
                    {
                        Name = "stringField",
                        Type = propertyTypeRef,
                        Resolver = async ctx => await Task.FromResult("test")
                    };
                    definition.Fields.Add(newField);
                });
            //descriptor.Extend()
            //    .OnBeforeCompletion((context, definition) =>
            //    {
            //        // single property
            //        var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(Haus));
            //        //var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(TSchema));
            //        var newField = new ObjectFieldDefinition()
            //        {
            //            Name = "concreteItemField",
            //            Type = propertyTypeRef,
            //            Resolver = async ctx => await Task.FromResult(new Haus() { ItemId = "childId" })
            //        };
            //        definition.Fields.Add(newField);

            //        // list property
            //        var listPropertyTypeRef = context.TypeInspector.GetTypeRef(typeof(List<Haus>));
            //        var newListField = new ObjectFieldDefinition()
            //        {
            //            Name = "concreteItemListField",
            //            Type = listPropertyTypeRef,
                        
            //            Resolver = async ctx => await Task.FromResult(new List<Haus>()
            //            {
            //                new Haus(){ ItemId = "firstChildId"},
            //                new Haus(){ ItemId = "secondChildId"}
            //            })
            //        };
            //        definition.Fields.Add(newListField);
            //    });
        }
    }

    public class ConcreteItemFilterInput<TSchema> : FilterInputType<TSchema>
        where TSchema : IConcreteItem
    {
        protected override void OnAfterCompleteName(ITypeCompletionContext context, DefinitionBase definition, IDictionary<string, object?> contextData)
        {
            base.OnAfterCompleteName(context, definition, contextData);
        }

        protected override void Configure(IFilterInputTypeDescriptor<TSchema> descriptor)
        {
            descriptor.Name(typeof(TSchema).Name + "FilterInput");
            //descriptor.Name("ConcreteItemFilterInput");
            
            descriptor.BindFieldsExplicitly();

            descriptor.Field(f => f.ItemId);

            descriptor.Extend()
                .OnBeforeCreate((context, definition) =>
                {
                    // single property
                    var referencedFilterType = typeof(ConcreteItemFilterInput<>).MakeGenericType(typeof(Haus));
                    var propertyTypeRef = context.TypeInspector.GetInputTypeRef(referencedFilterType);
                    //EntityType = propertyTypeRef;
                    //RuntimeType = typeof(Haus);

                    //var propertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ConcreteItemFilterInput<TSchema>));
                    var newFilterField = new FilterFieldDefinition()
                    {
                        Name = "concreteItem",
                        Type = propertyTypeRef,
                        Handler = new QueryableDefaultFieldHandler()
                    };
                    definition.Fields.Add(newFilterField);

                    // list property
                    // TODO: this is the issue
                    var referencedListFilterType = typeof(ListFilterInput<>).MakeGenericType(referencedFilterType);
                    var listPropertyTypeRef = context.TypeInspector.GetInputTypeRef(referencedListFilterType);

                    //var listPropertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ListFilterInput<ConcreteItemFilterInput<TSchema>>));
                    var newListFilterField = new FilterFieldDefinition()
                    {
                        Name = "concreteItems",
                        Type = listPropertyTypeRef,
                        Handler = new QueryableDefaultFieldHandler()
                    };
                    definition.Fields.Add(newListFilterField);
                });

            //descriptor.Extend()
            //    .OnBeforeCompletion((context, definition) =>
            //    {
            //        // single property
            //        var referencedFilterType = typeof(ConcreteItemFilterInput<>).MakeGenericType(typeof(Haus));
            //        var propertyTypeRef = context.TypeInspector.GetInputTypeRef(referencedFilterType);
            //        //EntityType = propertyTypeRef;
            //        //RuntimeType = typeof(Haus);

            //        //var propertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ConcreteItemFilterInput<TSchema>));
            //        var newFilterField = new FilterFieldDefinition()
            //        {
            //            Name = "concreteItem",
            //            Type = propertyTypeRef,
            //            Handler = new QueryableDefaultFieldHandler()
            //        };
            //        definition.Fields.Add(newFilterField);

            //        // list property
            //        // TODO: this is the issue
            //        var referencedListFilterType = typeof(ListFilterInput<>).MakeGenericType(referencedFilterType);
            //        var listPropertyTypeRef = context.TypeInspector.GetInputTypeRef(referencedListFilterType);

            //        //var listPropertyTypeRef = context.TypeInspector.GetInputTypeRef(typeof(ListFilterInput<ConcreteItemFilterInput<TSchema>>));
            //        var newListFilterField = new FilterFieldDefinition()
            //        {
            //            Name = "concreteItems",
            //            Type = listPropertyTypeRef,
            //            Handler = new QueryableDefaultFieldHandler()
            //        };
            //        definition.Fields.Add(newListFilterField);
            //    });
        }
    }
}
