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
        Task<IOperationResult<global::BerryClient.IBasicInventory>> BasicInventoryAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::BerryClient.IBasicInventory>> BasicInventoryAsync(
            BasicInventoryOperation operation,
            CancellationToken cancellationToken = default);
    }
}
