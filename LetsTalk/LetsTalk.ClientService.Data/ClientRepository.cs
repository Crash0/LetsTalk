using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Client;
using LetsTalk.ClientService.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Data;

namespace LetsTalk.ClientService.Data
{
    [Export(typeof(IClientRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ClientRepository : DataRepositoryBase<Client, ClientDbContext>, IClientRepository
    {
        protected override Client AddEntity(ClientDbContext entityContext, Client entity)
        {
            return entityContext.ClientSet.Add(entity);
        }

        protected override Client UpdateEntity(ClientDbContext entityContext, Client entity)
        {
            return (from e in entityContext.ClientSet
                    where e.ClientId == entity.ClientId
                    select e).FirstOrDefault();
        }

        protected override IEnumerable<Client> GetEntities(ClientDbContext entityContext)
        {
            return from userAccounts in entityContext.ClientSet select userAccounts;
        }

        protected override Client GetEntity(ClientDbContext entityContext, Guid id)
        {
            var query = from e in entityContext.ClientSet
                        where e.ClientId == id
                        select e;
            var results = query.FirstOrDefault();
            return results;
        }
    }
}
