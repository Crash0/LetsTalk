using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.Serialization;
using LetsTalk.Authentication.Data.Contracts;
using LetsTalk.Business.Entities.Authentication;
using LetsTalk.Core.Common.Data;

namespace LetsTalk.Authentication.Data
{
    [Export(typeof(IAccountRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class UserAccountRepository : DataRepositoryBase<UserAccount, AuthorizationDbContext>,IAccountRepository
    {
        protected override UserAccount AddEntity(AuthorizationDbContext entityContext, UserAccount entity)
        {
            return entityContext.UserAccountSet.Add(entity);
        }

        protected override UserAccount UpdateEntity(AuthorizationDbContext entityContext, UserAccount entity)
        {
            return (from e in entityContext.UserAccountSet
                where e.AccountId == entity.AccountId
                select e).FirstOrDefault();
        }

        protected override IEnumerable<UserAccount> GetEntities(AuthorizationDbContext entityContext)
        {
            return from userAccounts in entityContext.UserAccountSet select userAccounts;
        }

        protected override UserAccount GetEntity(AuthorizationDbContext entityContext, Guid id)
        {
            var query = from e in entityContext.UserAccountSet
                where e.AccountId == id
                select e;
            var results = query.FirstOrDefault();
            return results;
        }

        public UserAccount GetByLogin(string login)
        {
            using (var dbContext = new AuthorizationDbContext())
            {
                return (from a in dbContext.UserAccountSet
                    where a.LoginEmail == login
                    select a).FirstOrDefault();
            }
        }
    }
}