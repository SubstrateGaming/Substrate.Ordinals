//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_election_provider_multi_phase
{
    
    
    /// <summary>
    /// >> 263 - Composite[pallet_election_provider_multi_phase.SolutionOrSnapshotSize]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SolutionOrSnapshotSize : BaseType
    {
        
        /// <summary>
        /// >> voters
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _voters;
        
        /// <summary>
        /// >> targets
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _targets;
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Voters
        {
            get
            {
                return this._voters;
            }
            set
            {
                this._voters = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Targets
        {
            get
            {
                return this._targets;
            }
            set
            {
                this._targets = value;
            }
        }
        
        public override string TypeName()
        {
            return "SolutionOrSnapshotSize";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Voters.Encode());
            result.AddRange(Targets.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Voters = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Voters.Decode(byteArray, ref p);
            Targets = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Targets.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
