#region Header

// <copyright file="EditSurveyViewModel.cs" company="GoDialog AS">
// File Created:  2016 07 24
// Last Modified: 2016 201607 25 
// All rights reserved. 2016
// </copyright>
// <summary>  
// <summary>

#endregion

#region Usings

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows;
using Letstalk.Client.Entities;
using LetsTalk.Core.Common.UI.Core;

#endregion

namespace LetsTalk.Agent.Modules.SurveyModule
{
    [Export(typeof(IEditSurveyViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class EditSurveyViewModel : ViewModelBase, IEditSurveyViewModel
    {
        public EditSurveyViewModel()
        {
            Questions = new ObservableCollection<SurveyQuestion>();

            Questions.Add(new SurveyQuestion
            {
                Question = "Can u lol?",
                AnswerPossibilities = new List<string> {"Yes siry bob", "nope!"}
            });
            Questions.Add(new SurveyQuestion
            {
                Question = "how many did u lol?",
                AnswerPossibilities = new List<string> {"1", "2 - 4", "5 - 7"}
            });
            Questions.Add(new SurveyQuestion
            {
                Question = "How old are u rely?",
                AnswerPossibilities = new List<string> {"Yes siry bob", "nope!"}
            });
        }

        public Survey CurrentSurvey { get; set; }

        public override string ViewTitle => "Add new Survey!";

        public ObservableCollection<SurveyQuestion> Questions { get; set; }
    }
}