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
    
    
    public enum Error
    {
        
        InvalidEquivocationProof = 0,
        
        InvalidKeyOwnershipProof = 1,
        
        DuplicateOffenceReport = 2,
        
        InvalidConfiguration = 3,
    }
    
    /// <summary>
    /// >> 495 - Variant[pallet_babe.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
