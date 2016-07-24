using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Business.Entities.Survey
{
    public class SurveyQuestion
    {
        public string Question { get; set; }
        public List<string> AnswerPossibilities { get; set; }
    }
}
