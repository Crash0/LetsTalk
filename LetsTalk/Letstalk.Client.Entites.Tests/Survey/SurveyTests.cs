using System;
using LetsTalk.Client.Entities;
using LetsTalk.Core.Common.Contracts.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LetsTalk.Client.Entites.Tests
{
    [TestClass]
    public class SurveyTests
    {
        [TestMethod]
        public void Cast_ToISurvey_ReturnsNotNull()
        {
            // Arange 
            var survey = new Survey();

            // Act
            ISurvey cast = (ISurvey)survey;

            // Assert
            Assert.IsNotNull(cast);
        }
        
        [TestMethod]
        public void CreateInstanceHasDefaultParameters()
        {
            // Act Arrange
            var survey = new Survey();

            // Assert
            Assert.AreNotEqual(survey.SurveyId, Guid.Empty, "Survey Does not have a ID");
            Assert.IsNotNull(survey.Questions, "Survey questions is null");        
            Assert.IsNotNull(survey.CreatedDateTime, "Survey CreatedDateTime is null");
            Assert.AreEqual(survey.CreatedDateTime, survey.LastModified, "Survey last modified is not equal to creationtime on newly created inctance");
            Assert.IsNotNull(survey.Description, "survey.Description is null");

        }

        [TestMethod]
        public void AddQuestionAddsQuestionToList()
        {
            var survey = new Survey();
            Guid questionId;

            var question = new SurveyQuestion { Question = "How Manny times do you go to the toilet in a day?" };
            questionId = question.QuestionId;
            question.AddAnswer(new SurveyAlternative("Never"));
            question.AddAnswer(new SurveyAlternative("Once"));
            question.AddAnswer(new SurveyAlternative("2 - 4"));
            question.AddAnswer(new SurveyAlternative("5 or more"));

            survey.AddQuestion(question);

            Assert.IsTrue(survey.Questions.Exists(surveyQuestion => surveyQuestion.QuestionId == questionId));

        }
    }
}
