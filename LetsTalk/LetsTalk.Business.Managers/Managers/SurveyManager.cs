using System;
using System.ComponentModel.Composition;
using System.ServiceModel;
using System.Threading.Tasks;
using LetsTalk.Business.Contracts;
using LetsTalk.Core.Common.Exceptions;
using LetsTalk.Services.SurveyService.Contracts.Messages.Commands;
using NServiceBus;

namespace LetsTalk.Business.Managers
{
    using LetsTalk.Business.Entities.Survey;
    using LetsTalk.Core.Common.Contracts.Entities;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        ReleaseServiceInstanceOnTransactionComplete = false)]
    public class SurveyManager : ManagerBase, ISurveyService
    {
        [Import] private IBus bus;
        public ISurvey GetSurvey(string id)
        {
            return
                ExecuteFaultHandeledOperation(
                    () => new Survey {Id = Guid.NewGuid(), Description = "NotImplemented", Title = "NotImplemented"});
        }

        public ISurvey AddSurvey(ISurvey survey)
        {
            var message = new AddSurveyCommand
            {
                surveyToAdd = (Survey)survey
            };

            Survey resultSurvey = new Survey();
            var task = bus.Send(message).Register((result =>
            {
                var reply = result.Messages;
                
                return;

            }));

            var a =  task.GetAwaiter();
            a.GetResult();
            return resultSurvey;
        }


        public ISurvey[] GetApplicableSurveys(string userId)
        {
            return ExecuteFaultHandeledOperation(() =>
            {
                Survey[] surveys =
                {
                    new Survey {Id = Guid.NewGuid(), Description = "NotImplemented", Title = "NotImplemented"},
                    new Survey {Id = Guid.NewGuid(), Description = "NotImplemented", Title = "NotImplemented"}
                };

                if (surveys == null)
                {
                    throw new NotFoundException("List is Empty");
                }

                return surveys;
            });
        }


        [OperationBehavior(TransactionScopeRequired = true)]
        public ISurvey UpdateSurvey(ISurvey survey)
        {
            Survey updatedSurvey = null;
            return ExecuteFaultHandeledOperation(() =>
            {
                if (survey.Id == Guid.Empty)
                {
                    //add new survey
                    updatedSurvey = (Survey)survey;
                }
                //update existing
                updatedSurvey = (Survey)survey;
                if (updatedSurvey == null)
                {
                    throw new FaultException("Something happend -_-");
                }

                return updatedSurvey;
            });
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void DeleteSurvey(string id)
        {
            //delete
        }
    }
}