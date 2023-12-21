//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.executor_params
{
    
    
    public enum ExecutorParam
    {
        
        MaxMemoryPages = 1,
        
        StackLogicalMax = 2,
        
        StackNativeMax = 3,
        
        PrecheckingMaxMemory = 4,
        
        PvfPrepTimeout = 5,
        
        PvfExecTimeout = 6,
        
        WasmExtBulkMemory = 7,
    }
    
    /// <summary>
    /// >> 288 - Variant[polkadot_primitives.v5.executor_params.ExecutorParam]
    /// </summary>
    public sealed class EnumExecutorParam : BaseEnumExt<ExecutorParam, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U64, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.EnumPvfPrepTimeoutKind, Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.EnumPvfExecTimeoutKind, Substrate.NetApi.Model.Types.Primitive.U64>, BaseVoid>
    {
    }
}
