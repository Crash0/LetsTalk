using System;
using System.ServiceModel;
using LetsTalk.Business.Entities.Surveys;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Exceptions;

namespace LetsTalk.Business.Contracts
{
    [ServiceContract]
    public interface ISurveyService
    {
        [OperationContract]
        Survey GetSurvey(string id);

        [OperationContract]
        Survey[] GetApplicableSurveys(string userId);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Survey UpdateSurvey(Survey survey);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void DeleteSurvey(string id);

    }
}
