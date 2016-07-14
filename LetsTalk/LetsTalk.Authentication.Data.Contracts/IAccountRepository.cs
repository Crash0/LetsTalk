using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Authentication.Data.Contracts
{
    public interface IAccountRepository : IDataRepository<UserAccount>
    {
        UserAccount GetByLogin(string login);
    }
}
