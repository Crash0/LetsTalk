#region Header
// <copyright file="IAuthenticationService.cs" company="GoDialog AS">
// File Created:  2016 07 15
// Last Modified: 2016 201607 15 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.ServiceModel;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Business.Contracts
{
    [ServiceContract]
    public interface IAuthenticationService 
    {
        [OperationContract]
        string GetAuthenticationToken(string loginId,string passHash);

    }
}