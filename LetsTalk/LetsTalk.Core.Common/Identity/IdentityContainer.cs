#region Header
// <copyright file="IdentityContainer.cs" company="GoDialog AS">
// File Created:  2016 07 16
// Last Modified: 2016 201607 16 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.ComponentModel.Composition;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Core.Common.Identity
{
    [Export(typeof(IIdentityContainer))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class IdentityContainer : IIdentityContainer
    {
        public IdentityContainer()
        {
            
        }

        private string _AuthenticationToken;
        public string GetAuthenticationToken()
        {
            return "NotImplemented";
        }
    }
}