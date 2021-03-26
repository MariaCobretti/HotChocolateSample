#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory
        : ICreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory
    {
        public CreateBasicInventory2_CreateBasicInventory_ConcreteItems_BasicInventory(
            global::System.Guid dynamicItemId,
            global::System.Double? numberField,
            global::System.String? stringField)
        {
            DynamicItemId = dynamicItemId;
            NumberField = numberField;
            StringField = stringField;
        }

        public global::System.Guid DynamicItemId { get; }

        public global::System.Double? NumberField { get; } = default!;

        public global::System.String? StringField { get; } = default!;
    }
}
