using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Business.Entities.Survey
{
    using LetsTalk.Core.Common.Contracts.Entities;

    public class SurveyQuestion : ISurveyQuestion
    {
        public string Question { get; set; }

        public List<string> AnswerPossibilities { get; set; }
    }
}
