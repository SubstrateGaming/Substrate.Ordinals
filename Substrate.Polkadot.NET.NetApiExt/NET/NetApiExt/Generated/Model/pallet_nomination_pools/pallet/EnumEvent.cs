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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_nomination_pools.pallet
{
    
    
    public enum Event
    {
        
        Created = 0,
        
        Bonded = 1,
        
        PaidOut = 2,
        
        Unbonded = 3,
        
        Withdrawn = 4,
        
        Destroyed = 5,
        
        StateChanged = 6,
        
        MemberRemoved = 7,
        
        RolesUpdated = 8,
        
        PoolSlashed = 9,
        
        UnbondingPoolSlashed = 10,
        
        PoolCommissionUpdated = 11,
        
        PoolMaxCommissionUpdated = 12,
        
        PoolCommissionChangeRateUpdated = 13,
        
        PoolCommissionClaimed = 14,
    }
    
    /// <summary>
    /// >> 435 - Variant[pallet_nomination_pools.pallet.Event]
    /// Events of this pallet.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_nomination_pools.EnumPoolState>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_nomination_pools.CommissionChangeRate>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
