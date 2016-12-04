#region Header
// <copyright file="TargetEditViewModel.cs" company="GoDialog AS">
// File Created:  04/12-2016
// Last Modified: 04/12-2016 By Jonas Fjeld
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>
#endregion
namespace LetsTalk.Agent.Modules.Targets.TargetViewer.Edit
{
    using System.ComponentModel.Composition;

    using Letstalk.Client.Entities.Targeting;

    using LetsTalk.Core.Common.UI.Core;

    public interface ITargetEditViewModel
    {
        Target Target { get; set; }

    }

    [Export(typeof(ITargetEditViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TargetEditViewModel : ViewModelBase, ITargetEditViewModel
    {
        private Target target;
        public Target Target { get; set; }

        public override string ViewTitle
        {
            get
            {
                if (target == null)
                {
                    return "Creating New Target";
                }
                else
                {
                    return $"Editing Target : {this.target.Surname}, {this.target.GivenName}";
                }
            }
        }
    }
}