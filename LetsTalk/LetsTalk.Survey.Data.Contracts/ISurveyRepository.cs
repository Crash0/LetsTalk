﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Surveys.Data.Contracts
{
    using LetsTalk.Business.Entities.Survey;

    public interface ISurveyRepository : IDataRepository<Survey>
    {
    }
}
