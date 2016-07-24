using System.Collections.Generic;

namespace Letstalk.Client.Entities
{
    public class SurveyQuestion
    {
        public string Question { get; set; }
        public List<string> AnswerPossibilities { get; set; }
    }
}
