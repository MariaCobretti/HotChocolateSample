using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class DynamicServiceClient
        : IDynamicServiceClient
    {
        private const string _clientName = "DynamicServiceClient";

        private readonly global::StrawberryShake.IOperationExecutor _executor;

        public DynamicServiceClient(global::StrawberryShake.IOperationExecutorPool executorPool)
        {
            _executor = executorPool.CreateExecutor(_clientName);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::BerryClient.IGetBasicInventories>> GetBasicInventoriesAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetBasicInventoriesOperation(),
                cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::BerryClient.IGetBasicInventories>> GetBasicInventoriesAsync(
            GetBasicInventoriesOperation operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::BerryClient.IGetBasicInventoryById>> GetBasicInventoryByIdAsync(
            global::StrawberryShake.Optional<System.Guid?> itemId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetBasicInventoryByIdOperation { ItemId = itemId },
                cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::BerryClient.IGetBasicInventoryById>> GetBasicInventoryByIdAsync(
            GetBasicInventoryByIdOperation operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::BerryClient.ICreateBasicInventory>> CreateBasicInventoryAsync(
            global::StrawberryShake.Optional<string> stringInput = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new CreateBasicInventoryOperation { StringInput = stringInput },
                cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::BerryClient.ICreateBasicInventory>> CreateBasicInventoryAsync(
            CreateBasicInventoryOperation operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
