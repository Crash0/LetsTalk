using System;
using System.ServiceModel;
using System.Threading.Tasks;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Client.Contracts
{
    [ServiceContract(CallbackContract = typeof(ITelephonyServiceCallbacks))]
    public interface ITelephonyService : IServiceContract
    {

        [OperationContract]
        bool Connect(Guid agentId);

        [OperationContract]
        bool CloseCall(Guid callId);
        [OperationContract]
        Task<bool> CloseCallAsync(Guid callId);

        ITelephonyServiceCallbacks GetCallbacks();

    }
    public delegate void CallerConnectEvent(object sender, CallerInfo args);

    [ServiceContract]
    public interface ITelephonyServiceCallbacks
    {
        event CallerConnectEvent OnCallerConnect; 

        [OperationContract]
        void CallerConnect(CallerInfo caller);
    }
}
