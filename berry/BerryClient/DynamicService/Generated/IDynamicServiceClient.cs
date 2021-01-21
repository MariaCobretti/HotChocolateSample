using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BerryClient
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IDynamicServiceClient
    {
        Task<IOperationResult<global::BerryClient.IGetBasicInventories>> GetBasicInventoriesAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BerryClient.IGetBasicInventories>> GetBasicInventoriesAsync(
            GetBasicInventoriesOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BerryClient.IGetBasicInventoryById>> GetBasicInventoryByIdAsync(
            Optional<System.Guid?> itemId = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BerryClient.IGetBasicInventoryById>> GetBasicInventoryByIdAsync(
            GetBasicInventoryByIdOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BerryClient.ICreateBasicInventory>> CreateBasicInventoryAsync(
            Optional<string> stringInput = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BerryClient.ICreateBasicInventory>> CreateBasicInventoryAsync(
            CreateBasicInventoryOperation operation,
            CancellationToken cancellationToken = default);
    }
}
