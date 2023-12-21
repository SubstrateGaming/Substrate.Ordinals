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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime
{
    
    
    public enum RuntimeCall
    {
        
        System = 0,
        
        Scheduler = 1,
        
        Preimage = 10,
        
        Babe = 2,
        
        Timestamp = 3,
        
        Indices = 4,
        
        Balances = 5,
        
        Staking = 7,
        
        Session = 9,
        
        Grandpa = 11,
        
        ImOnline = 12,
        
        Treasury = 19,
        
        ConvictionVoting = 20,
        
        Referenda = 21,
        
        Whitelist = 23,
        
        Claims = 24,
        
        Vesting = 25,
        
        Utility = 26,
        
        Identity = 28,
        
        Proxy = 29,
        
        Multisig = 30,
        
        Bounties = 34,
        
        ChildBounties = 38,
        
        ElectionProviderMultiPhase = 36,
        
        VoterList = 37,
        
        NominationPools = 39,
        
        FastUnstake = 40,
        
        Configuration = 51,
        
        ParasShared = 52,
        
        ParaInclusion = 53,
        
        ParaInherent = 54,
        
        Paras = 56,
        
        Initializer = 57,
        
        Hrmp = 60,
        
        ParasDisputes = 62,
        
        ParasSlashing = 63,
        
        Registrar = 70,
        
        Slots = 71,
        
        Auctions = 72,
        
        Crowdloan = 73,
        
        XcmPallet = 99,
        
        MessageQueue = 100,
    }
    
    /// <summary>
    /// >> 68 - Variant[polkadot_runtime.RuntimeCall]
    /// </summary>
    public sealed class EnumRuntimeCall : BaseEnumExt<RuntimeCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_scheduler.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_babe.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_timestamp.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_indices.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_staking.pallet.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_session.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_preimage.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_grandpa.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_im_online.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_treasury.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_conviction_voting.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_whitelist.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.claims.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_vesting.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_utility.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_identity.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_proxy.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_multisig.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_bounties.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_election_provider_multi_phase.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_bags_list.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_child_bounties.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_nomination_pools.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_fast_unstake.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.shared.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras_inherent.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.initializer.pallet.EnumCall, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.pallet.EnumCall, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.slashing.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.paras_registrar.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.slots.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.auctions.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumCall, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_message_queue.pallet.EnumCall>
    {
    }
}