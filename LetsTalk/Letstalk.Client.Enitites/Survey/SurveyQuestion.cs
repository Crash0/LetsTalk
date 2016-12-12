using System;
using System.Collections.Generic;
using LetsTalk.Core.Common.Contracts.Entities;

namespace Letstalk.Client.Entities
{
    public class SurveyQuestion : ISurveyQuestion
    {
        public Guid QuestionId { get; }
        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public string Description { get; set; }
        public List<string> AnswerPossibilities { get; set; }
    }
}
