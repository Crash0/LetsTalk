#region Header
// <copyright file="ITeam.cs" company="GoDialog AS">
// File Created:  08/12-2016
// Last Modified: 08/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Core.Common.Contracts.Entities.Employee
{
    using System;
    using System.Collections.Generic;

    public interface ITeam
    {
        // TODO: implement some setters
        Guid TeamId { get; }

        string Name { get; }

        string Description { get; }

        Guid TeamLeader { get; }

        // TODO: manye List Of ITeamMember?
        IList<Guid> TeamMembers { get; }
    }
}