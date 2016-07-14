using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Surveys.Data.Contracts;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Business.Entities.Surveys;
using LetsTalk.Core.Common.Data;
using System.ComponentModel.Composition;

namespace LetsTalk.Surveys.Data
{
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
                where e.Id == id
                select e;

            var result = query.FirstOrDefault();

            return result;
        }

        protected override Survey UpdateEntity(SurveyDbContext entityContext, Survey entity)
        {
            return (from e in entityContext.SurveySet
                where e.Id == entity.Id
                select e).FirstOrDefault();
            ;
        }
    }
}
