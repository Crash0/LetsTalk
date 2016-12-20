// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Survey.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Letstalk.Client.Entities
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using LetsTalk.Core.Common.Contracts.Entities;
    using LetsTalk.Core.Common.Core;

    #endregion

    /// <summary>
    /// Client Implementation of ISurvey.
    /// </summary>
    public class Survey : ObjectBase, ISurvey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Survey"/> class.
        /// </summary>
        public Survey()
        {
            this.SurveyId = Guid.NewGuid();
            this.CreatedDateTime = this.LastModified = DateTime.Now;
            this.Questions = new List<ISurveyQuestion>();
            this.Description = string.Empty;

        }

        /// <summary>
        /// Gets the <see cref="Guid"/> of the user the <see cref="Survey"/> is created by.
        /// </summary>
        public Guid CreatedBy { get; }

        /// <summary>
        /// Gets the <see cref="DateTime"/> the Survey was created.
        /// </summary>
        public DateTime CreatedDateTime { get; }

        /// <summary>
        /// Gets or sets the description of the <see cref="Survey"/>.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the last modified <see cref="DateTime"/>.
        /// </summary>
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets the <see cref="List{T}"/> of <see cref="ISurveyQuestion"/>.
        /// </summary>
        public List<ISurveyQuestion> Questions { get; private set; }

        /// <summary>
        /// Gets the <see cref="Guid"/> SurveyId.
        /// </summary>
        public Guid SurveyId { get; }

        /// <summary>
        /// Gets or sets <see cref="Survey"/> the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// TODO The add question.
        /// </summary>
        /// <param name="question">
        /// TODO The question.
        /// </param>
        public void AddQuestion(ISurveyQuestion question)
        {
            // TODO: Fix this smelly thingy :warning: 
            question.QuestionNumber = this.Questions.Count;
            this.Questions.Add(question);
        }
    }
}