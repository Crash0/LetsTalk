#region Header
// <copyright file="AddressViewViewModel.cs" company="GoDialog AS">
// File Created:  04/12-2016
// Last Modified: 04/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Agent.Modules.Common.Controls
{
    using LetsTalk.Core.Common.Contracts.Entities;

    public class AddressViewViewModel
    {
        public AddressViewViewModel()
        {
            
        }

        public IAddress Address { get; set; }
    }
}