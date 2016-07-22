using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Media;

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

            var tabControl = FindParrent<TabControl>(tabItem@);
            if (tabControl == null) return;

            tabControl.Items.Remove(tabItem.Content);

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
