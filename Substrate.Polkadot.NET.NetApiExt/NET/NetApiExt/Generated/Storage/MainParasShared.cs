//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class ParasSharedStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ParasSharedStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParasShared", "CurrentSessionIndex"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParasShared", "ActiveValidatorIndices"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.ValidatorIndex>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParasShared", "ActiveValidatorKeys"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.validator_app.Public>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParasShared", "AllowedRelayParents"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.shared.AllowedRelayParentsTracker)));
        }
        
        /// <summary>
        /// >> CurrentSessionIndexParams
        ///  The current session index.
        /// </summary>
        public static string CurrentSessionIndexParams()
        {
            return RequestGenerator.GetStorage("ParasShared", "CurrentSessionIndex", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentSessionIndexDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentSessionIndexDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> CurrentSessionIndex
        ///  The current session index.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CurrentSessionIndex(CancellationToken token)
        {
            string parameters = ParasSharedStorage.CurrentSessionIndexParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ActiveValidatorIndicesParams
        ///  All the validators actively participating in parachain consensus.
        ///  Indices are into the broader validator set.
        /// </summary>
        public static string ActiveValidatorIndicesParams()
        {
            return RequestGenerator.GetStorage("ParasShared", "ActiveValidatorIndices", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ActiveValidatorIndicesDefault
        /// Default value as hex string
        /// </summary>
        public static string ActiveValidatorIndicesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ActiveValidatorIndices
        ///  All the validators actively participating in parachain consensus.
        ///  Indices are into the broader validator set.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.ValidatorIndex>> ActiveValidatorIndices(CancellationToken token)
        {
            string parameters = ParasSharedStorage.ActiveValidatorIndicesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.ValidatorIndex>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ActiveValidatorKeysParams
        ///  The parachain attestation keys of the validators actively participating in parachain
        ///  consensus. This should be the same length as `ActiveValidatorIndices`.
        /// </summary>
        public static string ActiveValidatorKeysParams()
        {
            return RequestGenerator.GetStorage("ParasShared", "ActiveValidatorKeys", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ActiveValidatorKeysDefault
        /// Default value as hex string
        /// </summary>
        public static string ActiveValidatorKeysDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ActiveValidatorKeys
        ///  The parachain attestation keys of the validators actively participating in parachain
        ///  consensus. This should be the same length as `ActiveValidatorIndices`.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.validator_app.Public>> ActiveValidatorKeys(CancellationToken token)
        {
            string parameters = ParasSharedStorage.ActiveValidatorKeysParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.validator_app.Public>>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> AllowedRelayParentsParams
        ///  All allowed relay-parents.
        /// </summary>
        public static string AllowedRelayParentsParams()
        {
            return RequestGenerator.GetStorage("ParasShared", "AllowedRelayParents", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AllowedRelayParentsDefault
        /// Default value as hex string
        /// </summary>
        public static string AllowedRelayParentsDefault()
        {
            return "0x0000000000";
        }
        
        /// <summary>
        /// >> AllowedRelayParents
        ///  All allowed relay-parents.
        /// </summary>
        public async Task<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.shared.AllowedRelayParentsTracker> AllowedRelayParents(CancellationToken token)
        {
            string parameters = ParasSharedStorage.AllowedRelayParentsParams();
            var result = await _client.GetStorageAsync<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.shared.AllowedRelayParentsTracker>(parameters, token);
            return result;
        }
    }
    
    public sealed class ParasSharedCalls
    {
    }
    
    public sealed class ParasSharedConstants
    {
    }
}
