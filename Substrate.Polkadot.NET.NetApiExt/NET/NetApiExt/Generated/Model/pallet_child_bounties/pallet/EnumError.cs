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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_child_bounties.pallet
{
    
    
    public enum Error
    {
        
        ParentBountyNotActive = 0,
        
        InsufficientBountyBalance = 1,
        
        TooManyChildBounties = 2,
    }
    
    /// <summary>
    /// >> 625 - Variant[pallet_child_bounties.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
