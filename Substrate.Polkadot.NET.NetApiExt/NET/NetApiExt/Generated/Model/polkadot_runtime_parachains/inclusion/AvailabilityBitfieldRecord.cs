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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion
{
    
    
    /// <summary>
    /// >> 672 - Composite[polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AvailabilityBitfieldRecord : BaseType
    {
        
        /// <summary>
        /// >> bitfield
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.AvailabilityBitfield _bitfield;
        
        /// <summary>
        /// >> submitted_at
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _submittedAt;
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.AvailabilityBitfield Bitfield
        {
            get
            {
                return this._bitfield;
            }
            set
            {
                this._bitfield = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SubmittedAt
        {
            get
            {
                return this._submittedAt;
            }
            set
            {
                this._submittedAt = value;
            }
        }
        
        public override string TypeName()
        {
            return "AvailabilityBitfieldRecord";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Bitfield.Encode());
            result.AddRange(SubmittedAt.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Bitfield = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.AvailabilityBitfield();
            Bitfield.Decode(byteArray, ref p);
            SubmittedAt = new Substrate.NetApi.Model.Types.Primitive.U32();
            SubmittedAt.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
