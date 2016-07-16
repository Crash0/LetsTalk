#region Header

// <copyright file="AuthenticationClient.cs" company="GoDialog AS">
// File Created:  2016 07 15
// Last Modified: 2016 201607 15 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

using System.ComponentModel.Composition;
using System.ServiceModel;
using System.Threading.Tasks;
using LetsTalk.Client.Contracts;
using LetsTalk.Core.Common.ServiceModel;

namespace LetsTalk.Client.Proxies
{
    [Export(typeof(IAuthenticationService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AuthenticationClient : UserClientBase<IAuthenticationService>, IAuthenticationService
    {
        public string GetAuthenticationToken(string loginId, string passHash)
        {
            return Channel.GetAuthenticationToken(loginId, passHash);
        }

        public Task<string> GetAuthenticationTokenAsync(string loginId, string passHash)
        {
            return Channel.GetAuthenticationTokenAsync(loginId, passHash);
        }
    }
}