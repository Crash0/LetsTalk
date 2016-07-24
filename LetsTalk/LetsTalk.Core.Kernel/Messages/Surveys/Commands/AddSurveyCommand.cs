using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Business.Entities.Surveys;

namespace LetsTalk.Services.SurveyService.Contracts.Messages.Commands
{
    public class AddSurveyCommand
    {
        public Survey surveyToAdd { get; set; }
    }
}
