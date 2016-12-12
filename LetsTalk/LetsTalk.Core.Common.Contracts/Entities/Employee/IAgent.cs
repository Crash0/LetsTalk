#region Header
// <copyright file="IAgent.cs" company="GoDialog AS">
// File Created:  12/12-2016
// Last Modified: 12/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System;

namespace LetsTalk.Core.Common.Contracts.Entities.Employee
{
    public interface IAgent
    {
        Guid AgetnId { get; set; }

        string LoginId { get; }

        string PasswordHash { get; }

        string Salt { get; }
    }
}