using System;
using System.Collections.Generic;
using LetsTalk.Business.Entities.Miscellaneous;
using LetsTalk.Business.Entities.Survey;
using LetsTalk.Business.Entities.Surveys;
using LetsTalk.Services.SurveyService.Handlers;
using LetsTalk.Surveys.Data.Contracts;
using Moq;
using NServiceBus.Testing;
using Xunit;

namespace LetsTalk.Services.SurveyService.Tests.Handlers
{
    public class AddSurveyHandelerTests
    {
        [Fact]
        public void Funk_desctiption_result()
        {
            var saveGuid = new Guid();
            //Setup
            var survey = new Survey
            #region Survey settup
            {
                Title = "Undersøkelse om folks do vaner",
                Description = "Dette er en test undersøkelse om folks do vaner",
                ApplicableAgeGroup = new DateRange
                {
                    StartDate = new DateTime(1990,1,1),
                    StopDate = new DateTime(1999,1,1)
                },
                Questions = new List<SurveyQuestion>
                {
                    new SurveyQuestion
                    {
                        Question = "How Manny times do you go to the toilet in a day?",
                        AnswerPossibilities = new List<string> { "Once", "2 - 4","5 or more"}

                    },
                    new SurveyQuestion
                    {
                        Question = "How Manny times do you wach toilet in a month?",
                        AnswerPossibilities = new List<string> { "Once", "2 - 4","5 or more"}

                    },
                    new SurveyQuestion
                    {
                        Question = "How Manny times do you use others toilet in a week?",
                        AnswerPossibilities = new List<string> { "Once", "2 - 4","5 or more"}

                    }
                }
            };
#endregion

            var repository = new Mock<ISurveyRepository>();
            repository.Setup(r => r.Add(It.IsAny<Survey>())).Returns(() => survey);

            var s = repository.Object.Add(survey);

            Test.Initialize();
            Test.Handler(bus => new AddSurveyHandeler(bus));
        }
    }
}
