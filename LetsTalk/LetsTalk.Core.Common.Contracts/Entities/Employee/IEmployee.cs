#region Header
// <copyright file="IEmployee.cs" company="GoDialog AS">
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
    public interface IEmployee : ITeamMember, IAgent 
    {
        string GivenName { get; }
        string SurName { get; }

        DateTime HireDate { get; }



        IPhoneNumber PhoneNumber { get; set; }

        IAddress HomeAddress { get; }



    }
}