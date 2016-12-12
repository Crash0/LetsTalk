#region Header
// <copyright file="ITeamMember.cs" company="GoDialog AS">
// File Created:  12/12-2016
// Last Modified: 12/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.Collections.Generic;

namespace LetsTalk.Core.Common.Contracts.Entities.Employee
{
    public interface ITeamMember
    {
        ICollection<ITeam> Team { get; set; }
    }
}