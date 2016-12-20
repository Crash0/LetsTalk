using System;
using System.Collections.Generic;
using LetsTalk.Core.Common.Contracts.Entities;

namespace Letstalk.Client.Entities
{
    public class SurveyQuestion : ISurveyQuestion, ISurveyQuestionResponse
    {
        public SurveyQuestion()
        {
            QuestionId = Guid.NewGuid();
            AnswerPossibilities = new List<ISurveyAlternative>();
        }
        ISurveyQuestion ISurveyQuestionResponse.Question => this;

        public Guid QuestionId { get; }
        public Guid SelectedResponseId { get; set; }

        public IEnumerable<ISurveyAlternative> SelectedAlternative { get; }
        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public string Description { get; set; }
        public List<ISurveyAlternative> AnswerPossibilities { get; set; }

        public void AddAnswer(SurveyAlternative surveyAlternative)
        {
            surveyAlternative.OwnerQuestion = this.QuestionId;
            //TODO: Add valitation to alternative
            AnswerPossibilities.Add(surveyAlternative);
        }
    }
}
