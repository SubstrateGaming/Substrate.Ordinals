using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime;
using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.Polkadot.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using System.Numerics;

namespace Substrate.Integration.Call
{
    /// <summary>
    /// Frame System
    /// </summary>
    public static class FrameSystem
    {
        public static EnumRuntimeCall Remark(BaseVec<U8> remark)
        {

            var enumPalletCall = new Polkadot.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumCall();
            enumPalletCall.Create(Polkadot.NET.NetApiExt.Generated.Model.frame_system.pallet.Call.remark, remark);

            var enumCall = new EnumRuntimeCall();
            enumCall.Create(RuntimeCall.System, enumPalletCall);

            return enumCall;
        }

    }
}