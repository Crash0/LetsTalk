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
            
            var survey = new Survey
            {
                #region Survey settup

                Title = "Undersøkelse om folks do vaner",
                Description = "Dette er en test undersøkelse om folks do vaner",
                
            };

            var question = new SurveyQuestion { Question = "How Manny times do you go to the toilet in a day?"};
            question.AddAnswer(new SurveyAlternative("Never"));
            question.AddAnswer(new SurveyAlternative("Once"));
            question.AddAnswer(new SurveyAlternative("2 - 4"));
            question.AddAnswer(new SurveyAlternative("5 or more"));
            survey.AddQuestion(question);

            question = new SurveyQuestion { Question = "How Manny times do you use others toilet in a week?" };
            question.AddAnswer(new SurveyAlternative("Never"));
            question.AddAnswer(new SurveyAlternative("Once"));
            question.AddAnswer(new SurveyAlternative("2 - 4"));
            question.AddAnswer(new SurveyAlternative("5 or more"));
            survey.AddQuestion(question);

            question = new SurveyQuestion { Question = "How Manny times do you wach toilet in a month?" };
            question.AddAnswer(new SurveyAlternative("Never"));
            question.AddAnswer(new SurveyAlternative("Once"));
            question.AddAnswer(new SurveyAlternative("2 - 4"));
            question.AddAnswer(new SurveyAlternative("5 or more"));
            survey.AddQuestion(question);
            #endregion
            
            SetupSurvey(survey);
            NextQuestionCommand = new DelegateCommand(NextQuestionAction);
            PreviousQuestionCommand = new DelegateCommand(PreviousQuestionAction);
            
        }

        private void SetupSurvey(Survey survey)
        {
            Survey = survey;
            CurrentQuestion = survey.Questions[0] as SurveyQuestion;
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
                //Display EndOf Survey
                EndSurvey();
            }
        }

        private void EndSurvey()
        {
            Survey.Validate();
        }


        public string Title { get { return this.title; } set { this.title = value; } }
        private string title = "Survey Title Gies here";
        private string viewTitle = "Customer Name : Survey ";
        private SurveyQuestion currentQuestion;
        private Survey Survey;
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
