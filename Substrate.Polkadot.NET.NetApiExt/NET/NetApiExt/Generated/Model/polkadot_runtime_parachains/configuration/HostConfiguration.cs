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


namespace Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration
{
    
    
    /// <summary>
    /// >> 663 - Composite[polkadot_runtime_parachains.configuration.HostConfiguration]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class HostConfiguration : BaseType
    {
        
        /// <summary>
        /// >> max_code_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxCodeSize;
        
        /// <summary>
        /// >> max_head_data_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxHeadDataSize;
        
        /// <summary>
        /// >> max_upward_queue_count
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardQueueCount;
        
        /// <summary>
        /// >> max_upward_queue_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardQueueSize;
        
        /// <summary>
        /// >> max_upward_message_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardMessageSize;
        
        /// <summary>
        /// >> max_upward_message_num_per_candidate
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxUpwardMessageNumPerCandidate;
        
        /// <summary>
        /// >> hrmp_max_message_num_per_candidate
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpMaxMessageNumPerCandidate;
        
        /// <summary>
        /// >> validation_upgrade_cooldown
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _validationUpgradeCooldown;
        
        /// <summary>
        /// >> validation_upgrade_delay
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _validationUpgradeDelay;
        
        /// <summary>
        /// >> async_backing_params
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.AsyncBackingParams _asyncBackingParams;
        
        /// <summary>
        /// >> max_pov_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxPovSize;
        
        /// <summary>
        /// >> max_downward_message_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxDownwardMessageSize;
        
        /// <summary>
        /// >> hrmp_max_parachain_outbound_channels
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpMaxParachainOutboundChannels;
        
        /// <summary>
        /// >> hrmp_sender_deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _hrmpSenderDeposit;
        
        /// <summary>
        /// >> hrmp_recipient_deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _hrmpRecipientDeposit;
        
        /// <summary>
        /// >> hrmp_channel_max_capacity
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpChannelMaxCapacity;
        
        /// <summary>
        /// >> hrmp_channel_max_total_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpChannelMaxTotalSize;
        
        /// <summary>
        /// >> hrmp_max_parachain_inbound_channels
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpMaxParachainInboundChannels;
        
        /// <summary>
        /// >> hrmp_channel_max_message_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _hrmpChannelMaxMessageSize;
        
        /// <summary>
        /// >> executor_params
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.executor_params.ExecutorParams _executorParams;
        
        /// <summary>
        /// >> code_retention_period
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _codeRetentionPeriod;
        
        /// <summary>
        /// >> on_demand_cores
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _onDemandCores;
        
        /// <summary>
        /// >> on_demand_retries
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _onDemandRetries;
        
        /// <summary>
        /// >> on_demand_queue_max_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _onDemandQueueMaxSize;
        
        /// <summary>
        /// >> on_demand_target_queue_utilization
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill _onDemandTargetQueueUtilization;
        
        /// <summary>
        /// >> on_demand_fee_variability
        /// </summary>
        private Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill _onDemandFeeVariability;
        
        /// <summary>
        /// >> on_demand_base_fee
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _onDemandBaseFee;
        
        /// <summary>
        /// >> on_demand_ttl
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _onDemandTtl;
        
        /// <summary>
        /// >> group_rotation_frequency
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _groupRotationFrequency;
        
        /// <summary>
        /// >> paras_availability_period
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _parasAvailabilityPeriod;
        
        /// <summary>
        /// >> scheduling_lookahead
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _schedulingLookahead;
        
        /// <summary>
        /// >> max_validators_per_core
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _maxValidatorsPerCore;
        
        /// <summary>
        /// >> max_validators
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _maxValidators;
        
        /// <summary>
        /// >> dispute_period
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _disputePeriod;
        
        /// <summary>
        /// >> dispute_post_conclusion_acceptance_period
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _disputePostConclusionAcceptancePeriod;
        
        /// <summary>
        /// >> no_show_slots
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _noShowSlots;
        
        /// <summary>
        /// >> n_delay_tranches
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _nDelayTranches;
        
        /// <summary>
        /// >> zeroth_delay_tranche_width
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _zerothDelayTrancheWidth;
        
        /// <summary>
        /// >> needed_approvals
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _neededApprovals;
        
        /// <summary>
        /// >> relay_vrf_modulo_samples
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _relayVrfModuloSamples;
        
        /// <summary>
        /// >> pvf_voting_ttl
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _pvfVotingTtl;
        
        /// <summary>
        /// >> minimum_validation_upgrade_delay
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _minimumValidationUpgradeDelay;
        
        /// <summary>
        /// >> minimum_backing_votes
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _minimumBackingVotes;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCodeSize
        {
            get
            {
                return this._maxCodeSize;
            }
            set
            {
                this._maxCodeSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxHeadDataSize
        {
            get
            {
                return this._maxHeadDataSize;
            }
            set
            {
                this._maxHeadDataSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueCount
        {
            get
            {
                return this._maxUpwardQueueCount;
            }
            set
            {
                this._maxUpwardQueueCount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueSize
        {
            get
            {
                return this._maxUpwardQueueSize;
            }
            set
            {
                this._maxUpwardQueueSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageSize
        {
            get
            {
                return this._maxUpwardMessageSize;
            }
            set
            {
                this._maxUpwardMessageSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageNumPerCandidate
        {
            get
            {
                return this._maxUpwardMessageNumPerCandidate;
            }
            set
            {
                this._maxUpwardMessageNumPerCandidate = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpMaxMessageNumPerCandidate
        {
            get
            {
                return this._hrmpMaxMessageNumPerCandidate;
            }
            set
            {
                this._hrmpMaxMessageNumPerCandidate = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ValidationUpgradeCooldown
        {
            get
            {
                return this._validationUpgradeCooldown;
            }
            set
            {
                this._validationUpgradeCooldown = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ValidationUpgradeDelay
        {
            get
            {
                return this._validationUpgradeDelay;
            }
            set
            {
                this._validationUpgradeDelay = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.AsyncBackingParams AsyncBackingParams
        {
            get
            {
                return this._asyncBackingParams;
            }
            set
            {
                this._asyncBackingParams = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxPovSize
        {
            get
            {
                return this._maxPovSize;
            }
            set
            {
                this._maxPovSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxDownwardMessageSize
        {
            get
            {
                return this._maxDownwardMessageSize;
            }
            set
            {
                this._maxDownwardMessageSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpMaxParachainOutboundChannels
        {
            get
            {
                return this._hrmpMaxParachainOutboundChannels;
            }
            set
            {
                this._hrmpMaxParachainOutboundChannels = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 HrmpSenderDeposit
        {
            get
            {
                return this._hrmpSenderDeposit;
            }
            set
            {
                this._hrmpSenderDeposit = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 HrmpRecipientDeposit
        {
            get
            {
                return this._hrmpRecipientDeposit;
            }
            set
            {
                this._hrmpRecipientDeposit = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpChannelMaxCapacity
        {
            get
            {
                return this._hrmpChannelMaxCapacity;
            }
            set
            {
                this._hrmpChannelMaxCapacity = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpChannelMaxTotalSize
        {
            get
            {
                return this._hrmpChannelMaxTotalSize;
            }
            set
            {
                this._hrmpChannelMaxTotalSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpMaxParachainInboundChannels
        {
            get
            {
                return this._hrmpMaxParachainInboundChannels;
            }
            set
            {
                this._hrmpMaxParachainInboundChannels = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpChannelMaxMessageSize
        {
            get
            {
                return this._hrmpChannelMaxMessageSize;
            }
            set
            {
                this._hrmpChannelMaxMessageSize = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.executor_params.ExecutorParams ExecutorParams
        {
            get
            {
                return this._executorParams;
            }
            set
            {
                this._executorParams = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 CodeRetentionPeriod
        {
            get
            {
                return this._codeRetentionPeriod;
            }
            set
            {
                this._codeRetentionPeriod = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 OnDemandCores
        {
            get
            {
                return this._onDemandCores;
            }
            set
            {
                this._onDemandCores = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 OnDemandRetries
        {
            get
            {
                return this._onDemandRetries;
            }
            set
            {
                this._onDemandRetries = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 OnDemandQueueMaxSize
        {
            get
            {
                return this._onDemandQueueMaxSize;
            }
            set
            {
                this._onDemandQueueMaxSize = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill OnDemandTargetQueueUtilization
        {
            get
            {
                return this._onDemandTargetQueueUtilization;
            }
            set
            {
                this._onDemandTargetQueueUtilization = value;
            }
        }
        
        public Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill OnDemandFeeVariability
        {
            get
            {
                return this._onDemandFeeVariability;
            }
            set
            {
                this._onDemandFeeVariability = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 OnDemandBaseFee
        {
            get
            {
                return this._onDemandBaseFee;
            }
            set
            {
                this._onDemandBaseFee = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 OnDemandTtl
        {
            get
            {
                return this._onDemandTtl;
            }
            set
            {
                this._onDemandTtl = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 GroupRotationFrequency
        {
            get
            {
                return this._groupRotationFrequency;
            }
            set
            {
                this._groupRotationFrequency = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ParasAvailabilityPeriod
        {
            get
            {
                return this._parasAvailabilityPeriod;
            }
            set
            {
                this._parasAvailabilityPeriod = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SchedulingLookahead
        {
            get
            {
                return this._schedulingLookahead;
            }
            set
            {
                this._schedulingLookahead = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> MaxValidatorsPerCore
        {
            get
            {
                return this._maxValidatorsPerCore;
            }
            set
            {
                this._maxValidatorsPerCore = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> MaxValidators
        {
            get
            {
                return this._maxValidators;
            }
            set
            {
                this._maxValidators = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 DisputePeriod
        {
            get
            {
                return this._disputePeriod;
            }
            set
            {
                this._disputePeriod = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 DisputePostConclusionAcceptancePeriod
        {
            get
            {
                return this._disputePostConclusionAcceptancePeriod;
            }
            set
            {
                this._disputePostConclusionAcceptancePeriod = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 NoShowSlots
        {
            get
            {
                return this._noShowSlots;
            }
            set
            {
                this._noShowSlots = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 NDelayTranches
        {
            get
            {
                return this._nDelayTranches;
            }
            set
            {
                this._nDelayTranches = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 ZerothDelayTrancheWidth
        {
            get
            {
                return this._zerothDelayTrancheWidth;
            }
            set
            {
                this._zerothDelayTrancheWidth = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 NeededApprovals
        {
            get
            {
                return this._neededApprovals;
            }
            set
            {
                this._neededApprovals = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 RelayVrfModuloSamples
        {
            get
            {
                return this._relayVrfModuloSamples;
            }
            set
            {
                this._relayVrfModuloSamples = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 PvfVotingTtl
        {
            get
            {
                return this._pvfVotingTtl;
            }
            set
            {
                this._pvfVotingTtl = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MinimumValidationUpgradeDelay
        {
            get
            {
                return this._minimumValidationUpgradeDelay;
            }
            set
            {
                this._minimumValidationUpgradeDelay = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MinimumBackingVotes
        {
            get
            {
                return this._minimumBackingVotes;
            }
            set
            {
                this._minimumBackingVotes = value;
            }
        }
        
        public override string TypeName()
        {
            return "HostConfiguration";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxCodeSize.Encode());
            result.AddRange(MaxHeadDataSize.Encode());
            result.AddRange(MaxUpwardQueueCount.Encode());
            result.AddRange(MaxUpwardQueueSize.Encode());
            result.AddRange(MaxUpwardMessageSize.Encode());
            result.AddRange(MaxUpwardMessageNumPerCandidate.Encode());
            result.AddRange(HrmpMaxMessageNumPerCandidate.Encode());
            result.AddRange(ValidationUpgradeCooldown.Encode());
            result.AddRange(ValidationUpgradeDelay.Encode());
            result.AddRange(AsyncBackingParams.Encode());
            result.AddRange(MaxPovSize.Encode());
            result.AddRange(MaxDownwardMessageSize.Encode());
            result.AddRange(HrmpMaxParachainOutboundChannels.Encode());
            result.AddRange(HrmpSenderDeposit.Encode());
            result.AddRange(HrmpRecipientDeposit.Encode());
            result.AddRange(HrmpChannelMaxCapacity.Encode());
            result.AddRange(HrmpChannelMaxTotalSize.Encode());
            result.AddRange(HrmpMaxParachainInboundChannels.Encode());
            result.AddRange(HrmpChannelMaxMessageSize.Encode());
            result.AddRange(ExecutorParams.Encode());
            result.AddRange(CodeRetentionPeriod.Encode());
            result.AddRange(OnDemandCores.Encode());
            result.AddRange(OnDemandRetries.Encode());
            result.AddRange(OnDemandQueueMaxSize.Encode());
            result.AddRange(OnDemandTargetQueueUtilization.Encode());
            result.AddRange(OnDemandFeeVariability.Encode());
            result.AddRange(OnDemandBaseFee.Encode());
            result.AddRange(OnDemandTtl.Encode());
            result.AddRange(GroupRotationFrequency.Encode());
            result.AddRange(ParasAvailabilityPeriod.Encode());
            result.AddRange(SchedulingLookahead.Encode());
            result.AddRange(MaxValidatorsPerCore.Encode());
            result.AddRange(MaxValidators.Encode());
            result.AddRange(DisputePeriod.Encode());
            result.AddRange(DisputePostConclusionAcceptancePeriod.Encode());
            result.AddRange(NoShowSlots.Encode());
            result.AddRange(NDelayTranches.Encode());
            result.AddRange(ZerothDelayTrancheWidth.Encode());
            result.AddRange(NeededApprovals.Encode());
            result.AddRange(RelayVrfModuloSamples.Encode());
            result.AddRange(PvfVotingTtl.Encode());
            result.AddRange(MinimumValidationUpgradeDelay.Encode());
            result.AddRange(MinimumBackingVotes.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxCodeSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxCodeSize.Decode(byteArray, ref p);
            MaxHeadDataSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxHeadDataSize.Decode(byteArray, ref p);
            MaxUpwardQueueCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueCount.Decode(byteArray, ref p);
            MaxUpwardQueueSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueSize.Decode(byteArray, ref p);
            MaxUpwardMessageSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageSize.Decode(byteArray, ref p);
            MaxUpwardMessageNumPerCandidate = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageNumPerCandidate.Decode(byteArray, ref p);
            HrmpMaxMessageNumPerCandidate = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpMaxMessageNumPerCandidate.Decode(byteArray, ref p);
            ValidationUpgradeCooldown = new Substrate.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeCooldown.Decode(byteArray, ref p);
            ValidationUpgradeDelay = new Substrate.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeDelay.Decode(byteArray, ref p);
            AsyncBackingParams = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.vstaging.AsyncBackingParams();
            AsyncBackingParams.Decode(byteArray, ref p);
            MaxPovSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxPovSize.Decode(byteArray, ref p);
            MaxDownwardMessageSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxDownwardMessageSize.Decode(byteArray, ref p);
            HrmpMaxParachainOutboundChannels = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpMaxParachainOutboundChannels.Decode(byteArray, ref p);
            HrmpSenderDeposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            HrmpSenderDeposit.Decode(byteArray, ref p);
            HrmpRecipientDeposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            HrmpRecipientDeposit.Decode(byteArray, ref p);
            HrmpChannelMaxCapacity = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpChannelMaxCapacity.Decode(byteArray, ref p);
            HrmpChannelMaxTotalSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpChannelMaxTotalSize.Decode(byteArray, ref p);
            HrmpMaxParachainInboundChannels = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpMaxParachainInboundChannels.Decode(byteArray, ref p);
            HrmpChannelMaxMessageSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpChannelMaxMessageSize.Decode(byteArray, ref p);
            ExecutorParams = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_primitives.v5.executor_params.ExecutorParams();
            ExecutorParams.Decode(byteArray, ref p);
            CodeRetentionPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            CodeRetentionPeriod.Decode(byteArray, ref p);
            OnDemandCores = new Substrate.NetApi.Model.Types.Primitive.U32();
            OnDemandCores.Decode(byteArray, ref p);
            OnDemandRetries = new Substrate.NetApi.Model.Types.Primitive.U32();
            OnDemandRetries.Decode(byteArray, ref p);
            OnDemandQueueMaxSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            OnDemandQueueMaxSize.Decode(byteArray, ref p);
            OnDemandTargetQueueUtilization = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            OnDemandTargetQueueUtilization.Decode(byteArray, ref p);
            OnDemandFeeVariability = new Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
            OnDemandFeeVariability.Decode(byteArray, ref p);
            OnDemandBaseFee = new Substrate.NetApi.Model.Types.Primitive.U128();
            OnDemandBaseFee.Decode(byteArray, ref p);
            OnDemandTtl = new Substrate.NetApi.Model.Types.Primitive.U32();
            OnDemandTtl.Decode(byteArray, ref p);
            GroupRotationFrequency = new Substrate.NetApi.Model.Types.Primitive.U32();
            GroupRotationFrequency.Decode(byteArray, ref p);
            ParasAvailabilityPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            ParasAvailabilityPeriod.Decode(byteArray, ref p);
            SchedulingLookahead = new Substrate.NetApi.Model.Types.Primitive.U32();
            SchedulingLookahead.Decode(byteArray, ref p);
            MaxValidatorsPerCore = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            MaxValidatorsPerCore.Decode(byteArray, ref p);
            MaxValidators = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            MaxValidators.Decode(byteArray, ref p);
            DisputePeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            DisputePeriod.Decode(byteArray, ref p);
            DisputePostConclusionAcceptancePeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            DisputePostConclusionAcceptancePeriod.Decode(byteArray, ref p);
            NoShowSlots = new Substrate.NetApi.Model.Types.Primitive.U32();
            NoShowSlots.Decode(byteArray, ref p);
            NDelayTranches = new Substrate.NetApi.Model.Types.Primitive.U32();
            NDelayTranches.Decode(byteArray, ref p);
            ZerothDelayTrancheWidth = new Substrate.NetApi.Model.Types.Primitive.U32();
            ZerothDelayTrancheWidth.Decode(byteArray, ref p);
            NeededApprovals = new Substrate.NetApi.Model.Types.Primitive.U32();
            NeededApprovals.Decode(byteArray, ref p);
            RelayVrfModuloSamples = new Substrate.NetApi.Model.Types.Primitive.U32();
            RelayVrfModuloSamples.Decode(byteArray, ref p);
            PvfVotingTtl = new Substrate.NetApi.Model.Types.Primitive.U32();
            PvfVotingTtl.Decode(byteArray, ref p);
            MinimumValidationUpgradeDelay = new Substrate.NetApi.Model.Types.Primitive.U32();
            MinimumValidationUpgradeDelay.Decode(byteArray, ref p);
            MinimumBackingVotes = new Substrate.NetApi.Model.Types.Primitive.U32();
            MinimumBackingVotes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
