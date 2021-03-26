#nullable enable

namespace DynoClient.DynoClient
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class InventoriesResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public InventoriesResultInfo(
            global::DynoClient.DynoClient.State.DynamicInventoryConnectionData? dynamicInventories,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            DynamicInventories = dynamicInventories;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::DynoClient.DynoClient.State.DynamicInventoryConnectionData? DynamicInventories { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new InventoriesResultInfo(
                DynamicInventories,
                _entityIds,
                version);
        }
    }
}
