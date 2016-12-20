#region Header
// <copyright file="ISurveyQuestion.cs" company="GoDialog AS">
// File Created:  07/12-2016
// Last Modified: 07/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Core.Common.Contracts.Entities
{
    using System;
    using System.Collections.Generic;

    public interface ISurveyQuestion
    {
        Guid QuestionId { get; }

        int QuestionNumber { get; set; }

        string Question { get; set; }

        string Description { get; set; }

        // TODO: should this be in a separate Entity?
        List<ISurveyAlternative> AnswerPossibilities { get; set; }
    }
}