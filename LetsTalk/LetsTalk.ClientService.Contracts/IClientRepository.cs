using LetsTalk.Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Client;

namespace LetsTalk.ClientService.Contracts
{
    public interface IClientRepository : IDataRepository<Client>
    {

    }
}
