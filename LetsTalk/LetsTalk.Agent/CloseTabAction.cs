// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CloseTabAction.cs" company="GoDialog">
//   Copyright (C) 2016 Jonas Fjeld.
//   This file is part of LetsTalk Software pack.
//   License: Attribution-NonCommercial-ShareAlike 4.0 International.
//   See https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

using Prism.Regions;

namespace LetsTalk.Agent
{
    /// <summary>
    /// TODO The close tab action.
    /// </summary>
    public class CloseTabAction : TriggerAction<Button>
    {
        /// <summary>
        /// TODO The invoke.
        /// </summary>
        /// <param name="parameter">
        /// TODO The parameter.
        /// </param>
        protected override void Invoke(object parameter)
        {
            var args = parameter as RoutedEventArgs;
            if (args == null) return;

            var tabItem = FindParrent<TabItem>(args.OriginalSource as DependencyObject);
            if (tabItem == null) return;

            var tabControl = FindParrent<TabControl>(tabItem);
            if (tabControl == null) return;

            var region = RegionManager.GetObservableRegion(tabControl).Value;
            if (region == null) return;
            RemoveItemFromRegion(tabItem.Content, region);
        }

        /// <summary>
        /// TODO The remove item from region.
        /// </summary>
        /// <param name="item">
        /// TODO The item.
        /// </param>
        /// <param name="region">
        /// TODO The region.
        /// </param>
        private void RemoveItemFromRegion(object item, IRegion region)
        {
            var navigationContext = new NavigationContext(region.NavigationService, null);
            if (CanRemove(item, navigationContext))
            {
                InvokeOnNavigatedFrom(item, navigationContext);
                region.Remove(item);
            }
        }

        /// <summary>
        /// TODO The invoke on navigated from.
        /// </summary>
        /// <param name="item">
        /// TODO The item.
        /// </param>
        /// <param name="navigationContext">
        /// TODO The navigation context.
        /// </param>
        private void InvokeOnNavigatedFrom(object item, NavigationContext navigationContext)
        {
            var navigationAware = item as INavigationAware;
            navigationAware?.OnNavigatedFrom(navigationContext);

            var frameworkElement = item as FrameworkElement;
            if (frameworkElement != null)
            {
                var navigationAwareDataContext = frameworkElement.DataContext as INavigationAware;
                navigationAwareDataContext?.OnNavigatedFrom(navigationContext);
            }
        }

        /// <summary>
        /// TODO The can remove.
        /// </summary>
        /// <param name="item">
        /// TODO The item.
        /// </param>
        /// <param name="navigationContext">
        /// TODO The navigation context.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool CanRemove(object item, NavigationContext navigationContext)
        {
            var canRemove = true;

            var confirmRequestItem = item as IConfirmNavigationRequest;
            confirmRequestItem?.ConfirmNavigationRequest(navigationContext, result => { canRemove = result; });

            var frameworkElement = item as FrameworkElement;
            if (frameworkElement != null && canRemove)
            {
                var confirmNavigation = frameworkElement.DataContext as IConfirmNavigationRequest;
                confirmNavigation?.ConfirmNavigationRequest(navigationContext, result => { canRemove = result; });
            }

            return canRemove;
        }

        /// <summary>
        /// Find the parrrent of a DependencyObject
        /// </summary>
        /// <param name="child">
        /// The child DependencyObject.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        private static T FindParrent<T>(DependencyObject child) where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(child);
            if (parentObject == null) return null;

            var parrent = parentObject as T;
            if (parrent != null) return parrent;

            return FindParrent<T>(parentObject);
        }
    }
}