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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.pallet
{
    
    
    public enum Event
    {
        
        CandidateBacked = 0,
        
        CandidateIncluded = 1,
        
        CandidateTimedOut = 2,
        
        UpwardMessagesReceived = 3,
    }
    
    /// <summary>
    /// >> 437 - Variant[polkadot_runtime_parachains.inclusion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.CandidateReceipt, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.CoreIndex, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.GroupIndex>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.CandidateReceipt, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.CoreIndex, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.GroupIndex>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.CandidateReceipt, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.CoreIndex>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}