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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.disputes.slashing.pallet
{
    
    
    public enum Error
    {
        
        InvalidKeyOwnershipProof = 0,
        
        InvalidSessionIndex = 1,
        
        InvalidCandidateHash = 2,
        
        InvalidValidatorIndex = 3,
        
        ValidatorIndexIdMismatch = 4,
        
        DuplicateSlashingReport = 5,
    }
    
    /// <summary>
    /// >> 731 - Variant[polkadot_runtime_parachains.disputes.slashing.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
