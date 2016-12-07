using System;
using System.ServiceModel;

using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Exceptions;

namespace LetsTalk.Business.Contracts
{
    using LetsTalk.Core.Common.Contracts.Entities;

    [ServiceContract]
    public interface ISurveyService
    {
        [OperationContract]
        ISurvey GetSurvey(string id);

        [OperationContract]
        ISurvey AddSurvey(ISurvey survey);

        [OperationContract]
        ISurvey[] GetApplicableSurveys(string userId);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        ISurvey UpdateSurvey(ISurvey survey);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void DeleteSurvey(string id);

    }
}
