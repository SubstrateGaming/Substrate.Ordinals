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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.pallet_bags_list.list
{
    
    
    /// <summary>
    /// >> 637 - Composite[pallet_bags_list.list.Bag]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Bag : BaseType
    {
        
        /// <summary>
        /// >> head
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _head;
        
        /// <summary>
        /// >> tail
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _tail;
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Head
        {
            get
            {
                return this._head;
            }
            set
            {
                this._head = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Tail
        {
            get
            {
                return this._tail;
            }
            set
            {
                this._tail = value;
            }
        }
        
        public override string TypeName()
        {
            return "Bag";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Head.Encode());
            result.AddRange(Tail.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Head = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Head.Decode(byteArray, ref p);
            Tail = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            Tail.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
