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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_babe.pallet
{
    
    
    public enum Call
    {
        
        report_equivocation = 0,
        
        report_equivocation_unsigned = 1,
        
        plan_config_change = 2,
    }
    
    /// <summary>
    /// >> 76 - Variant[pallet_babe.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_slots.EquivocationProof, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_session.MembershipProof>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_slots.EquivocationProof, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_session.MembershipProof>, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_consensus_babe.digests.EnumNextConfigDescriptor>
    {
    }
}