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
    using System.Collections.Generic;

    public interface ISurveyQuestion
    {
        string Question { get; set; }
        List<string> AnswerPossibilities { get; set; }
    }
}