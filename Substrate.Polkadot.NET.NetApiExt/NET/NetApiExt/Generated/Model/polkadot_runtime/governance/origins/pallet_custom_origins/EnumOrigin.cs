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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime.governance.origins.pallet_custom_origins
{
    
    
    public enum Origin
    {
        
        StakingAdmin = 0,
        
        Treasurer = 1,
        
        FellowshipAdmin = 2,
        
        GeneralAdmin = 3,
        
        AuctionAdmin = 4,
        
        LeaseAdmin = 5,
        
        ReferendumCanceller = 6,
        
        ReferendumKiller = 7,
        
        SmallTipper = 8,
        
        BigTipper = 9,
        
        SmallSpender = 10,
        
        MediumSpender = 11,
        
        BigSpender = 12,
        
        WhitelistedCaller = 13,
    }
    
    /// <summary>
    /// >> 132 - Variant[polkadot_runtime.governance.origins.pallet_custom_origins.Origin]
    /// </summary>
    public sealed class EnumOrigin : BaseEnum<Origin>
    {
    }
}
