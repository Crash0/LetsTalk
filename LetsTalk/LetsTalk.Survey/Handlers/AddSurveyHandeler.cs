namespace LetsTalk.Services.SurveyService.Handlers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using LetsTalk.Business.Entities.Survey;
    using LetsTalk.Core.Kernel.Messages;
    using LetsTalk.Services.SurveyService.Contracts.Messages.Commands;
    using LetsTalk.Services.SurveyService.Data;

    using NServiceBus;

    public class AddSurveyHandeler : IHandleMessages<AddSurveyCommand>
    {
        private IBus bus;

        [Import] private ISurveyRepository repository;

        public AddSurveyHandeler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(AddSurveyCommand message)
        {
            var survey = message.surveyToAdd;
            if (survey == null || !SurveyVallid(survey))
            {
                bus.Reply(new NotValidMessage("Survey Not Valid"));
            }
            else
            {
                repository.Add(message.surveyToAdd);
            }
            
        }

        private bool SurveyVallid(Survey survey)
        {
            //ToDo: implement validation
            return true;
        }
    }
}
