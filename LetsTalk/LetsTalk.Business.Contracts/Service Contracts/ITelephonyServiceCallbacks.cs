using System.ServiceModel;
using LetsTalk.Business.Contracts;

namespace LetsTalk.Business.Contracts
{
    [ServiceContract]
    public interface ITelephonyServiceCallbacks
    {
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
