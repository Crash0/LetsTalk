using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Targeting;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Data;

namespace LetsTalk.Services.TargetingService.Data
{
    [Export(typeof(ITargetRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public sealed class TargetRepository : DataRepositoryBase<Target, TargetServiceDbContext> ITargetRepository
    {
        protected override Target AddEntity(TargetServiceDbContext entityContext, Target entity)
        {
            return entityContext.TargetSet.Add(entity);
        }

        [Obsolete]
        protected override IEnumerable<Target> GetEntities(TargetServiceDbContext entityContext)
        {
            return from t in entityContext.TargetSet select t;
        }

        protected override Target GetEntity(TargetServiceDbContext entityContext, Guid id)
        {
            var query =  (from e in entityContext.TargetSet
                where e.TargetId == id
                select e);
            return query.FirstOrDefault();
        }

        protected override Target UpdateEntity(TargetServiceDbContext entityContext, Target entity)
        {
            var query = (from e in entityContext.TargetSet
                         where e.TargetId == entity.TargetId
                         select e);
            return query.FirstOrDefault();
        }
    }
}
