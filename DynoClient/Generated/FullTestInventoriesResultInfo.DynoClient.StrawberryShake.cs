#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FullTestInventoriesResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public FullTestInventoriesResultInfo(
            global::DynoClient.DynoClient.State.FullTestInventoryConnectionData? fullTestInventory,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            FullTestInventory = fullTestInventory;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::DynoClient.DynoClient.State.FullTestInventoryConnectionData? FullTestInventory { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new FullTestInventoriesResultInfo(
                FullTestInventory,
                _entityIds,
                version);
        }
    }
}
