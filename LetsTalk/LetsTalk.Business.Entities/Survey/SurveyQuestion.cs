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
        public Guid QuestionId { get; }

        public int QuestionNumber { get; set; }

        public string Question { get; set; }

        public string Description { get; set; }

        public List<ISurveyAlternative> AnswerPossibilities { get; set; }
    }
}
