﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddSurveyHandelerTests.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace LetsTalk.Services.SurveyService.Tests.Handlers
{
    using System;
    using System.Collections.Generic;

    using LetsTalk.Business.Entities.Miscellaneous;
    using LetsTalk.Business.Entities.Survey;
    using LetsTalk.Services.SurveyService.Data;
    using LetsTalk.Services.SurveyService.Handlers;

    using Moq;

    using NServiceBus.Testing;

    using Xunit;

    /// <summary>
    ///     TODO The add survey handeler tests.
    /// </summary>
    public class AddSurveyHandelerTests
    {
        /// <summary>
        ///     TODO The funk_desctiption_result.
        /// </summary>
        [Fact]
        public void Funk_desctiption_result()
        {
            var saveGuid = new Guid();

            // Setup
            //var survey = new Survey
            //                 {
            //                     #region Survey settup

            //                     Title = "Undersøkelse om folks do vaner",
            //                     Description = "Dette er en test undersøkelse om folks do vaner",
            //                     ApplicableAgeGroup =
            //                         new DateRange
            //                             {
            //                                 StartDate = new DateTime(1990, 1, 1),
            //                                 StopDate = new DateTime(1999, 1, 1)
            //                             },
            //                     Questions =
            //                         new List<SurveyQuestion>
            //                             {
            //                                 new SurveyQuestion
            //                                     {
            //                                         Question =
            //                                             "How Manny times do you go to the toilet in a day?",
            //                                         AnswerPossibilities =
            //                                             new List<string>
            //                                                 {
            //                                                     "Once",
            //                                                     "2 - 4",
            //                                                     "5 or more"
            //                                                 }
            //                                     },
            //                                 new SurveyQuestion
            //                                     {
            //                                         Question =
            //                                             "How Manny times do you wach toilet in a month?",
            //                                         AnswerPossibilities =
            //                                             new List<string>
            //                                                 {
            //                                                     "Once",
            //                                                     "2 - 4",
            //                                                     "5 or more"
            //                                                 }
            //                                     },
            //                                 new SurveyQuestion
            //                                     {
            //                                         Question =
            //                                             "How Manny times do you use others toilet in a week?",
            //                                         AnswerPossibilities =
            //                                             new List<string>
            //                                                 {
            //                                                     "Once",
            //                                                     "2 - 4",
            //                                                     "5 or more"
            //                                                 }
            //                                     }
            //                             }
            //                 };
                //#endregion

                var survey = new Survey();

            var repository = new Mock<ISurveyRepository>();
            repository.Setup(r => r.Add(It.IsAny<Survey>())).Returns(() => survey);

            var s = repository.Object.Add(survey);

            Test.Initialize();
            Test.Handler(bus => new AddSurveyHandeler(bus));
        }
    }
}