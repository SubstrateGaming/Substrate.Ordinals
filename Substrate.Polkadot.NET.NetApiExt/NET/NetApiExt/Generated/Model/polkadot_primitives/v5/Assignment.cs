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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5
{
    
    
    /// <summary>
    /// >> 685 - Composite[polkadot_primitives.v5.Assignment]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Assignment : BaseType
    {
        
        /// <summary>
        /// >> para_id
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id _paraId;
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id ParaId
        {
            get
            {
                return this._paraId;
            }
            set
            {
                this._paraId = value;
            }
        }
        
        public override string TypeName()
        {
            return "Assignment";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ParaId.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ParaId = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id();
            ParaId.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
