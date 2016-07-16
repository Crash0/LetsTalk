﻿using System;
using System.ServiceModel;
using LetsTalk.Business.Contracts;
using LetsTalk.Business.Entities.Surveys;
using LetsTalk.Core.Common.Exceptions;

namespace LetsTalk.Business.Managers
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        ReleaseServiceInstanceOnTransactionComplete = false)]
    public class SurveyManager : ManagerBase, ISurveyService
    {
        public Survey GetSurvey(string id)
        {
            return
                ExecuteFaultHandeledOperation(
                    () => new Survey {Id = Guid.NewGuid(), Description = "NotImplemented", Title = "NotImplemented"});
        }

        public Survey[] GetApplicableSurveys(string userId)
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
        public Survey UpdateSurvey(Survey survey)
        {
            Survey updatedSurvey = null;
            return ExecuteFaultHandeledOperation(() =>
            {
                if (survey.Id == Guid.Empty)
                {
                    //add new survey
                    updatedSurvey = survey;
                }
                //update existing
                updatedSurvey = survey;
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