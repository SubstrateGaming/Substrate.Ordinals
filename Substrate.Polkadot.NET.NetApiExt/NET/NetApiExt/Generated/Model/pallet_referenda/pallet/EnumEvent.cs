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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.pallet
{
    
    
    public enum Event
    {
        
        Submitted = 0,
        
        DecisionDepositPlaced = 1,
        
        DecisionDepositRefunded = 2,
        
        DepositSlashed = 3,
        
        DecisionStarted = 4,
        
        ConfirmStarted = 5,
        
        ConfirmAborted = 6,
        
        Confirmed = 7,
        
        Approved = 8,
        
        Rejected = 9,
        
        TimedOut = 10,
        
        Cancelled = 11,
        
        Killed = 12,
        
        SubmissionDepositRefunded = 13,
        
        MetadataSet = 14,
        
        MetadataCleared = 15,
    }
    
    /// <summary>
    /// >> 65 - Variant[pallet_referenda.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Polkadot.NET.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Polkadot.NET.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.types.Tally>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.types.Tally>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.types.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.types.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.types.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.types.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256>>
    {
    }
}
