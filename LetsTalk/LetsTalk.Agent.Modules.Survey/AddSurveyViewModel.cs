using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows;
using Letstalk.Client.Entities;
using LetsTalk.Core.Common.UI.Core;

namespace LetsTalk.Agent.Modules.SurveyModule
{
    [Export(typeof(IAddSurveyViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AddSurveyViewModel : ViewModelBase, IAddSurveyViewModel
    {
        public AddSurveyViewModel()
        {
            Questions = new ObservableCollection<SurveyQuestion>();
            
                Questions.Add(new SurveyQuestion { Question = "Can u lol?", AnswerPossibilities = new List<string> { "Yes siry bob", "nope!" } });
                Questions.Add(new SurveyQuestion { Question = "how many did u lol?", AnswerPossibilities = new List<string> { "1","2 - 4", "5 - 7" } });
                Questions.Add(new SurveyQuestion { Question = "How old are u rely?", AnswerPossibilities = new List<string> { "Yes siry bob", "nope!" } });
            
        }

        public Survey CurrentSurvey { get; set; }

        public override string ViewTitle => "Add new Survey!";

        public ObservableCollection<SurveyQuestion> Questions { get; set; }
        
    }
}
