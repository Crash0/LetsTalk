using System;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.UI.Core;
using Prism.Regions;

namespace LetsTalk.Agent.Modules.Customers
{
    [Export(typeof(ICustomerSearchViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerSearchViewModel : ViewModelBase, ICustomerSearchViewModel
    {
        public override string ViewTitle { get; } = "Customer Search";
        public override bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public CustomerSearchViewModel()
        {
        }
    }
}