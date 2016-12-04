// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddresspickerViewModel.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LetsTalk.Core.Common.UI.Controls
{
    #region Usings

    using System;
    using System.ComponentModel.Composition;
    using System.Windows.Input;

    using LetsTalk.Core.Common.Contracts.Entities;

    using Prism.Commands;

    #endregion

    /// <summary>
    /// TODO The address picker view model.
    /// </summary>
    [Export(typeof(IAddressPickerViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AddressPickerViewModel : IAddressPickerViewModel
    {

        public AddressPickerViewModel()
        {
            PickAddress = new DelegateCommand(ExecuteMethod);
        }

        private void ExecuteMethod()
        {
            throw new NotImplementedException();
        }

        public IAddress SelectedAddress { get; set; }

        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text
        {
            get
            {
                if (SelectedAddress == null)
                {
                    return string.Empty;
                }
                
                return this.SelectedAddress.IsUnknown
                           ? "Select a address"
                           : $"{this.SelectedAddress.AddressLine1}, {this.SelectedAddress.AddressLine2}, {this.SelectedAddress.PostalCode}, {this.SelectedAddress.City}";
            }
        }

        public ICommand PickAddress { get; private set; }
        
    }
}