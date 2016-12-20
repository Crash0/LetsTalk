#region Header
// <copyright file="ISurveyAlternative.cs" company="GoDialog AS">
// File Created:  13/12-2016
// Last Modified: 13/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System;

namespace LetsTalk.Core.Common.Contracts.Entities
{
    public interface ISurveyAlternative
    {
        Guid AlternativeId { get; }

        Guid OwnerQuestion { get; }

        string Description { get; set; }

        string Alternative { get; }

        bool Selected { get; set; }
    }
}