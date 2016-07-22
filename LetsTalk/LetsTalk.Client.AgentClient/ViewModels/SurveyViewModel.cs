using System.ComponentModel.Composition;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Client.AgentClient.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class SurveyViewModel : ViewModelBase
    {
        private IServiceFactory _serviceFactory;

        protected override string ViewTitle => "Surveys";

        [ImportingConstructor]
        public SurveyViewModel(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }
    }
}