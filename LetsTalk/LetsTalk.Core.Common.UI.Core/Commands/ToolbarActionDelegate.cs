#region Header
// <copyright file="ToolbarActionDelegate.cs" company="GoDialog AS">
// File Created:  2016 11 18
// Last Modified: 2016 201611 18 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion

using System.Windows.Input;

namespace LetsTalk.Core.Common.UI.Commands
{
    public class ToolbarActionDelegate
    {
        string Key { get; set; }
        public ICommand Command { get; set; }
        public string DisplayName { get; set; }
    }
}