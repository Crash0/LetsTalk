using System;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Agent.Modules.Customers
{
    [Export(typeof(ICustomerSearchViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerSearchViewModel : ViewModelBase, ICustomerSearchViewModel
    {
        public override string ViewTitle { get; } = "Customer Search";

        public CustomerSearchViewModel()
        {
        }
    }
}