#region Header
// <copyright file="SurveyResponse.cs" company="GoDialog AS">
// File Created:  12/12-2016
// Last Modified: 12/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System;
using System.Collections.Generic;
using LetsTalk.Core.Common.Contracts.Entities;

namespace Letstalk.Client.Entities
{
    public class SurveyResponse : ISurveyResponse 
    {
        public Guid SurveyResponseId { get; set; }
        public ICollection<ISurveyQuestionResponse> Responses { get; set; }
    }
}