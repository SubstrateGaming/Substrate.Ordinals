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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_core_primitives
{
    
    
    /// <summary>
    /// >> 312 - Composite[polkadot_core_primitives.OutboundHrmpMessage]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class OutboundHrmpMessage : BaseType
    {
        
        /// <summary>
        /// >> recipient
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id _recipient;
        
        /// <summary>
        /// >> data
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> _data;
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id Recipient
        {
            get
            {
                return this._recipient;
            }
            set
            {
                this._recipient = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        
        public override string TypeName()
        {
            return "OutboundHrmpMessage";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Recipient.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Recipient = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id();
            Recipient.Decode(byteArray, ref p);
            Data = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Data.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
