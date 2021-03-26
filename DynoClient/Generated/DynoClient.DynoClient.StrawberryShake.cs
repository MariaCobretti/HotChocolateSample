#nullable enable

namespace DynoClient.DynoClient
{
    /// <summary>
    /// Represents the DynoClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class DynoClient
    {
        private readonly global::DynoClient.DynoClient.BasicInventoriesQuery _basicInventories;
        private readonly global::DynoClient.DynoClient.CreateBasicInventoryMutation _createBasicInventory;
        private readonly global::DynoClient.DynoClient.CreateBasicInventory2Mutation _createBasicInventory2;
        private readonly global::DynoClient.DynoClient.FullTestInventoriesQuery _fullTestInventories;
        private readonly global::DynoClient.DynoClient.InventoriesQuery _inventories;
        private readonly global::DynoClient.DynoClient.SelectionListsQuery _selectionLists;

        public DynoClient(
            global::DynoClient.DynoClient.BasicInventoriesQuery basicInventories,
            global::DynoClient.DynoClient.CreateBasicInventoryMutation createBasicInventory,
            global::DynoClient.DynoClient.CreateBasicInventory2Mutation createBasicInventory2,
            global::DynoClient.DynoClient.FullTestInventoriesQuery fullTestInventories,
            global::DynoClient.DynoClient.InventoriesQuery inventories,
            global::DynoClient.DynoClient.SelectionListsQuery selectionLists)
        {
            _basicInventories = basicInventories
                 ?? throw new global::System.ArgumentNullException(nameof(basicInventories));
            _createBasicInventory = createBasicInventory
                 ?? throw new global::System.ArgumentNullException(nameof(createBasicInventory));
            _createBasicInventory2 = createBasicInventory2
                 ?? throw new global::System.ArgumentNullException(nameof(createBasicInventory2));
            _fullTestInventories = fullTestInventories
                 ?? throw new global::System.ArgumentNullException(nameof(fullTestInventories));
            _inventories = inventories
                 ?? throw new global::System.ArgumentNullException(nameof(inventories));
            _selectionLists = selectionLists
                 ?? throw new global::System.ArgumentNullException(nameof(selectionLists));
        }

        public static global::System.String ClientName => "DynoClient";

        public global::DynoClient.DynoClient.BasicInventoriesQuery BasicInventories => _basicInventories;

        public global::DynoClient.DynoClient.CreateBasicInventoryMutation CreateBasicInventory => _createBasicInventory;

        public global::DynoClient.DynoClient.CreateBasicInventory2Mutation CreateBasicInventory2 => _createBasicInventory2;

        public global::DynoClient.DynoClient.FullTestInventoriesQuery FullTestInventories => _fullTestInventories;

        public global::DynoClient.DynoClient.InventoriesQuery Inventories => _inventories;

        public global::DynoClient.DynoClient.SelectionListsQuery SelectionLists => _selectionLists;
    }
}
