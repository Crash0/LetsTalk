namespace LetsTalk.Client.Contracts
{
    using System;
    using System.ServiceModel;
    using System.Threading.Tasks;

    using LetsTalk.Client.Contracts.DataContracts;
    using LetsTalk.Core.Common.Contracts;

    public delegate void CallerConnectEvent(object sender, CallerInfo args);

    public delegate void ConnectSucceededEvent(object seder);

    public delegate void ServerDisconnectEvent(object sender);

    public delegate void ConnectionFailedEvent(object sender, ConnectionFailedInfo failedInfo);


    [ServiceContract(CallbackContract = typeof(ITelephonyServiceCallbacks))]
    public interface ITelephonyService : IServiceContract
    {

        [OperationContract]
        bool Connect(Guid agentId);

        [OperationContract]
        bool Disconnect(Guid agentId);

        [OperationContract]
        bool CloseCall(Guid callId);

        [OperationContract]
        Task<bool> CloseCallAsync(Guid callId);

        ITelephonyServiceCallbacks GetCallbacks();

        [OperationContract]
        bool Ping();
    }
    

    [ServiceContract]
    public interface ITelephonyServiceCallbacks
    {
        event CallerConnectEvent OnCallerConnect;

        event ConnectSucceededEvent OnConnectionSucceeded;

        event ServerDisconnectEvent OnServerDisconnect;

        [OperationContract]
        void CallerConnect(CallerInfo caller);

        [OperationContract]
        void ConnectionSucceeded();

        [OperationContract]
        void ConnectionFailed(ConnectionFailedInfo failInfo);

        [OperationContract]
        void ServerDisconnect();
    }
}
