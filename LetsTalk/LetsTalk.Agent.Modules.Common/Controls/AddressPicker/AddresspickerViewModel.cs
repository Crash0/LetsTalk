// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddresspickerViewModel.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//             This file is part of LetsTalk Software pack.
//             License: Attribution-NonCommercial-ShareAlike 4.0 International.
//             See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LetsTalk.Agent.Modules.Common.Controls
{
    #region Usings

    using System.ComponentModel.Composition;
    using System.Windows;
    using System.Windows.Input;
    
    using LetsTalk.Core.Common.Contracts.Entities;
    using LetsTalk.Core.Common.UI.Core;

    using Prism.Commands;

    #endregion

    /// <summary>
    /// TODO The address picker view model.
    /// </summary>
    [Export(typeof(IAddressPickerViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AddressPickerViewModel : ViewModelBase, IAddressPickerViewModel
    {
        //private DialogManager dialogManager;
        public AddressPickerViewModel()
        {
            this.PickAddress = new DelegateCommand(this.ExecuteMethod);
            //this.dialogManager = new DialogManager(Application.Current.MainWindow, Application.Current.Dispatcher);
        }

        private void ExecuteMethod()
        {
            var tt = new AddressView();
            //var dialog = this.dialogManager.CreateCustomContentDialog(tt,"Address",DialogMode.OkCancel);
            
            //dialog.Ok = () => 
            //{
            //    SelectedAddress = avvm.Address;
            //};
            
            //dialog.Show();
            


        }

        private IAddress _selectedAddress;

        public IAddress SelectedAddress
        {
            get
            {
                return this._selectedAddress;
            }
            set
            {
                this._selectedAddress = value;
                OnPropertyChanged(() => this.SelectedAddress);
            }
        }



        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text
        {
            get
            {
                if (this.SelectedAddress == null)
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