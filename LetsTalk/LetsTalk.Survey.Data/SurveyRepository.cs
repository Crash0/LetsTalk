using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

using LetsTalk.Core.Common.Data;

namespace LetsTalk.Services.SurveyService.Data
{
    using LetsTalk.Business.Entities.Survey;
    using LetsTalk.Core.Common.Contracts.Entities;

    [Export(typeof(ISurveyRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class SurveyRepository : DataRepositoryBase<Survey, SurveyDbContext>, ISurveyRepository
    {
        protected override Survey AddEntity(SurveyDbContext entityContext, Survey entity)
        {
            return entityContext.SurveySet.Add(entity);
        }

        protected override IEnumerable<Survey> GetEntities(SurveyDbContext entityContext)
        {
            return from e in entityContext.SurveySet select e;
        }

        protected override Survey GetEntity(SurveyDbContext entityContext, Guid id)
        {
            var query = from e in entityContext.SurveySet
                where e.SurveyId == id
                select e;

            var result = query.FirstOrDefault();

            return result;
        }

        protected override Survey UpdateEntity(SurveyDbContext entityContext, Survey entity)
        {
            return (from e in entityContext.SurveySet
                where e.SurveyId == entity.SurveyId
                select e).FirstOrDefault();
            ;
        }
    }
}
