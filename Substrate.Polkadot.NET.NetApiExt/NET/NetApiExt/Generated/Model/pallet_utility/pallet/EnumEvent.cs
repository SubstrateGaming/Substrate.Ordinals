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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_utility.pallet
{
    
    
    public enum Event
    {
        
        BatchInterrupted = 0,
        
        BatchCompleted = 1,
        
        BatchCompletedWithErrors = 2,
        
        ItemCompleted = 3,
        
        ItemFailed = 4,
        
        DispatchedAs = 5,
    }
    
    /// <summary>
    /// >> 424 - Variant[pallet_utility.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError>, BaseVoid, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError, Substrate.Polkadot.NET.NetApiExt.Generated.Types.Base.EnumResult>
    {
    }
}