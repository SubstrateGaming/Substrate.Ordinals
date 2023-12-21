using Substrate.Polkadot.NET.NetApiExt.Generated.Model.polkadot_runtime;

namespace Substrate.Integration.Call
{
    public interface ICall
    {
        EnumRuntimeCall ToCall();
    }
}