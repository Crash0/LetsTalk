// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISurvey.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LetsTalk.Core.Common.Contracts.Entities
{
    #region Usings

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// TODO The Survey interface.
    /// </summary>
    public interface ISurvey
    {
        /// <summary>
        /// Gets the created by.
        /// </summary>
        Guid CreatedBy { get; }

        /// <summary>
        /// Gets the created date time.
        /// </summary>
        DateTime CreatedDateTime { get; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the last modified.
        /// </summary>
        DateTime LastModified { get; set; }

        /// <summary>
        /// Gets the questions.
        /// </summary>
        List<ISurveyQuestion> Questions { get; }

        /// <summary>
        /// Gets the survey id.
        /// </summary>
        Guid SurveyId { get; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        string Title { get; set; }
    }
}