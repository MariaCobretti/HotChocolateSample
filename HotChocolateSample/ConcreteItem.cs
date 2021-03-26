using System;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors.Definitions;

namespace HotChocolateSample
{
    public class Building : IItem
    {
        public Building(string itemId, string address)
        {
            ItemId = itemId;
            Address = address;
        }

        public string ItemId { get; set; }
        public string Address { get; set; }
    }

    public class Flat : IItem
    {
        public Flat(string itemId, string owner)
        {
            ItemId = itemId;
            Owner = owner;
        }

        public string ItemId { get; set; }
        public string Owner { get; set; }
    }

    public interface IItem
    {
        string ItemId { get; set; }
    }

    public class ConcreteItemType<TSchema> : ObjectType<IItem>
        where TSchema : IItem
    {
        protected override void Configure(IObjectTypeDescriptor<IItem> descriptor)
        {
            descriptor.Name(typeof(TSchema).Name);

            descriptor.ImplementsNode()
                .IdField(f => f.ItemId)
                .ResolveNode(async (context, id) =>
                {
                    var item = DataServiceMock.GetItem<TSchema>(id);
                    return item;
                });

            descriptor.Field(f => f.ItemId)
                .Resolve(ctx => ctx.Parent<IItem>().ItemId);

            descriptor.Extend()
                .OnBeforeCreate((context, definition) =>
                {
                    string fieldName = "";
                    if (typeof(TSchema) == typeof(Building))
                    {
                        fieldName = "address";
                    }
                    if (typeof(TSchema) == typeof(Flat))
                    {
                        fieldName = "owner";
                    }

                    var propertyTypeRef = context.TypeInspector.GetTypeRef(typeof(string));
                    var newField = new ObjectFieldDefinition()
                    {
                        Name = fieldName,
                        Type = propertyTypeRef,
                        Resolver = async ctx =>
                        {
                            var parent = ctx.Parent<IItem>();

                            switch (parent)
                            {
                                case Building building:
                                    return building.Address;
                                case Flat flat:
                                    return flat.Owner;
                            }

                            throw new Exception();
                        }
                    };

                    definition.Fields.Add(newField);
                });
        }
    }
}
