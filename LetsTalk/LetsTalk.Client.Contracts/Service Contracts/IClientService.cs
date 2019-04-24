using System.Collections.Generic;
using System.ServiceModel;
using LetsTalk.Core.Common.Contracts;
using CE = LetsTalk.Client.Entities;

namespace LetsTalk.Client.Contracts
{
    [ServiceContract]
    public interface IClientService : IServiceContract
    {
        [OperationContract]
        CE.Client GetClient(string id);

        [OperationContract]
        CE.Client CreateClient(CE.Client client);

        [OperationContract]
        CE.Client[] GetClients();

    }
}