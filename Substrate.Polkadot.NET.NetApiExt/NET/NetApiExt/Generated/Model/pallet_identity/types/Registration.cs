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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_identity.types
{
    
    
    /// <summary>
    /// >> 595 - Composite[pallet_identity.types.Registration]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Registration : BaseType
    {
        
        /// <summary>
        /// >> judgements
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 _judgements;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> info
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo _info;
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23 Judgements
        {
            get
            {
                return this._judgements;
            }
            set
            {
                this._judgements = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo Info
        {
            get
            {
                return this._info;
            }
            set
            {
                this._info = value;
            }
        }
        
        public override string TypeName()
        {
            return "Registration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Judgements.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Info.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Judgements = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23();
            Judgements.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Info = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo();
            Info.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
