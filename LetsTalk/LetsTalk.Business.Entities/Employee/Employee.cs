#region Header
// <copyright file="Employee.cs" company="GoDialog AS">
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
using LetsTalk.Core.Common.Contracts.Entities.Employee;
using LetsTalk.Core.Common.Contracts.Entities.Timecard;

namespace LetsTalk.Business.Entities.Employee
{
    public class Employee : IEmployee, ITimecardUser
    {
        public Guid AgetnId { get; set; }
        public string LoginId { get; }
        public string PasswordHash { get; }
        public string Salt { get; }
        public string GivenName { get; }
        public string SurName { get; }
        public DateTime HireDate { get; }
        public IPhoneNumber PhoneNumber { get; set; }
        public IAddress HomeAddress { get; }

        //NavigationProperties
        public virtual ICollection<ITeam> Team { get; set; }
        public virtual ICollection<ITimecard> Timecards { get; set; }
    }
}