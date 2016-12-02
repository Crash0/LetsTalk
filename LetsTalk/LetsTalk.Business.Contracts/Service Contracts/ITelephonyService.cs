namespace LetsTalk.Business.Contracts
{
    using System;
    using System.ServiceModel;

    [ServiceContract(CallbackContract = typeof(ITelephonyServiceCallbacks))]
    public interface ITelephonyService
    {
        [OperationContract]
        bool CloseCall(string callId);

        [OperationContract]
        bool Connect(Guid agentId);

        [OperationContract]
        bool Disconnect(Guid agentId);

        [OperationContract]
        bool Ping();
        
        bool SendCallTo(Guid agentId, CallerInfo callInfo);
    }
}