#region Header
// <copyright file="TargetDisplayViewModel.cs" company="GoDialog AS">
// File Created:  04/12-2016
// Last Modified: 04/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Agent.Modules.Targets.TargetViewer.Display
{
    using System;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Primitives;

    using Letstalk.Client.Entities.Miscellaneous;
    using Letstalk.Client.Entities.Targeting;

    using LetsTalk.Core.Common.Contracts.Entities;
    using LetsTalk.Core.Common.UI.Core;

    [Export(typeof(ITargetDisplayViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TargetDisplayViewModel : ViewModelBase, ITargetDisplayViewModel
    {
        private Target target;
        public Target Target {
            get
            {
                return this.target;
            }
            set
            {
                this.target = value;
                OnPropertyChanged(() => this.Target);
            }
        }

        public TargetDisplayViewModel()
        {
            Target = new Target
                         {
                             Address =
                                 new Address
                                     {
                                         AddressLine1 = "Nyveien 11",
                                         City = "Hunndalen",
                                         PostalCode = "2827",
                                         CountryRegion = "Norway"
                                     },
                             IsBillingAddressDiffrent = false,
                             Birthdate = new DateTime(1994, 06, 04),
                             Gender = Gender.Male,
                             EmailAddress = "jvf_94@live.no",
                             Surname = "Fjeld",
                             GivenName = "Jonas Viktor",
                             TargetId = Guid.NewGuid()
                         };
        }

        public override string ViewTitle
        {
            get
            {
                if (this.Target != null) return "Target Display: " + this.Target.DisplayFullname;
                return base.ViewTitle;
            }
        }
    }
}