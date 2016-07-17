using System.Collections.Generic;
using System.ServiceModel;
using LetsTalk.Business.Entities;

namespace LetsTalk.Business.Contracts
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Client CreateClient(Client client);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Client[] GetClients();

        [OperationContract]
        Client GetClient(string id);
    }
}
