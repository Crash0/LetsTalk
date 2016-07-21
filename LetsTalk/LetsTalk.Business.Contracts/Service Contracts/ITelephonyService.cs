using System;
using System.ServiceModel;
using LetsTalk.Business.Contracts;

namespace LetsTalk.Business.Contracts
{
    [ServiceContract(CallbackContract = typeof(ITelephonyServiceCallbacks))]
    public interface ITelephonyService
    {
        [OperationContract]
        bool CloseCall(string callId);

        [OperationContract]
        bool Connect(Guid agentId);

        bool SendCallTo(Guid agentId, CallerInfo callInfo);
    }
}