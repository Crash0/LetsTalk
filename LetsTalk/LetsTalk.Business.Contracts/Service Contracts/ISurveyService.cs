using System;
using System.ServiceModel;

using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Exceptions;

namespace LetsTalk.Business.Contracts
{
    using LetsTalk.Business.Entities.Survey;

    [ServiceContract]
    public interface ISurveyService
    {
        [OperationContract]
        Survey GetSurvey(string id);

        [OperationContract]
        Survey AddSurvey(Survey survey);

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
