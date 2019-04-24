using System.Collections.Generic;
using System.ComponentModel.Composition;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.ServiceModel;

namespace LetsTalk.Client.Proxies
{
    [Export(typeof(IClientService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClientClient : UserClientBase<IClientService>, IClientService
    {
        public LetsTalk.Client.Entities.Client GetClient(string id)
        {
            return Channel.GetClient(id);
        }

        public LetsTalk.Client.Entities.Client CreateClient(LetsTalk.Client.Entities.Client client)
        {
            return Channel.CreateClient(client);
        }

        public LetsTalk.Client.Entities.Client[] GetClients()
        {
            var  d = Channel.GetClients();
            return d;
        }
    }
}
