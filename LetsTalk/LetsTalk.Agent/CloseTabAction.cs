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
    public class CloseTabAction : TriggerAction<Button>
    {
        protected override void Invoke(object parameter)
        {
            var args = parameter as RoutedEventArgs;
            if(args == null) return;

            var tabItem = FindParrent<TabItem>(args.OriginalSource as DependencyObject);
            if(tabItem == null) return;

            var tabControl = FindParrent<TabControl>(tabItem);
            if (tabControl == null) return;

            var region = RegionManager.GetObservableRegion(tabControl).Value;
            if (region == null) return;
            RemoveItemFromRegion(tabItem.Content,region);
               
        }

        void RemoveItemFromRegion(object item, IRegion region)
        {
            var navigationContext = new NavigationContext(region.NavigationService,null);
            if (CanRemove(item, navigationContext))
            {
                InvokeOnNavigatedFrom(item,navigationContext);
                region.Remove(item);
            }
        }

        void InvokeOnNavigatedFrom(object item, NavigationContext navigationContext)
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

        bool CanRemove(object item, NavigationContext navigationContext)
        {
            var canRemove = true;

            var confirmRequestItem = item as IConfirmNavigationRequest;
            confirmRequestItem?.ConfirmNavigationRequest(navigationContext, result =>
            {
                canRemove = result;
            });

            var frameworkElement = item as FrameworkElement;
            if (frameworkElement != null && canRemove)
            {
                var confirmNavigation = frameworkElement.DataContext as IConfirmNavigationRequest;
                confirmNavigation?.ConfirmNavigationRequest(navigationContext, result =>
                {
                    canRemove = result;
                });
            } 

            return canRemove;
        }

        static T FindParrent<T>(DependencyObject child) where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(child);
            if (parentObject == null) return null;

            var parrent = parentObject as T;
            if (parrent !=null)
                return parrent;

            return FindParrent<T>(parentObject);
        }
    }
}
