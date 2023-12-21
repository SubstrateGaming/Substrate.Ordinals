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
    /// >> 309 - Composite[polkadot_primitives.v5.CandidateCommitments]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CandidateCommitments : BaseType
    {
        
        /// <summary>
        /// >> upward_messages
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 _upwardMessages;
        
        /// <summary>
        /// >> horizontal_messages
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 _horizontalMessages;
        
        /// <summary>
        /// >> new_validation_code
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode> _newValidationCode;
        
        /// <summary>
        /// >> head_data
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData _headData;
        
        /// <summary>
        /// >> processed_downward_messages
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _processedDownwardMessages;
        
        /// <summary>
        /// >> hrmp_watermark
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpWatermark;
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 UpwardMessages
        {
            get
            {
                return this._upwardMessages;
            }
            set
            {
                this._upwardMessages = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 HorizontalMessages
        {
            get
            {
                return this._horizontalMessages;
            }
            set
            {
                this._horizontalMessages = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode> NewValidationCode
        {
            get
            {
                return this._newValidationCode;
            }
            set
            {
                this._newValidationCode = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData HeadData
        {
            get
            {
                return this._headData;
            }
            set
            {
                this._headData = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ProcessedDownwardMessages
        {
            get
            {
                return this._processedDownwardMessages;
            }
            set
            {
                this._processedDownwardMessages = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpWatermark
        {
            get
            {
                return this._hrmpWatermark;
            }
            set
            {
                this._hrmpWatermark = value;
            }
        }
        
        public override string TypeName()
        {
            return "CandidateCommitments";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UpwardMessages.Encode());
            result.AddRange(HorizontalMessages.Encode());
            result.AddRange(NewValidationCode.Encode());
            result.AddRange(HeadData.Encode());
            result.AddRange(ProcessedDownwardMessages.Encode());
            result.AddRange(HrmpWatermark.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UpwardMessages = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2();
            UpwardMessages.Decode(byteArray, ref p);
            HorizontalMessages = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3();
            HorizontalMessages.Decode(byteArray, ref p);
            NewValidationCode = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.ValidationCode>();
            NewValidationCode.Decode(byteArray, ref p);
            HeadData = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.HeadData();
            HeadData.Decode(byteArray, ref p);
            ProcessedDownwardMessages = new Substrate.NetApi.Model.Types.Primitive.U32();
            ProcessedDownwardMessages.Decode(byteArray, ref p);
            HrmpWatermark = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpWatermark.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}