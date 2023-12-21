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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.pallet
{
    
    
    public enum Error
    {
        
        DuplicateDisputeStatementSets = 0,
        
        AncientDisputeStatement = 1,
        
        ValidatorIndexOutOfBounds = 2,
        
        InvalidSignature = 3,
        
        DuplicateStatement = 4,
        
        SingleSidedDispute = 5,
        
        MaliciousBacker = 6,
        
        MissingBackingVotes = 7,
        
        UnconfirmedDispute = 8,
    }
    
    /// <summary>
    /// >> 726 - Variant[polkadot_runtime_parachains.disputes.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
