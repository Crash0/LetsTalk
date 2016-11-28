#region Header
// <copyright file="ToolbarViewModel.cs" company="GoDialog AS">
// File Created:  2016 11 18
// Last Modified: 2016 201611 18 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.UI.Commands;
using LetsTalk.Core.Common.UI.Core;
using LetsTalk.Core.Common.UI.Events;
using Prism.Commands;
using Prism.Events;

namespace LetsTalk.Agent.Modules.ToolBar.Toolbar
{
    [Export(typeof(IToolbarViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ToolbarViewModel : ViewModelBase, IToolbarViewModel, IDisposable
    {
        private readonly IEventAggregator _eventAggregator;
        private SubscriptionToken _subscriptionToken;
        private readonly ObservableCollection<ToolbarActionDelegate> _toolbarActions;

        [ImportingConstructor]
        public ToolbarViewModel(IEventAggregator eventAggregator )
        {
            _toolbarActions = new ObservableCollection<ToolbarActionDelegate>();
            _eventAggregator = eventAggregator;
            _subscriptionToken = _eventAggregator.GetEvent<AddToolBarButtonEvent>().Subscribe(Action);

            /*
             * TestData
             */

            _toolbarActions.Add(new ToolbarActionDelegate() { DisplayName = "Test1" });
            _toolbarActions.Add(new ToolbarActionDelegate() { DisplayName = "Test2" });
            _toolbarActions.Add(new ToolbarActionDelegate() { DisplayName = "Test3" });


        }

        private void Action(ToolbarActionDelegate action)
        {
            _toolbarActions.Add(action);
        }

        public ObservableCollection<ToolbarActionDelegate> ToolbarActions => _toolbarActions;


        public void Dispose()
        {
            _eventAggregator.GetEvent<AddToolBarButtonEvent>().Unsubscribe(_subscriptionToken);
        }
    }
    
    public interface IToolbarViewModel
    {
        ObservableCollection<ToolbarActionDelegate> ToolbarActions { get; }
    }
}