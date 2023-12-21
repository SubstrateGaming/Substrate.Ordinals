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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_referenda.types
{
    
    
    /// <summary>
    /// >> 575 - Composite[pallet_referenda.types.DecidingStatus]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DecidingStatus : BaseType
    {
        
        /// <summary>
        /// >> since
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _since;
        
        /// <summary>
        /// >> confirming
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _confirming;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Since
        {
            get
            {
                return this._since;
            }
            set
            {
                this._since = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> Confirming
        {
            get
            {
                return this._confirming;
            }
            set
            {
                this._confirming = value;
            }
        }
        
        public override string TypeName()
        {
            return "DecidingStatus";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Since.Encode());
            result.AddRange(Confirming.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Since = new Substrate.NetApi.Model.Types.Primitive.U32();
            Since.Decode(byteArray, ref p);
            Confirming = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            Confirming.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
