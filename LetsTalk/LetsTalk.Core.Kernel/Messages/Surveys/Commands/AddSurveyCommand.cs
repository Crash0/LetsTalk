using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsTalk.Services.SurveyService.Contracts.Messages.Commands
{
    using LetsTalk.Business.Entities.Survey;

    public class AddSurveyCommand
    {
        public Survey surveyToAdd { get; set; }
    }
}
