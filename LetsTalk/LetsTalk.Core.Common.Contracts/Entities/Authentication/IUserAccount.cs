#region Header
// <copyright file="IUserAccount.cs" company="GoDialog AS">
// File Created:  08/12-2016
// Last Modified: 08/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Core.Common.Contracts.Entities.Authentication
{
    using System;

    public interface IUserAccount
    {
        Guid AccountId { get; set; }

        Guid CorrelationGuid { get; set; }
        
        string LoginEmail { get; set; }


        /*
        TODO: Implement where needed
        public int UID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int userType { get; set; }
        public string CryptPassword { get; set; }
        public string LoginName { get; set; }
        public int AddressId { get; set; }
        public System.DateTime HireDate { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<TimeRegistration> TimeRegistration { get; set; }
        public virtual ICollection<CustomerChanges> CustomerChange { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Survey> Survey { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Team> Team { get; set; }
         */



    }
}