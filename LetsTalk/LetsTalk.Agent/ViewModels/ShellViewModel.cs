﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LetsTalk.Core.Common.UI;
using Prism.Commands;
using Prism.Regions;

namespace LetsTalk.Agent.ViewModels
{
    [Export]
    public class ShellViewModel
    {
        private IRegionManager _regionManager;

        [ImportingConstructor]
        public ShellViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(OnNavigate);
            
        }

        public DelegateCommand<string> NavigateCommand { get; set; }

        private void OnNavigate(string Path)
        {
            var param = new NavigationParameters();
            param.Add(NavigationKeys.TargetKey, "UIDKeyToCustomer");
            param.Add(NavigationKeys.SurveyKey,"surveyKey");
            _regionManager.RequestNavigate(RegionNames.MainRegion,Path + param);
        }
    }
}
