﻿#region Header
// <copyright file="ISyrveyResponse.cs" company="GoDialog AS">
// File Created:  08/12-2016
// Last Modified: 08/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.Collections.Generic;

namespace LetsTalk.Core.Common.Contracts.Entities
{
    using System;

    public interface ISurveyResponse
    {
        Guid SurveyResponseId { get; }

        // TODO deside if this is going to be a list of string 
        // or a Entity of response tiems.
        ICollection<ISurveyQuestionResponse> Responses { get; set; }
    }

    public interface ISurveyQuestionResponse
    {
        /// <summary>
        /// The Owning response
        /// </summary>
        ISurveyQuestion Question { get; }
        

        Guid QuestionId { get; }

        Guid SelectedResponseId { get; set; }

        ISurveyAlternative SelectedAlternative { get; }


    }
}