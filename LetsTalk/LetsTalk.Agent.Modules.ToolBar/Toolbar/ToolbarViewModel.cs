#region Header
// <copyright file="ToolbarViewModel.cs" company="GoDialog AS">
// File Created:  2016 11 18
// Last Modified: 2016 201611 18 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.UI.Commands;
using LetsTalk.Core.Common.UI.Core;
using Prism.Events;

namespace LetsTalk.Agent.Modules.ToolBar.Toolbar
{
    [Export(typeof(IToolbarViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ToolbarViewModel : ViewModelBase, IToolbarViewModel
    {
        private readonly IEventAggregator _eventAggregator;

        [ImportingConstructor]
        public ToolbarViewModel(IEventAggregator eventAggregator )
        {
            _eventAggregator = eventAggregator;
            
        }

        public ObservableCollection<ToolbarActionDelegate> ToolbarActions { get; }
    }

    public interface IToolbarViewModel
    {
        ObservableCollection<ToolbarActionDelegate> ToolbarActions { get; }
    }
}