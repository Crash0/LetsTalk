using System;
using System.Collections.Generic;
using LetsTalk.Core.Common.Core;

namespace Letstalk.Client.Entities
{
    using LetsTalk.Core.Common.Contracts.Entities;
    public class Survey : ObjectBase, ISurvey
    {
        public Guid Id { get; set; }

        public Guid CreatedBy { get; }

        public DateTime CreatedDateTime { get; }

        public DateTime LastModifyed { get; set; }

        public List<ISurveyQuestion> Questions { get; private set; }

        public void AddQuestion(ISurveyQuestion question)
        {
            if (Questions == null)
            {
                Questions = new List<ISurveyQuestion>();
            }

            //TODO: Fix this smelly thingy :warning: 
            question.QuestionNumber = Questions.Count;
            Questions.Add(question);
        }

        public string Title { get; set; } 
        
        public string Description { get; set; }
        
        public Guid EntityId
        {
            get { return Id; }
            set { Id = value; }
        }

    }
}
