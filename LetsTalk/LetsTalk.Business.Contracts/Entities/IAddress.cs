#region Header

// <copyright file="IAddress.cs" company="GoDialog AS">
// File Created:  2016 07 23
// Last Modified: 2016 201607 23 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

namespace LetsTalk.Business.Contracts.Entities
{
    public interface IAddress
    {
        string PostalAddress1 { get; set; }
        string PostalAddress2 { get; set; }
        string PostalPlace { get; set; }
        string PostalNumber { get; set; }
    }
}