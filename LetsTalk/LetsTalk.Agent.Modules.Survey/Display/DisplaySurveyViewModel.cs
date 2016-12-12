using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Letstalk.Client.Entities;
using LetsTalk.Core.Common.UI.Core;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows.Input;
using LetsTalk.Client.Entities.Miscellaneous;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Contracts.Entities;
using Prism.Commands;
using Prism.Regions;

namespace LetsTalk.Agent.Modules.SurveyModule.Display
{
    [Export(typeof(IDisplaySurveyViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class DisplaySurveyViewModel : ViewModelBase, IDisplaySurveyViewModel
    {
        [Import] private IServiceFactory serviceFactory;

        public DisplaySurveyViewModel()
        {
            
            Survey = new Survey
            {
                Id = Guid.NewGuid(),
                #region Survey settup

                Title = "Undersøkelse om folks do vaner",
                Description = "Dette er en test undersøkelse om folks do vaner",
                
            };
            Survey.AddQuestion(new SurveyQuestion
            {
                Question =
                    "How Manny times do you go to the toilet in a day?",
                AnswerPossibilities =
                    new List<string>
                    {
                        "Never",
                        "Once",
                        "2 - 4",
                        "5 or more"
                        
                    }
            });
            Survey.AddQuestion(new SurveyQuestion
            {
                Question =
                    "How Manny times do you wach toilet in a month?",
                AnswerPossibilities =
                    new List<string>
                    {
                        "Once",
                        "2 - 4",
                        "5 or more"
                    }
            });
            Survey.AddQuestion(new SurveyQuestion
            {
                Question =
                    "How Manny times do you use others toilet in a week?",
                AnswerPossibilities =
                    new List<string>
                    {
                        "Once",
                        "2 - 4",
                        "5 or more"
                    }
            });
            #endregion




            CurrentQuestion = Survey.Questions[0] as SurveyQuestion;
            
            NextQuestionCommand = new DelegateCommand(NextQuestionAction);
            PreviousQuestionCommand = new DelegateCommand(PreviousQuestionAction);
            
        }

        private void PreviousQuestionAction()
        {
            var next = currentQuestion.QuestionNumber - 1;
            if (Survey.Questions.Exists((question => question.QuestionNumber == next)))
            {
                CurrentQuestion = Survey.Questions[next] as SurveyQuestion;
            }
        }

        private void NextQuestionAction()
        {
            var next = currentQuestion.QuestionNumber + 1;
            if (Survey.Questions.Exists((question => question.QuestionNumber == next)))
            {
                CurrentQuestion = Survey.Questions[next] as SurveyQuestion;
            }
            else
            {
                //Display EndOf Survey.
            }
        }


        public string Title { get { return this.title; } set { this.title = value; } }
        private string title = "Survey Title Gies here";
        private string viewTitle = "Customer Name : Survey ";
        private SurveyQuestion currentQuestion;
        private Survey Survey;
        private SurveyResponse response;
        public override string ViewTitle
        {
            get { return this.viewTitle; }
        }
        
        public SurveyQuestion CurrentQuestion
        {
            get { return this.currentQuestion; }
            set
            {
                if (this.currentQuestion == value) return;
                this.currentQuestion = value;
                OnPropertyChanged(()=> CurrentQuestion);
                
            }
        }

        public DelegateCommand NextQuestionCommand { get; set; }

        public string Description => Survey.Description;

        public DelegateCommand PreviousQuestionCommand { get; set; }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            var surveyKey = navigationContext.Parameters["surveyKey"];
            var targetKey = navigationContext.Parameters["targetKey"];
            
        }
    }
}
