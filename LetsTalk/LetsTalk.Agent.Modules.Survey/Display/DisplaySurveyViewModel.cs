using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letstalk.Client.Entities;
using LetsTalk.Core.Common.UI.Core;
using System.ComponentModel.Composition;
using System.Diagnostics;
using LetsTalk.Core.Common.Contracts;
using Prism.Regions;

namespace LetsTalk.Agent.Modules.SurveyModule.Display
{
    [Export(typeof(IDisplaySurveyViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class DisplaySurveyViewModel : ViewModelBase, IDisplaySurveyViewModel
    {
        [Import] private IServiceFactory _serviceFactory;

        public DisplaySurveyViewModel()
        {
            CurrentQuestion = new SurveyQuestion
            {
                Question = "how many did u lol?",
                AnswerPossibilities = new List<string> {"1", "2 - 4", "5 - 7"}
            };
        }

        public string Title { get { return _title; } set { _title = value; } }
        private string _title = "Survey Title Gies here";
        private string _viewTitle = "Customer Name : Survey ";
        private SurveyQuestion _currentQuestion;

        public override string ViewTitle
        {
            get { return _viewTitle; }
            set { _viewTitle = value; }
        }

        public Survey Survey { get; set; }

        public SurveyQuestion CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                if (_currentQuestion == value) return;
                _currentQuestion = value;
                OnPropertyChanged(()=> CurrentQuestion);
                
            }
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            var surveyKey = navigationContext.Parameters["surveyKey"];
            var targetKey = navigationContext.Parameters["targetKey"];
            
        }
    }
}
