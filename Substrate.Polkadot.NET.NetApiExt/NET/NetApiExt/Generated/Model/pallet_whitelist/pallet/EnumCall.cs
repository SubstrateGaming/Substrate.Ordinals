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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_whitelist.pallet
{
    
    
    public enum Call
    {
        
        whitelist_call = 0,
        
        remove_whitelisted_call = 1,
        
        dispatch_whitelisted_call = 2,
        
        dispatch_whitelisted_call_with_preimage = 3,
    }
    
    /// <summary>
    /// >> 146 - Variant[pallet_whitelist.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>, Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime.EnumRuntimeCall>
    {
    }
}
