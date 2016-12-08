#region Header
// <copyright file="ISyrveyResponse.cs" company="GoDialog AS">
// File Created:  08/12-2016
// Last Modified: 08/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Core.Common.Contracts.Entities
{
    using System;

    public interface ISurveyResponse
    {
        Guid SurveyResponseId { get; set; }

        // TODO deside if this is going to be a list of string 
        // or a Entity of response tiems.
    }
}