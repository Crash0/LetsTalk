using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Utils;
using static System.Data.Entity.EntityState;

namespace LetsTalk.Core.Common.Data
{
    public abstract class DataRepositoryBase<T, U> : IDataRepository<T>
        where T : class, IIdentifiableEntity, new()
        where U : DbContext, new()
    {
        public T Add(T entity)
        {
            using (var dbContext = new U())
            {
                var addedEntity = AddEntity(dbContext, entity);
                dbContext.SaveChanges();
                return addedEntity;
            }
        }

        //TODO: Should mabye set just deleted flag?
        public void Remove(T entity)
        {
            using (var dbcontext = new U())
            {
                dbcontext.Entry(entity).State = Deleted;
                dbcontext.SaveChanges();
            }
        }

        public void Remove(Guid id)
        {
            using (var dbcontext = new U())
            {
                var entity = GetEntity(dbcontext, id);
                dbcontext.Entry(entity).State = Deleted;
                dbcontext.SaveChanges();
            }
        }

        public T Update(T entity)
        {
            using (var dbContext = new U())
            {
                var existingEntity = UpdateEntity(dbContext, entity);

                SimpleMapper.PropertyMap(entity, existingEntity);

                dbContext.SaveChanges();
                return existingEntity;
            }
        }

        public IEnumerable<T> Get()
        {
            using (var dbContext = new U())
                return GetEntities(dbContext).ToArray().ToList();
        }

        public T Get(Guid id)
        {
            using (var dbContext = new U())
                return GetEntity(dbContext, id);
        }

        protected abstract T AddEntity(U entityContext, T entity);
        protected abstract T UpdateEntity(U entityContext, T entity);
        protected abstract IEnumerable<T> GetEntities(U entityContext);
        protected abstract T GetEntity(U entityContext, Guid id);
    }
}