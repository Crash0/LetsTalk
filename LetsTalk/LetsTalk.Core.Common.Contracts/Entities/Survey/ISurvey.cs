#region Header
// <copyright file="ISurvey.cs" company="GoDialog AS">
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

    public interface ISurvey
    {

        //TODO: rename this to SurveyID
        Guid Id { get; set; }
       
        Guid CreatedBy { get; }
        DateTime CreatedDateTime { get; }
        DateTime LastModifyed { get; set; }

        string Title { get; set; }
    
        string Description { get; set; }

        List<ISurveyQuestion> Questions { get; set; }
    }
}