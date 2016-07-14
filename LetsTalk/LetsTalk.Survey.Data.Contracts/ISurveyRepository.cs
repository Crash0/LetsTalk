using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Surveys;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Surveys.Data.Contracts
{
    public interface ISurveyRepository : IDataRepository<Survey>
    {
    }
}
