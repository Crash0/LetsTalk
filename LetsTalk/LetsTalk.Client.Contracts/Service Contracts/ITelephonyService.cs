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

        [OperationContract]
        bool Ping();
    }
    public delegate void CallerConnectEvent(object sender, CallerInfo args);

    public delegate void ConnectSucceededEvent(object seder);

    [ServiceContract]
    public interface ITelephonyServiceCallbacks
    {
        event CallerConnectEvent OnCallerConnect;
        event ConnectSucceededEvent OnConnectionSucceeded;

        [OperationContract]
        void CallerConnect(CallerInfo caller);

        [OperationContract]
        void ConnectionSucceeded();
    }
}
