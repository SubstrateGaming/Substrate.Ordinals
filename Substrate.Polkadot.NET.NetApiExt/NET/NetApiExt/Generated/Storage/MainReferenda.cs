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
    
    
    public sealed class ReferendaStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ReferendaStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Referenda", "ReferendumCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Referenda", "ReferendumInfoFor"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Referenda", "TrackQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Referenda", "DecidingCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Referenda", "MetadataOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256)));
        }
        
        /// <summary>
        /// >> ReferendumCountParams
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public static string ReferendumCountParams()
        {
            return RequestGenerator.GetStorage("Referenda", "ReferendumCount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ReferendumCountDefault
        /// Default value as hex string
        /// </summary>
        public static string ReferendumCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> ReferendumCount(CancellationToken token)
        {
            string parameters = ReferendaStorage.ReferendumCountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ReferendumInfoForParams
        ///  Information concerning any given referendum.
        /// </summary>
        public static string ReferendumInfoForParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Referenda", "ReferendumInfoFor", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReferendumInfoForDefault
        /// Default value as hex string
        /// </summary>
        public static string ReferendumInfoForDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        public async Task<Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo> ReferendumInfoFor(Substrate.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = ReferendaStorage.ReferendumInfoForParams(key);
            var result = await _client.GetStorageAsync<Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> TrackQueueParams
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        public static string TrackQueueParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("Referenda", "TrackQueue", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TrackQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string TrackQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        public async Task<Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21> TrackQueue(Substrate.NetApi.Model.Types.Primitive.U16 key, CancellationToken token)
        {
            string parameters = ReferendaStorage.TrackQueueParams(key);
            var result = await _client.GetStorageAsync<Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> DecidingCountParams
        ///  The number of referenda being decided currently.
        /// </summary>
        public static string DecidingCountParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("Referenda", "DecidingCount", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> DecidingCountDefault
        /// Default value as hex string
        /// </summary>
        public static string DecidingCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> DecidingCount(Substrate.NetApi.Model.Types.Primitive.U16 key, CancellationToken token)
        {
            string parameters = ReferendaStorage.DecidingCountParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> MetadataOfParams
        ///  The metadata is a general information concerning the referendum.
        ///  The `PreimageHash` refers to the preimage of the `Preimages` provider which can be a JSON
        ///  dump or IPFS hash of a JSON file.
        /// 
        ///  Consider a garbage collection for a metadata of finished referendums to `unrequest` (remove)
        ///  large preimages.
        /// </summary>
        public static string MetadataOfParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Referenda", "MetadataOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MetadataOfDefault
        /// Default value as hex string
        /// </summary>
        public static string MetadataOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MetadataOf
        ///  The metadata is a general information concerning the referendum.
        ///  The `PreimageHash` refers to the preimage of the `Preimages` provider which can be a JSON
        ///  dump or IPFS hash of a JSON file.
        /// 
        ///  Consider a garbage collection for a metadata of finished referendums to `unrequest` (remove)
        ///  large preimages.
        /// </summary>
        public async Task<Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256> MetadataOf(Substrate.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = ReferendaStorage.MetadataOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256>(parameters, token);
            return result;
        }
    }
    
    public sealed class ReferendaCalls
    {
        
        /// <summary>
        /// >> submit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Submit(Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime.EnumOriginCaller proposal_origin, Substrate.Polkadot.NET.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded proposal, Substrate.Polkadot.NET.NetApiExt.Generated.Model.frame_support.traits.schedule.EnumDispatchTime enactment_moment)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_origin.Encode());
            byteArray.AddRange(proposal.Encode());
            byteArray.AddRange(enactment_moment.Encode());
            return new Method(21, "Referenda", 0, "submit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> place_decision_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method PlaceDecisionDeposit(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(21, "Referenda", 1, "place_decision_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> refund_decision_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RefundDecisionDeposit(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(21, "Referenda", 2, "refund_decision_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Cancel(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(21, "Referenda", 3, "cancel", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> kill
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Kill(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(21, "Referenda", 4, "kill", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> nudge_referendum
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method NudgeReferendum(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(21, "Referenda", 5, "nudge_referendum", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> one_fewer_deciding
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method OneFewerDeciding(Substrate.NetApi.Model.Types.Primitive.U16 track)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(track.Encode());
            return new Method(21, "Referenda", 6, "one_fewer_deciding", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> refund_submission_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RefundSubmissionDeposit(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(21, "Referenda", 7, "refund_submission_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_metadata
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMetadata(Substrate.NetApi.Model.Types.Primitive.U32 index, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.primitive_types.H256> maybe_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(maybe_hash.Encode());
            return new Method(21, "Referenda", 8, "set_metadata", byteArray.ToArray());
        }
    }
    
    public sealed class ReferendaConstants
    {
        
        /// <summary>
        /// >> SubmissionDeposit
        ///  The minimum amount to be used as a deposit for a public referendum proposal.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SubmissionDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00E40B54020000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxQueued
        ///  Maximum size of the referendum queue for a single track.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxQueued()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> UndecidingTimeout
        ///  The number of blocks after submission that a referendum must begin being decided by.
        ///  Once this passes, then anyone may cancel the referendum.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 UndecidingTimeout()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80130300");
            return result;
        }
        
        /// <summary>
        /// >> AlarmInterval
        ///  Quantization level for the referendum wakeup scheduler. A higher number will result in
        ///  fewer storage reads/writes needed for smaller voters, but also result in delays to the
        ///  automatic referendum status changes. Explicit servicing instructions are unaffected.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AlarmInterval()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x01000000");
            return result;
        }
        
        /// <summary>
        /// >> Tracks
        ///  Information concerning the different referendum tracks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.types.TrackInfo>> Tracks()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.types.TrackInfo>>();
            result.Create("0x3C000010726F6F74010000000080C6A47E8D03000000000000000000B0040000002706004038000" +
                    "0403800000290D73E0D000000005743DE13000000005443DE13000000000000CA9A3B00000000006" +
                    "5CD1D01004877686974656C69737465645F63616C6C65726400000000407A10F35A0000000000000" +
                    "00000002C01000000270600640000006400000002EC972510000000007B573C170000000042392F1" +
                    "200000000020E00840000000000D6E61F010000000039627902000000000A00347374616B696E675" +
                    "F61646D696E0A00000000203D88792D00000000000000000000B0040000002706000807000064000" +
                    "00000C94330240065CD1D00CA9A3B025D6F780000000000E82EED00000000008C6889FFFFFFFFFF0" +
                    "B00247472656173757265720A00000000A0724E180900000000000000000000B0040000002706000" +
                    "8070000403800000290D73E0D000000005743DE13000000005443DE13000000000000CA9A3B00000" +
                    "0000065CD1D0C002C6C656173655F61646D696E0A00000000203D88792D00000000000000000000B" +
                    "004000000270600080700006400000000C94330240065CD1D00CA9A3B025D6F780000000000E82EE" +
                    "D00000000008C6889FFFFFFFFFF0D004066656C6C6F77736869705F61646D696E0A00000000203D8" +
                    "8792D00000000000000000000B004000000270600080700006400000000C94330240065CD1D00CA9" +
                    "A3B025D6F780000000000E82EED00000000008C6889FFFFFFFFFF0E003467656E6572616C5F61646" +
                    "D696E0A00000000203D88792D00000000000000000000B0040000002706000807000064000000029" +
                    "0D73E0D000000005743DE13000000005443DE13000000000259A2F40200000000A3296B050000000" +
                    "02E6B4AFDFFFFFFFF0F003461756374696F6E5F61646D696E0A00000000203D88792D00000000000" +
                    "000000000B00400000027060008070000640000000290D73E0D000000005743DE13000000005443D" +
                    "E13000000000259A2F40200000000A3296B05000000002E6B4AFDFFFFFFFF1400507265666572656" +
                    "E64756D5F63616E63656C6C6572E803000000407A10F35A00000000000000000000B0040000C0890" +
                    "100080700006400000000C94330240065CD1D00CA9A3B025D6F780000000000E82EED00000000008" +
                    "C6889FFFFFFFFFF1500447265666572656E64756D5F6B696C6C6572E803000000406352BFC601000" +
                    "000000000000000B004000000270600080700006400000000C94330240065CD1D00CA9A3B025D6F7" +
                    "80000000000E82EED00000000008C6889FFFFFFFFFF1E0030736D616C6C5F746970706572C800000" +
                    "000E40B540200000000000000000000000A000000C0890100640000000A00000000499149150065C" +
                    "D1D00CA9A3B02F9BA1800000000002A4D3100000000006B59E7FFFFFFFFFF1F00286269675F74697" +
                    "07065726400000000E8764817000000000000000000000064000000C089010058020000640000000" +
                    "0499149150065CD1D00CA9A3B02694F3F000000000035967D0000000000E534C1FFFFFFFFFF20003" +
                    "4736D616C6C5F7370656E646572320000000010A5D4E800000000000000000000006009000000270" +
                    "600201C00004038000000C94330240065CD1D00CA9A3B025D6F780000000000E82EED00000000008" +
                    "C6889FFFFFFFFFF2100386D656469756D5F7370656E6465723200000000204AA9D10100000000000" +
                    "00000000060090000002706004038000040380000005B01F6300065CD1D00CA9A3B021161DB00000" +
                    "00000BFD1AA010000000020972AFFFFFFFFFF22002C6269675F7370656E646572320000000040945" +
                    "2A30300000000000000000000600900000027060080700000403800000000CA9A3B0065CD1D00CA9" +
                    "A3B02413CB00100000000755D34030000000045D165FEFFFFFFFF");
            return result;
        }
    }
    
    public enum ReferendaErrors
    {
        
        /// <summary>
        /// >> NotOngoing
        /// Referendum is not ongoing.
        /// </summary>
        NotOngoing,
        
        /// <summary>
        /// >> HasDeposit
        /// Referendum's decision deposit is already paid.
        /// </summary>
        HasDeposit,
        
        /// <summary>
        /// >> BadTrack
        /// The track identifier given was invalid.
        /// </summary>
        BadTrack,
        
        /// <summary>
        /// >> Full
        /// There are already a full complement of referenda in progress for this track.
        /// </summary>
        Full,
        
        /// <summary>
        /// >> QueueEmpty
        /// The queue of the track is empty.
        /// </summary>
        QueueEmpty,
        
        /// <summary>
        /// >> BadReferendum
        /// The referendum index provided is invalid in this context.
        /// </summary>
        BadReferendum,
        
        /// <summary>
        /// >> NothingToDo
        /// There was nothing to do in the advancement.
        /// </summary>
        NothingToDo,
        
        /// <summary>
        /// >> NoTrack
        /// No track exists for the proposal origin.
        /// </summary>
        NoTrack,
        
        /// <summary>
        /// >> Unfinished
        /// Any deposit cannot be refunded until after the decision is over.
        /// </summary>
        Unfinished,
        
        /// <summary>
        /// >> NoPermission
        /// The deposit refunder is not the depositor.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NoDeposit
        /// The deposit cannot be refunded since none was made.
        /// </summary>
        NoDeposit,
        
        /// <summary>
        /// >> BadStatus
        /// The referendum status is invalid for this operation.
        /// </summary>
        BadStatus,
        
        /// <summary>
        /// >> PreimageNotExist
        /// The preimage does not exist.
        /// </summary>
        PreimageNotExist,
    }
}
