using System;
using System.ServiceModel;
using LetsTalk.Business.Contracts;
using LetsTalk.Business.Entities;

namespace LetsTalk.Business.Managers
{
    [ServiceBehavior(
        InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        ReleaseServiceInstanceOnTransactionComplete = false
        )]
    public class ClientManager : ManagerBase, IClientService
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public Client CreateClient(Client client)
        {
            //TODO: implement
            client.ClientId = new Guid();
            return client;
        }

        public Client[] GetClients()
        {
           //TODO: implemet bussing
            var clients =  new Client[]
           {
               new Client()
               {
                   ClientId = Guid.NewGuid(),
                   GivenName = "Jon",
                   Email = "User1@live.no",
                   FamilyName = "Doe",
                   CorrelationGuid = Guid.Empty,
                   EntityId = Guid.Empty,
                   ExtensionData = null
               },
               new Client()
               {
                   ClientId = Guid.NewGuid(),
                   GivenName = "Ola",
                   Email = "User2@live.no",
                   FamilyName = "Normann",
                   CorrelationGuid = Guid.Empty,
                   EntityId = Guid.Empty,
                   ExtensionData = null
               }
           };

            return clients;
        }

        public Client GetClient(string id)
        {
            return new Client()
            {
                ClientId = Guid.NewGuid(),
                GivenName = "Ola",
                Email = "User2@live.no",
                FamilyName = "Normann",
                CorrelationGuid = Guid.Empty,
                EntityId = Guid.Empty,
                ExtensionData = null
            };
        }
    }
}
